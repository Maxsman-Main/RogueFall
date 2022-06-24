using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DefaultNamespace;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    
    public void MainMenu()
    {
        _menuPanel.SetActive(!_menuPanel.activeSelf);
    }
}
