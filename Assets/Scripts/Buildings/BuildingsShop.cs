using Attack;
using DefaultNamespace;
using UnityEngine;

namespace Buildings
{
    public class BuildingsShop : MonoBehaviour
    {
        [SerializeField] private PlayerBuildings _buildings;
        [SerializeField] private Cash _cash;
        [SerializeField] private PlayerData _data;
        
        public bool BuyBuilding(int id)
        {
            if (_cash.Value >= _buildings.Items[id].Price)
            {
                _cash.ReduceCash((float)_buildings.Items[id].Price);
                _buildings.Items[id].Upgrade();
                _data.Items[id] += 1;
                return true;
            }

            return false;
        }
    }
}