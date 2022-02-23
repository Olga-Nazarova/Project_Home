//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int m = rnd.Next(1, 5);
            int n = rnd.Next(1, 5);
            int[,] array = new int[m, n];

            FillArray(array);
            
            int a = CheckInputIsNumber("Введите число: ");

            PrintArray(array);
            SearchNumber(array, a);
            
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]} ");
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

        private static void FillArrayMN(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                }
            }
        }

        private static void SearchNumber(int[,] array, int number)
        {
            bool result = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == number)
                    {
                        Console.WriteLine($"Число {number} есть в массиве на позиции: строка {i}, индекс {j}");
                        result = true;
                    }
                                                                 
                }
            }
            if(!result)
                Console.WriteLine($"Числа {number} нет в массиве");
        }

        private static void ChangeArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j += 2)
                {
                    array[i, j] *= -1;
                }
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
