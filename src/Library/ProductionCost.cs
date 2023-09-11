using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost
    {
        public static double GetProductsCost(ArrayList stepsList, ArrayList productList)
        {
            double productCost = 0;

            foreach (Step step in stepsList)
            {
                productCost =+ step.Quantity * step.Input.UnitCost;
            }
            return productCost;
        }

        public static double GetEquipmentCost(ArrayList stepsList, ArrayList equipmentList)
        {
            double equipmentCost = 0;

            foreach (Step step in stepsList)
            {
                equipmentCost =+ step.Time * step.Equipment.HourlyCost/60;
            }
            return equipmentCost;
        }

        public static double GetProductionCost (double productCost, double equipmentCost)
        {
            double productionCost = productCost + equipmentCost;
            return productionCost;
        }

    }
}

/* Se asigna esta responsabilidad a una nueva clase debido al principio SRP (principio de la única responsabilidad),
una misma clase no puede tener múltiples responsabilidades y tiene que tener la información necesaria para cumplir sus tareas,
también se tiene en cuenta el principio Expert en el que una clase puede tener solo una posibilidad de cambio. */