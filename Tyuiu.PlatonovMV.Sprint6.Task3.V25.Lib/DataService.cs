using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        // Сортировка строк матрицы по возрастанию в третьем столбце (индекс 2)
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int[,] result = new int[rows, columns];

            // копируем, чтобы не портить исходный массив
            Array.Copy(matrix, result, matrix.Length);

            // простой пузырёк по строкам с учётом третьего столбца (index 2)
            int colIndex = 2;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - 1 - i; j++)
                {
                    if (result[j, colIndex] > result[j + 1, colIndex])
                    {
                        // меняем местами строки j и j+1
                        for (int c = 0; c < columns; c++)
                        {
                            int temp = result[j, c];
                            result[j, c] = result[j + 1, c];
                            result[j + 1, c] = temp;
                        }
                    }
                }
            }

            return result;
        }
    }
}