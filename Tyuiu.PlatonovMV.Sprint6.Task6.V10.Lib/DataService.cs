using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не задан", nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string text = File.ReadAllText(path);

            char[] separators = { ' ', '\t', '\r', '\n' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            
            var filtered = words.Where(w => w.Contains('w'));

            string result = string.Join(" ", filtered);
            return result;
        }
    }
}