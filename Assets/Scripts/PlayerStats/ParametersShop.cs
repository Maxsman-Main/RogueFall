using Attack;
using UnityEngine;

namespace PlayerStats
{
    public class ParametersShop : MonoBehaviour
    {
        [SerializeField] private PlayerParameters _parameters;
        [SerializeField] private Cash _cash;
        
        public void BuyParameter(int id)
        {
            if (_cash.Value >= _parameters.Items[id].Price)
            {
                _cash.ReduceCash((float)_parameters.Items[id].Price);
                _parameters.Items[id].Upgrade();
            }
        }
    }
}