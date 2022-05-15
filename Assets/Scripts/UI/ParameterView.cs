using PlayerStats;
using UnityEngine;
using TMPro;

namespace UI
{
    public class ParameterView : MonoBehaviour
    {
        [SerializeField] private int _parameterID;
        [SerializeField] private PlayerParameters _parameters;
        [SerializeField] private TMP_Text _priceView;
        [SerializeField] private TMP_Text _valueView;

        private void Start()
        {
            _parameters.Items[_parameterID].OnUpgraded += UpdateBuildingInformation;
            _priceView.text = ((int)(_parameters.Items[_parameterID].Price)).ToString() + "c";
            _valueView.text = ((int)(_parameters.Items[_parameterID].Value)).ToString() + "c";
        }

        private void UpdateBuildingInformation(Parameter parameter)
        {
            _priceView.text = ((int)(_parameters.Items[_parameterID].Price)).ToString() + "c";
            _valueView.text = ((int)(_parameters.Items[_parameterID].Value)).ToString() + "c";
        }
    }
}