using System.Collections.Generic;
using UnityEngine;

namespace Buildings
{
    public class PlayerBuildings : MonoBehaviour
    {
        private List<Building> _items = new List<Building>();

        public List<Building> Items => _items;

        public PlayerBuildings()
        {
            Building build1 = new Building(100, "Ферма", 0.05);
            Building build2 = new Building(500, "Завод", 0.5);
            Building build3 = new Building(1500, "Лаборатория", 1.5);

            _items.Add(build1);
            _items.Add(build2);
            _items.Add(build3);
        }
    }
}