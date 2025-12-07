using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        // Читает числа из файла, убирает нули, округляет до 3 знаков
        public double[] LoadFromDataFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не задан", nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            List<double> nums = new List<double>();

            // важен CultureInfo, чтобы запятая корректно читалась
            var culture = new CultureInfo("ru-RU");

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line.Length == 0) continue;

                    if (double.TryParse(line, NumberStyles.Any, culture, out double val))
                    {
                        if (Math.Abs(val) > double.Epsilon) // != 0
                        {
                            nums.Add(Math.Round(val, 3));
                        }
                    }
                }
            }

            return nums.ToArray();
        }
    }
}