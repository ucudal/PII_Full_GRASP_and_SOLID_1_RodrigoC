using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class CostCalculator
    {
        public double GetCost(Recipe recipe)
        {
            double ProductCost = 0;
            double TotalProductCost = 0;
            double EquipmentCost = 0;
            double TotalEquipmentCost = 0;
            

            foreach (Step step in recipe.Calculatesteps())
            {
                ProductCost = step.Input.UnitCost * step.Quantity;
                TotalProductCost += ProductCost;
                EquipmentCost = (step.Time / 60) * step.Equipment.HourlyCost;
                TotalEquipmentCost += EquipmentCost; 
            }

            return TotalProductCost + TotalEquipmentCost;
    }
}
}