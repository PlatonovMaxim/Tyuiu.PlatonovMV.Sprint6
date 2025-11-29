using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PlatonovMV.Sprint6.Task0.V14.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            
            int x = 3;

            DataService ds = new DataService();
            double res = ds.Calculate(x);

            
            double wait = -0.444;

            Assert.AreEqual(wait, res);
        }
    }
}