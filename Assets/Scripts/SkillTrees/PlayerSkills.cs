using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    public event EventHandler OnSkillPointsChanged;
    public event EventHandler<OnSkillUnlockedEventArgs> OnSkillUnlocked;
    public class OnSkillUnlockedEventArgs : EventArgs
    {
        public SkillType skillType;
    }
    public enum SkillType
    {
        None,
        Ability1,
        Ability2,
        Ability3
    }
    private List<SkillType> unlockedSkillTypeList;
    private int skillPoints = 2;

    public PlayerSkills()
    {
        unlockedSkillTypeList = new List<SkillType>(); 
    }
    public void AddSkillPoint()
    {
        skillPoints++;
        OnSkillPointsChanged?.Invoke(this, EventArgs.Empty);
    }

    public int GetSkillPoints()
    {
        return skillPoints;
    }
    private void UnlockSkill(SkillType skillType)
    {
        if (!IsSkillUnlocked(skillType))
        {
            unlockedSkillTypeList.Add(skillType);
            OnSkillUnlocked?.Invoke(this, new OnSkillUnlockedEventArgs { skillType = skillType });
        }
    }
    public bool IsSkillUnlocked(SkillType skillType)
    {
        return unlockedSkillTypeList.Contains(skillType);    
    }

    public SkillType GetSkillRequirement(SkillType skillType)
    {
        switch (skillType)
        {
            case SkillType.Ability3: return SkillType.Ability2;
            case SkillType.Ability2: return SkillType.Ability1;
        }
        return SkillType.None;
    }



    public bool CanUnlock(SkillType skillType)
    {
        SkillType skillRequirement = GetSkillRequirement(skillType);

        if (skillRequirement != SkillType.None)
        {
            if (IsSkillUnlocked(skillRequirement))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
    }
    public bool TryUnlockSkill(SkillType skillType)
    {
        if (CanUnlock(skillType))
        {
            if (skillPoints > 0)
            {
                Debug.Log("try");
                skillPoints--;
                OnSkillPointsChanged?.Invoke(this, EventArgs.Empty);
                UnlockSkill(skillType);
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}