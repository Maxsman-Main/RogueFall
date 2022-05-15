using UnityEngine;

namespace Buildings
{
    public class Income : MonoBehaviour
    {
        [SerializeField] private PlayerBuildings _buildings;

        public double Value => CalculateIncome();
        
        private double CalculateIncome()
        {
            double income = 0;
            
            foreach (var building in _buildings.Items)
            {
                income += building.Income;
            }

            return income;
        }
    }
}