using System;
using UnityEngine;

namespace Attack
{
    public class AmmoSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _ammo;
        
        public void Spawn(Transform localScale)
        {
            var ammo = Instantiate(_ammo, gameObject.transform.position, Quaternion.identity);
            ammo.GetComponent<Ammo>().SetDirection(localScale.localScale.x);
        }
    }
}