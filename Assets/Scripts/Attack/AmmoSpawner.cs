using System;
using UnityEngine;

namespace Attack
{
    public class AmmoSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _ammo;
        
        public void Spawn()
        {
            Instantiate(_ammo, gameObject.transform.position, Quaternion.identity);
        }
    }
}