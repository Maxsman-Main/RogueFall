using UnityEngine;
using System.Collections.Generic;
using Buildings;
using PlayerStats;

namespace DefaultNamespace
{
    public class PlayerData : MonoBehaviour
    {
        [SerializeField] private List<int> _items;
        [SerializeField] private List<int> _parameters;
        [SerializeField] private float _cash;

        public List<int> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public List<int> Parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }

        public float Cash
        {
            get
            {
                return _cash;
            }
            set
            {
                _cash = value;
            }
        }
    }
}