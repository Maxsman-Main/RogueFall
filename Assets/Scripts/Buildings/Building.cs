using System;
using UnityEngine;

namespace Buildings
{
    public class Building
    {
        private double _price;
        private string _name;
        private double _income;
        private int _level;

        public event Action<Building> OnUpgraded;
        
        public double Price => _price * (Math.Pow(1.5, _level) + 1);
        public string Name => _name;
        public double Income => _income * _level;
        
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public Building(double price, string name, double income)
        {
            _price = price;
            _name = name;
            _income = income;
        }

        public void Upgrade()
        {
            _level += 1;
            OnUpgraded?.Invoke(this);
        }

        public void MultiUpgrade(int level)
        {
            _level += level;
            OnUpgraded?.Invoke(this);
        }
    }
}