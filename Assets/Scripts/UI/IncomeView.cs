using System.Globalization;
using Buildings;
using TMPro;
using UnityEngine;

namespace UI
{
    public class IncomeView : MonoBehaviour
    {
        [SerializeField] private Income _income;
        [SerializeField] private PlayerBuildings _buildings;
        [SerializeField] private TMP_Text _incomeView;

        private void Awake()
        {
            foreach (var building in _buildings.Items)
            {
                building.OnUpgraded += UpdateIncomeView;
            }
        }

        private void UpdateIncomeView(Building building)
        {
            _incomeView.text = "Доход: " + _income.Value.ToString(CultureInfo.InvariantCulture) + "c";
        }
    }
}