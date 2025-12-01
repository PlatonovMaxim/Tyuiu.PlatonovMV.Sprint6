using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        // Табулирование функции F(x) = 3x + 2 - (2x - x)/(cos(x)+1)
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = Math.Cos(x) + 1;
                double y;

                if (Math.Abs(denom) < 1e-10) 
                {
                    y = 0.0;
                }
                else
                {
                    y = 3 * x + 2 - (2 * x - x) / denom;
                }

                result[k] = Math.Round(y, 2); 
                k++;
            }

            return result;
        }
    }
}