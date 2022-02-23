// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_52
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
            for (int i = 0; i < array.GetLength(0); i+=2)
            {
                for (int j = 0; j < array.GetLength(1); j+=2)
                {
                    array[i, j] = array[i, j] * array[i, j];
                }
            }
            Console.WriteLine();
            PrintArray(array);
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
    }
}
