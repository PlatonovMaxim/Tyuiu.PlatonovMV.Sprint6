using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V20
    {
        // Табулирование F(x) = sin(x)/(x+1.2) - sin(x)*2 - 2x
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = x + 1.2;
                double y;

                if (Math.Abs(denom) < 1e-10) // проверка деления на ноль
                {
                    y = 0.0;
                }
                else
                {
                    y = Math.Sin(x) / denom - Math.Sin(x) * 2 - 2 * x;
                }

                valueArray[count] = Math.Round(y, 2); // округление до 2 знаков
                count++;
            }

            return valueArray;
        }
    }
}