using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PlatonovMV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix_ReadCsv_AndChangeSecondRowEvensTo4()
        {
            
            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new[]
            {
                "1;2;3",
                "4;5;6"
            });

            DataService ds = new DataService();

            
            int[,] m = ds.GetMatrix(path);

            
            Assert.AreEqual(1, m[0, 0]);
            Assert.AreEqual(2, m[0, 1]);
            Assert.AreEqual(3, m[0, 2]);

            
            Assert.AreEqual(4, m[1, 0]); // 4 -> 4
            Assert.AreEqual(5, m[1, 1]); // 5 -> 5
            Assert.AreEqual(4, m[1, 2]); // 6 -> 4

            
            File.Delete(path);
        }
    }
}