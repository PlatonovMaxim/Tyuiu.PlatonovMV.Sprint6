using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint6.Task2.V20.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] res = ds.GetMassFunction(start, stop);

            // длина массива: stop - start + 1 = 11
            Assert.AreEqual(11, res.Length);

            // точка x = 0 (индекс 5)
            // F(0) = sin(0)/(0+1.2) - sin(0)*2 - 0 = 0
            double expected = 0.00;
            Assert.AreEqual(expected, res[5]);
        }
    }
}