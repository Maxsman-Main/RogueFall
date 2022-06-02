using Buildings;
using TMPro;
using UnityEngine;

namespace UI
{
    public class BuildingView : MonoBehaviour
    {
        [SerializeField] private int _buildingID;
        [SerializeField] private PlayerBuildings _buildings;
        [SerializeField] private TextMeshProUGUI _price;

        private void Awake()
        {
            _price.text = _buildings.Items[_buildingID].Price.ToString() + "c";
            _buildings.Items[_buildingID].OnUpgraded += UpdateBuildingInformation;
        }

        private void UpdateBuildingInformation(Building building)
        {
            _price.text = _buildings.Items[_buildingID].Price.ToString() + "c";
        }
    }
}