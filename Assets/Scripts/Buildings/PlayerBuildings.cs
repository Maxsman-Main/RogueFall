using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DefaultNamespace;
using UI;
using UnityEngine;

namespace Buildings
{
    public class PlayerBuildings : MonoBehaviour
    {
        [SerializeField] private PlayerData _data;
        
        private List<Building> _items = new List<Building>();

        public List<Building> Items => _items;

        private void Awake()
        {
            Building build1 = new Building(100, "Ферма", 0.05);
            Building build2 = new Building(500, "Завод", 0.5);
            Building build3 = new Building(1500, "Лаборатория", 1.5);

            _items.Add(build1);
            _items.Add(build2);
            _items.Add(build3);

            StartCoroutine(Wait(_items, _data));
        }

        private IEnumerator Wait(List<Building> buildings, PlayerData data)
        {
            yield return new WaitForSeconds(1);
            for (int i = 0; i < data.Items.Count; i++)
            {
                buildings[i].MultiUpgrade(data.Items[i]);
            }
        }
    }
}