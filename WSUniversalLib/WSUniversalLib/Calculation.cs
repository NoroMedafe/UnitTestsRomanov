using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int CalculationAmountMaterials(float wignt, float lenght, int count, float productType, float materialType)
        {
            if (wignt <= 0 || lenght <=0  || count <= 0)
            {
                return -1;                                                                                                                                                                                           
            }
            switch (productType)
            {
                case 1:
                    productType = 1.1f;
                    break;
                case 2:
                    productType = 2.5f;
                    break;
                case 3:
                    productType = 8.43f;
                    break;

                default:
                    return -1;
            }

            switch (materialType)
            {
                case 1:
                    materialType = 0.003f;
                    break;
                case 2:
                    materialType = 0.012f;
                    break;
            
                default:
                    return -1;
            }

            double countMaterial = (wignt * lenght * productType) * count;
            countMaterial = countMaterial + (materialType * countMaterial);
            countMaterial = Math.Ceiling(countMaterial);
           
            return Convert.ToInt32(countMaterial);
        }
    }
}
