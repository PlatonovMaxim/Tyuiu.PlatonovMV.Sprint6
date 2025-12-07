using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PlatonovMV.Sprint6.Task6.V10.Lib;

namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_FindWordsWithW()
        {
            
            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new[]
            {
                "nXkwQYzgZ tsCms LlckTwkpaAGTvLPc",
                "fthzqqL XcNHugFmbsRgVVfsgHNGuUC",
                "SeRTRfFeAxzn raCml PzLyVamXVcmNn",
                "dlezsxTS z KxFxadaTMeBz BRW pSuA",
                "tVMMaxdnYJoY EUAji hntD RTmxxVdu"
            });

            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);

            
            Assert.IsTrue(res.Contains("nXkwQYzgZ"));
            Assert.IsTrue(res.Contains("LlckTwkpaAGTvLPc"));
            Assert.IsTrue(res.Contains("PzLyVamXVcmNn"));

            string[] words = res.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(3, words.Length);

            File.Delete(path);
        }
    }
}