using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

namespace PlayerStats
{
    public class PlayerParameters : MonoBehaviour
    {
        [SerializeField] private PlayerData _data;

        private List<Parameter> _parameters = new List<Parameter>();

        public List<Parameter> Items => _parameters;

        private void Awake()
        {
            Parameter param1 = new Parameter(2000, "Здоровье", 10);
            Parameter param2 = new Parameter(10000, "Сила клика", 1);
            Parameter param3 = new Parameter(5000, "Скорость", 5);

            param1.Level = _data.Parameters[0];
            param2.Level = _data.Parameters[1];
            param3.Level = _data.Parameters[2];
            
            _parameters.Add(param1);
            _parameters.Add(param2);
            _parameters.Add(param3);
        }
    }
}