using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        
        public int[,] GetMatrix(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не задан", nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string fileData = File.ReadAllText(path);

            
            fileData = fileData.Replace("\r\n", "\n");

            
            string[] lines = fileData.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            
            int rows = lines.Length;

            
            string[] firstRow = lines[0].Split(';', StringSplitOptions.RemoveEmptyEntries);
            int cols = firstRow.Length;

            int[,] arrayValues = new int[rows, cols];

            
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }
    }
}