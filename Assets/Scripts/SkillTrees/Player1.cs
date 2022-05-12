using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player1 : MonoBehaviour
{

    private PlayerSkills playerSkills;

    private void Awake()
    {
        playerSkills = new PlayerSkills();
        playerSkills.OnSkillUnlocked += PlayerSkills_OnSkillUnlocked;
    }

    private void PlayerSkills_OnSkillUnlocked(object sender, PlayerSkills.OnSkillUnlockedEventArgs e)
    {
        switch (e.skillType)
        {
            case PlayerSkills.SkillType.Ability1:
                Debug.Log("Ability1");
                break;
            case PlayerSkills.SkillType.Ability2:
                Debug.Log("Ability2");
                break;
            case PlayerSkills.SkillType.Ability3:
                Debug.Log("Ability3");
                break;
        }
    }
    public PlayerSkills GetPlayerSkills()
    {
        return playerSkills;
    }
    public bool CanUseAbility1()
    {
        return playerSkills.IsSkillUnlocked(PlayerSkills.SkillType.Ability1);
    }

    public bool CanUseAbility2()
    {
        return playerSkills.IsSkillUnlocked(PlayerSkills.SkillType.Ability2);
    }

 

}