using PlayerStats;
using UnityEngine;

namespace UI
{
    public class BuyParameterButton : MonoBehaviour
    {
        [SerializeField] private int _itemID;
        [SerializeField] private ParametersShop _shop;

        public void Buy()
        {
            _shop.BuyParameter(_itemID);
        }
    }
}