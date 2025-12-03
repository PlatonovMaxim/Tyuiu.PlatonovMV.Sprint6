using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        // Сортировка по возрастанию ТОЛЬКО в третьем столбце (индекс 2),
        // остальные элементы матрицы остаются на своих местах.
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int[,] result = new int[rows, columns];

            // копируем исходную матрицу
            Array.Copy(matrix, result, matrix.Length);

            int colIndex = 2; // третий столбец (индекс 2)

            // извлекаем третий столбец в отдельный одномерный массив
            int[] columnValues = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                columnValues[i] = result[i, colIndex];
            }

            // сортируем этот одномерный массив по возрастанию
            Array.Sort(columnValues);

            // записываем отсортированные значения обратно в третий столбец
            for (int i = 0; i < rows; i++)
            {
                result[i, colIndex] = columnValues[i];
            }

            return result;
        }
    }
}