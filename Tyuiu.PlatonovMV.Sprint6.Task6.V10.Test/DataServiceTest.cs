using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PlatonovMV.Sprint6.Task6.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_FindWordsWithSmallW()
        {
            
            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new[]
            {
                "aaa nXkwQYzgZ bbb",
                "ccc LlckTwkpaAGTvLPc BRW",
                "ddd eee"
            });

            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);

            
            Assert.AreEqual("nXkwQYzgZ LlckTwkpaAGTvLPc", res);

            File.Delete(path);
        }
    }
}