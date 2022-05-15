using Buildings;
using TMPro;
using UnityEngine;

namespace UI
{
    public class BuildingView : MonoBehaviour
    {
        [SerializeField] private int _buildingID;
        [SerializeField] private PlayerBuildings _buildings;
        [SerializeField] private TMP_Text _price;

        private void Awake()
        {
            _buildings.Items[_buildingID].OnUpgraded += UpdateBuildingInformation;
            _price.text = ((int)(_buildings.Items[_buildingID].Price)).ToString() + "c";
        }

        private void UpdateBuildingInformation(Building building)
        {
            _price.text = ((int)(_buildings.Items[_buildingID].Price)).ToString() + "c";
        }
    }
}