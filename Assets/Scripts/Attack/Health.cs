using System;
using UnityEngine;

namespace Attack
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float _value;

        public event Action<float> OnHealthChanged;
        
        public void GetDamage(float damageValue)
        {
            _value -= damageValue;
            OnHealthChanged?.Invoke(_value);
        }
    }
}