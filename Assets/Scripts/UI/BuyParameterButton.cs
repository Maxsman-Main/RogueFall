using PlayerStats;
using UnityEngine;

namespace UI
{
    public class BuyParameterButton : MonoBehaviour
    {
        [SerializeField] private int _itemID;
        [SerializeField] private ParametersShop _shop;
        [SerializeField] private TipsController _tipsController;

        public void Buy()
        {
            var result = _shop.BuyParameter(_itemID);
            if (!result)
            {
                _tipsController.ShowCashTip();
            }
        }
    }
}