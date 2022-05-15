using System;
using UnityEngine;

namespace Attack
{
    public class Cash : MonoBehaviour
    {
        [SerializeField] private float _value;

        public float Value => _value;
        
        public event Action<float> OnCashChanged;
        
        public void GetCash(float cashValue)
        {
            _value += cashValue;
            OnCashChanged?.Invoke(_value);
        }

        public void ReduceCash(float cashValue)
        {
            _value -= cashValue;
            OnCashChanged?.Invoke(_value);
        }
    }
}