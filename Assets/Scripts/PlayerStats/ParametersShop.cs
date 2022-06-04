using Attack;
using DefaultNamespace;
using UnityEngine;

namespace PlayerStats
{
    public class ParametersShop : MonoBehaviour
    {
        [SerializeField] private PlayerParameters _parameters;
        [SerializeField] private Cash _cash;
        [SerializeField] private PlayerData _data;
        
        public bool BuyParameter(int id)
        {
            if (_cash.Value >= _parameters.Items[id].Price)
            {
                _cash.ReduceCash((float)_parameters.Items[id].Price);
                _parameters.Items[id].Upgrade();
                _data.Parameters[id] += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}