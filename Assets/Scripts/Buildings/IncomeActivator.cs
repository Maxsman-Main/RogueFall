using System;
using Attack;
using UnityEngine;

namespace Buildings
{
    public class IncomeActivator : MonoBehaviour
    {
        [SerializeField] private Income _income;
        [SerializeField] private Cash _cash;
        [SerializeField] private float _timeDelay;

        private float _timer = 0;

        private void Update()
        {
            _timer += Time.deltaTime;
            if (_timer > _timeDelay)
            {
                _timer = 0;
                _cash.GetCash((float)_income.Value);
            }
        }
    }
}