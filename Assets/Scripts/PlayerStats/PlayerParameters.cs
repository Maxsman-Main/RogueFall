using System.Collections.Generic;
using UnityEngine;

namespace PlayerStats
{
    public class PlayerParameters : MonoBehaviour
    {
        private List<Parameter> _parameters = new List<Parameter>();

        public List<Parameter> Items => _parameters;

        public PlayerParameters()
        {
            Parameter param1 = new Parameter(5000, "Здоровье", 10);
            Parameter param2 = new Parameter(10000, "Сила клика", 1);
            Parameter param3 = new Parameter(5000, "Скорость", 5);
            
            _parameters.Add(param1);
            _parameters.Add(param2);
            _parameters.Add(param3);
        }
    }
}