using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        // F(x) = 2x - 4 + (2x - 1)/(sin(x) + 1)
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = Math.Sin(x) + 1;
                double y;

                if (Math.Abs(denom) < 1e-10)
                {
                    y = 0.0;               // деление на ноль -> 0
                }
                else
                {
                    y = 2 * x - 4 + (2 * x - 1) / denom;
                }

                result[k] = Math.Round(y, 2); // округление до 2 знаков
                k++;
            }

            return result;
        }
    }
}
//
//
//