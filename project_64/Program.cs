// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int[,] triangle = new int[row, row];
            const int cellWidth = 3;

            FillTriangle(triangle);
        }

        private static void FillTriangle(int[,] triangle)
        {
            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            for (int i = 2; i < triangle.GetLength(0); i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle[i, j] =
                        triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
        }

        private static void PrintTriangle(int[,] triangle)


    }
}
