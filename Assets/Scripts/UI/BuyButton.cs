using Buildings;
using DefaultNamespace;
using UnityEngine;

namespace UI
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private int _itemID;
        [SerializeField] private BuildingsShop _shop;
        [SerializeField] private TipsController _tipsController;
        
        public void Buy()
        {
            var result = _shop.BuyBuilding(_itemID);
            if (!result)
            {
                _tipsController.ShowCashTip();
            }
        }
    }
}