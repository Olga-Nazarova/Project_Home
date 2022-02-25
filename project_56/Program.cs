// Написать программу, которая обменивает элементы первой строки и последней строки
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_56
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

            EnumerationArray(array);
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

        private static void EnumerationArray(int[,] array)
        {           
            for (int i = 0; i < array.GetLength(1); i++)
            {
                int temp = 0;
                temp = array[array.GetLength(0) - 1, i];
                array[array.GetLength(0) - 1, i] = array[0, i];
                array[0, i] = temp;
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

