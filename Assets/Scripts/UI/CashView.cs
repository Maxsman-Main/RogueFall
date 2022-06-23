using System.Globalization;
using UnityEngine;
using TMPro;

namespace UI
{
    public class CashView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _view;
        
        public void ChangeCashView(float value)
        {
            _view.text = "CASH:" + ((int)value).ToString(CultureInfo.InvariantCulture);
        }
    }
}