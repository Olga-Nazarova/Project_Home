// Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = CheckInputIsNumber("Введите число n: ");
            int k = CheckInputIsNumber("Введите число k: ");
            int[,] array = new int[n, k];

            FillArray(array);
            PrintArray(array);


            SortArray(array);
            PrintArray(array);
        }

        private static void PrintArray(int[,] array)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                    Console.Write($"{array[y, x]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void FillArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
        }

        private static void SortArray(int[,] array)
        {
            int[] temp = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    temp[j] = array[i, j];
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int k = 0; k < array.GetLength(1); k++)
                    array[i, k] = temp[k];
            }
        }

        private static int CheckInputIsNumber(string text)
        {
            int number;
            Console.WriteLine(text);
            string input = Console.ReadLine();
            bool isNum = int.TryParse(input, out number);

            while (!isNum)
            {
                Console.WriteLine("Вы ввели не целое число! Попробуйте ещё раз: ");
                input = Console.ReadLine();
                isNum = int.TryParse(input, out number);
            }

            return number;
        }
    }
}

