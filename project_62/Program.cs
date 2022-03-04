// В двумерном массиве целых чисел
// удалить строку и столбец, на пересечении которых расположен наименьший элемент.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = CheckInputIsNumber("Задайте количество строк матрицы n: ");// row
            int k = CheckInputIsNumber("Задайте количество столбцов матрицы k: ");  //col
            int[,] array = new int[n, k];

            FillArray(array);
            PrintArray(array);

            (int minString, int minColum) = FillArrayRowCol(array, n, k);
            Console.WriteLine($"{minString} - минимальная строка, {minColum} - минимальный столбец");


            Console.WriteLine("Так как массив является ссылочным типом и находится в куче, что-либо удалить из него или добавить - невозможно. Но можно перезаписать новым массивом. Предыдущий массив будет храниться в памяти, пока не будет запущена автоматическая процедура сборщика мусора, но на программу это не повлияет: ");
            array = DeleteRow(array, minString);
            array = DeleteCol(array, minColum);

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
        private static (int, int) FillArrayRowCol(int[,] array, int minRow, int minCol)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                }
            }
            return (minRow, minCol);
        }

        private static int[,] DeleteRow(int[,] array, int row)
        {
            int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
            int num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == row)
                {
                    row = -1;
                    continue;
                }

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result[num, j] = array[i, j];
                }
                num++;
            }
            return result;
        }

        private static int[,] DeleteCol(int[,] array, int col)
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1) - 1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int num = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == col) continue;
                    result[i, num] = array[i, j];
                    num++;
                }
            }
            return result;
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

