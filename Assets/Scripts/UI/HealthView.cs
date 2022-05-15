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
            Debug.Log(value);
            _view.text = "Здоровье: " + value.ToString(CultureInfo.InvariantCulture);
        }
    }
}