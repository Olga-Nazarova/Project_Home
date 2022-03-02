// В прямоугольной матрице найти строку с наименьшей суммой элементов.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = CheckInputIsNumber("Введите число n: ");
            int k = CheckInputIsNumber("Введите число k: ");
            int[,] array = new int[n, k];

            if (n != k)
            {
                FillArray(array);
                PrintArray(array);
                MinStrArray(array);
            }
            else
                Console.WriteLine("Вы используете не прямоугольную матрицу");
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

        private static void MinStrArray(int[,] array)
        {
            int minRowSum = int.MaxValue;
            int indexMinRow = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)               
                    sum += array[i, j];                                  
                if (sum < minRowSum)
                {
                    minRowSum = sum;
                    indexMinRow = i;
                }
            }           
            Console.Write($"Строка с минимальной суммой элементов - {indexMinRow}, ее значения: ");
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[indexMinRow, j] + " ");
            Console.WriteLine();
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
    

