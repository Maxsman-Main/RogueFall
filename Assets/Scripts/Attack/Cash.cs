using System;
using DefaultNamespace;
using UnityEngine;

namespace Attack
{
    public class Cash : MonoBehaviour
    {
        [SerializeField] private float _value;
        [SerializeField] private PlayerData _data;
        [SerializeField] private SaveSystem _saveSystem;
        
        public float Value => _value;
        
        public event Action<float> OnCashChanged;

        private void Start()
        {
            _saveSystem.Load();
            _value = _data.Cash;
        }
        
        public void GetCash(float cashValue)
        {
            _value += cashValue;
            _data.Cash = _value;
            OnCashChanged?.Invoke(_value);
        }

        public void ReduceCash(float cashValue)
        {
            _value -= cashValue;
            _data.Cash = _value;
            OnCashChanged?.Invoke(_value);
        }
    }
}