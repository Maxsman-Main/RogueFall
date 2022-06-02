using System.Globalization;
using UnityEngine;
using TMPro;

namespace UI
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _view;
        
        public void ChangeHealthView(float value)
        {
            _view.text = "HP:" + value.ToString(CultureInfo.InvariantCulture);
        }
    }
}