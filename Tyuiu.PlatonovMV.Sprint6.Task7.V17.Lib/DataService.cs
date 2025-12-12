using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PlatonovMV.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length; //10
            int cols = lines[0].Split(';').Length; //10

            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] parts = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = Convert.ToInt32(parts[c]);
                }
            }

            
            for (int c = 0; c < cols; c++)
            {
                if (matrix[1, c] % 2 == 0)
                {
                    matrix[1, c] = 4;
                }
            }

            return matrix;
        }
    }
}
//Изменить во второй строке четные числа на 4
//1	-8	5	-17	-15	-11	-9	1	3	19 
//4 - 8  16  3 - 12 - 3  8 - 12 15  16
//- 15 - 1  10 - 7  8   2 - 20 - 1  2 - 1
//- 12 10 - 18 - 11 - 12 - 16 - 14 16  1 - 5
//5   14 - 11 - 3  10 - 19 - 1 - 12 - 5 - 20
//- 7 - 16 - 4  0   10  4 - 3 - 7 - 7 - 17
//- 18 7 - 13 - 2  18 - 8 - 16 15  17  11
//7   5   6 - 7  9 - 9 - 11 - 13 19 - 4
//- 5  14 - 2 - 9  18  16  20 - 14 7   17
//- 9  8   2   4 - 3 - 14 16  17 - 9  17
