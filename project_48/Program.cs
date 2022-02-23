//Показать двумерный массив размером m×n заполненный целыми числами
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 4;
            int n = 5;
            Random rnd = new Random();    
            int[,] array = new int[m, n];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
