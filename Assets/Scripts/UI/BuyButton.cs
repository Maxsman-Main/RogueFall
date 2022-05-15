using Buildings;
using UnityEngine;

namespace UI
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private int _itemID;
        [SerializeField] private BuildingsShop _shop;

        public void Buy()
        {
            _shop.BuyBuilding(_itemID);
        }
    }
}