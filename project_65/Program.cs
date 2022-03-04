//Спирально заполнить двумерный массив:
// пример
//1  2  3  4
//12 13 14  5
//11 16 15  6
//10  9  8  7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = CheckInputIsNumber("Введите количество строк для создания матрицы n: ");// row
            int k = CheckInputIsNumber("Введите количество столбцов для создания матрицы k: ");// col
            int[,] array = new int[n, k];

            SnakeFill(n, k, array);                     
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

        private static void SnakeFill(int endRow, int endCol, int[,] array)
        {
            int value = 1;
            int startRow = 0;
            int startCol = 0;

            while (startRow < endRow && startCol < endCol)
            {
                for (int i = startCol; i < endCol; ++i)
                    array[startRow, i] = value++;

                startRow++;

                for (int i = startRow; i < endRow; ++i)
                    array[i, endCol - 1] = value++;

                endCol--;

                if (startRow < endRow)
                {
                    for (int i = endCol - 1; i >= startCol; --i)
                        array[endRow - 1, i] = value++;
                }

                endRow--;

                if (startCol < endCol)
                {
                    for (int i = endRow - 1; i >= startRow; --i)
                        array[i, startCol] = value++;
                }

                startCol++;
            }
            PrintArray(array);
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
