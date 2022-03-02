using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_74
{
    static class MatrixExt
    {
        public static int RowsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        public static int ColumnsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = FillMatrix("номер 1");
            var b = FillMatrix("номер 2");

            Console.WriteLine("номер 1: ");
            PrintMatrix(a);

            Console.WriteLine("номер 2: ");
            PrintMatrix(b);

            var result = MatrixMultiplication(a, b);
            Console.WriteLine("Произведение матриц:");
            PrintMatrix(result);

            Console.ReadLine();
        }
        static int[,] FillMatrix(string name)
        {
            Console.Write("Количество строк матрицы {0}:    ", name);
            int n = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы {0}: ", name);
            int k = int.Parse(Console.ReadLine());


            int[,] matrix = new int[n, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.RowsCount(); i++)
            {
                for (int j = 0; j < matrix.ColumnsCount(); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }

                Console.WriteLine();
            }
        }

        static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Умножение не возможно! Необходимо ввести квадратные матрицы.");
            }

            else
            {
                var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

                for (var i = 0; i < matrixA.RowsCount(); i++)
                {
                    for (var j = 0; j < matrixB.ColumnsCount(); j++)
                    {
                        matrixC[i, j] = 0;

                        for (var k = 0; k < matrixA.ColumnsCount(); k++)
                        {
                            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }

                return matrixC;
            }
        }       
    }
}
