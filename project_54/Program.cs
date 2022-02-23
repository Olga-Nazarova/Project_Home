// В матрице чисел найти сумму элементов главной диагонали
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            FillArray(array);
            PrintArray(array);
            int summ = 0;
            for (int i = 0; i < array.GetLength(0); i ++)
            {
                for (int j = 0; j < array.GetLength(1); j ++)
                {
                    if (i == j)
                    {
                        summ += array[i,j];
                    }
                }
            }
            Console.WriteLine(summ);
            
        }
        private static void FillArray(int[,] matr)
        {
            Random rnd = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = rnd.Next(1, 100); 
                }
            }
        }
        private static void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($" {matr[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
