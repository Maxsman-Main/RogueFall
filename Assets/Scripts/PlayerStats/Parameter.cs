using System;

namespace PlayerStats
{
    public class Parameter
    {
        private double _price;
        private string _name;
        private double _value;
        private int _level = 1;
        
        public event Action<Parameter> OnUpgraded;
        
        public double Price => _price * (Math.Pow(2, _level));
        public string Name => _name;
        public double Value=> _value * (Math.Pow(2, _level));

        public Parameter(double price, string name, double value)
        {
            _price = price;
            _name = name;
            _value = value;
        }

        public void Upgrade()
        {
            _level += 1;
            OnUpgraded?.Invoke(this);
        }
    }
}