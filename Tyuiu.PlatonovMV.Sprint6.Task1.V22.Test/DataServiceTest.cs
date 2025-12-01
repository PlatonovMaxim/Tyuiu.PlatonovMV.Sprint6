using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint6.Task1.V22.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task1.V22.Test
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

            
            Assert.AreEqual(11, res.Length);

            
            double expected = 2.00;
            Assert.AreEqual(expected, res[5]);
        }
    }
}