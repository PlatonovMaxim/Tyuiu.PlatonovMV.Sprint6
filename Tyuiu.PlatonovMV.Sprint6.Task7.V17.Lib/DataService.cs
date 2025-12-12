using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу пустой.", nameof(path));
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string[] lines = File.ReadAllLines(path)
                                 .Where(x => !string.IsNullOrWhiteSpace(x))
                                 .ToArray();

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] m = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] parts = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                    m[r, c] = int.Parse(parts[c]);
            }

            
            if (rows > 1)
            {
                for (int c = 0; c < cols; c++)
                    if (m[1, c] % 2 == 0) m[1, c] = 4;
            }

            return m;
        }
    }
}