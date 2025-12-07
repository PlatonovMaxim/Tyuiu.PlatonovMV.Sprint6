using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Globalization;
using Tyuiu.PlatonovMV.Sprint6.Task5.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_IgnoreZeros()
        {
            // временный файл
            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new[] { "1", "0", "2,5", "0", "-3" });

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);

            Assert.AreEqual(3, res.Length); // 1, 2.5, -3

            File.Delete(path);
        }
    }
}