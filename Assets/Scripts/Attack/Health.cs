using System;
using PlayerStats;
using UnityEngine;

namespace Attack
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private float _value;

        public float Value => _value;

        public event Action<float> OnHealthChanged;
        
        public void GetDamage(float damageValue)
        {
            _value -= damageValue;
            OnHealthChanged?.Invoke(_value);
        }

        public void UpHealth(float healthValue)
        {
            _value += healthValue;
            OnHealthChanged?.Invoke(_value);
        }

        public void SetHealth(Parameter parameter)
        {
            _value = (float)parameter.Value;
            OnHealthChanged?.Invoke(_value);
        }
    }
}