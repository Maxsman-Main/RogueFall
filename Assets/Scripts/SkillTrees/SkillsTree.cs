using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button_Ui.Utils;
using TMPro;
public class SkillsTree : MonoBehaviour
{

    [SerializeField] private Material skillLockedMaterial;
    [SerializeField] private Material skillUnlockableMaterial;

    private PlayerSkills playerSkills;
    private List<SkillButton> skillButtonList;
    private TextMeshProUGUI skillPointsText;

    private void Awake()
    {
        skillPointsText = transform.Find("skillPoints").GetComponent<TextMeshProUGUI>();
    }

    public void SetPlayerSkills(PlayerSkills playerSkills)
    {
        this.playerSkills = playerSkills;

        skillButtonList = new List<SkillButton>();
        skillButtonList.Add(new SkillButton(transform.Find("Ability1"), playerSkills, PlayerSkills.SkillType.Ability1, skillLockedMaterial, skillUnlockableMaterial));
        skillButtonList.Add(new SkillButton(transform.Find("Ability2"), playerSkills, PlayerSkills.SkillType.Ability2, skillLockedMaterial, skillUnlockableMaterial));
        skillButtonList.Add(new SkillButton(transform.Find("Ability3"), playerSkills, PlayerSkills.SkillType.Ability3, skillLockedMaterial, skillUnlockableMaterial));


        playerSkills.OnSkillUnlocked += PlayerSkills_OnSkillUnlocked;
        playerSkills.OnSkillPointsChanged += PlayerSkills_OnSkillPointsChanged;

        UpdateVisuals();
        UpdateSkillPoints();
    }

    private void PlayerSkills_OnSkillPointsChanged(object sender, System.EventArgs e)
    {
        UpdateSkillPoints();
    }

    private void PlayerSkills_OnSkillUnlocked(object sender, PlayerSkills.OnSkillUnlockedEventArgs e)
    {
        UpdateVisuals();
    }

    private void UpdateSkillPoints()
    {
        skillPointsText.SetText(playerSkills.GetSkillPoints().ToString());
    }

    private void UpdateVisuals()
    {
        foreach (SkillButton skillButton in skillButtonList)
        {
            skillButton.UpdateVisual();
        }
    }
    private class SkillButton
    {
        private Transform transform;
        private Image image;
        private Image backgroundImage;
        private PlayerSkills playerSkills;
        private PlayerSkills.SkillType skillType;
        [SerializeField] private Material skillLockedMaterial;
        [SerializeField] private Material skillUnlockableMaterial;

        public SkillButton(Transform transform, PlayerSkills playerSkills, PlayerSkills.SkillType skillType, Material skillLockedMaterial, Material skillUnlockableMaterial)
            {
            this.transform = transform;
            this.playerSkills = playerSkills;
            this.skillType = skillType;
            this.skillLockedMaterial = skillLockedMaterial;
            this.skillUnlockableMaterial = skillUnlockableMaterial;

            image = transform.Find("image").GetComponent<Image>();
            backgroundImage = transform.Find("background").GetComponent<Image>();

            transform.GetComponent<Button_UI>().ClickFunc = () => {
                if (!playerSkills.IsSkillUnlocked(skillType))
                {
                    if (!playerSkills.TryUnlockSkill(skillType))
                    {
                        Debug.Log("nope)");
                        //Maybe set message about locked skill
                    }
                }
            };
        }
        public void UpdateVisual()
        {
           if (playerSkills.IsSkillUnlocked(skillType))
            {
                image.material = null;
                backgroundImage.material = null;
            }
            else
            {
                if (playerSkills.CanUnlock(skillType))
                {
                    image.material = skillUnlockableMaterial;
                    backgroundImage.color = Color.white;
                    transform.GetComponent<Button_UI>().enabled = true;
                }
                else
                {
                    image.material = skillLockedMaterial;
                    backgroundImage.color = new Color(.3f, .3f, .3f);
                    transform.GetComponent<Button_UI>().enabled = false;
                }
            }
        }

    }

}
