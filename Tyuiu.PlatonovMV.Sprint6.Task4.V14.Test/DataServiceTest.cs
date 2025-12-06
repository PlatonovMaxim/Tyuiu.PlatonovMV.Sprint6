using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint6.Task4.V14.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_ValidRange()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] res = ds.GetMassFunction(start, stop);

            // Длина массива: stop - start + 1 = 11
            Assert.AreEqual(11, res.Length);

            // Проверим точку x = 0 (индекс 5)
            // F(0) = 2*0 - 4 + (-1)/(sin(0)+1) = -4 - 1 = -5 .
            double expected = -5.00;
            Assert.AreEqual(expected, res[5]);
        }
    }
}