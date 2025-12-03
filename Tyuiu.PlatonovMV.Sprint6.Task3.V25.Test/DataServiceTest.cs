using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint6.Task3.V25.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_SortByThirdColumn()
        {
            DataService ds = new DataService();

            int[,] source =
            {
                { 14,  5,  -9, 18, 21 },
                { -5, -12, -12,  4, 28 },
                { 27, -2, -14, 23, 27 },
                { -19, -15, 17, 15,  1 },
                { 33,  2,   6, 24, 24 }
            };

            int[,] res = ds.Calculate(source);

            int rows = res.GetUpperBound(0) + 1;

            // проверяем, что третий столбец отсортирован по возрастанию
            for (int i = 0; i < rows - 1; i++)
            {
                Assert.IsTrue(res[i, 2] <= res[i + 1, 2]);
            }
        }
    }
}