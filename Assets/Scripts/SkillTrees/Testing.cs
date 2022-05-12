using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    [SerializeField] private Player1 player1;
    [SerializeField] private SkillsTree uiSkillTree;

    private void Start()
    {
        uiSkillTree.SetPlayerSkills(player1.GetPlayerSkills());
    }

}