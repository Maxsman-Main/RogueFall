using Attack;
using UnityEngine;

namespace Buildings
{
    public class BuildingsShop : MonoBehaviour
    {
        [SerializeField] private PlayerBuildings _buildings;
        [SerializeField] private Cash _cash;
        
        public bool BuyBuilding(int id)
        {
            if (_cash.Value >= _buildings.Items[id].Price)
            {
                _cash.ReduceCash((float)_buildings.Items[id].Price);
                _buildings.Items[id].Upgrade();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}