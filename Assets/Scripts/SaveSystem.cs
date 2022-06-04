using System;
using PlayerStats;
using UnityEngine;

namespace DefaultNamespace
{
    public class SaveSystem : MonoBehaviour
    {
        [SerializeField] private PlayerData _playerData;

        public void Save()
        {
            PlayerPrefs.SetFloat("Cash", _playerData.Cash);
            PlayerPrefs.SetInt("Build1", _playerData.Items[0]);
            PlayerPrefs.SetInt("Build2", _playerData.Items[1]);
            PlayerPrefs.SetInt("Build3", _playerData.Items[2]);
            PlayerPrefs.SetInt("Param1", _playerData.Parameters[0]);
            PlayerPrefs.SetInt("Param2", _playerData.Parameters[1]);
        }

        public void Load()
        {
            if (PlayerPrefs.HasKey("Cash"))
            {
                _playerData.Cash = PlayerPrefs.GetFloat("Cash");
                _playerData.Items[0] = PlayerPrefs.GetInt("Build1");
                _playerData.Items[1] = PlayerPrefs.GetInt("Build2");
                _playerData.Items[2] = PlayerPrefs.GetInt("Build3");
                _playerData.Parameters[0] = PlayerPrefs.GetInt("Param1");
                _playerData.Parameters[1] = PlayerPrefs.GetInt("Param2");
            }
        }

        private void ClearSave()
        {
            PlayerPrefs.SetFloat("Cash", 0);
            PlayerPrefs.SetInt("Build1", 0);
            PlayerPrefs.SetInt("Build2", 0);
            PlayerPrefs.SetInt("Build3", 0);
            PlayerPrefs.SetInt("Param1", 0);
            PlayerPrefs.SetInt("Param2", 0);
        }
    }
}