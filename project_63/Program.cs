// Сформировать трехмерный массив неповторяющимися двузначными числами, показать его построчно на экран,
// выводя индексы соответствующего элемента.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = CheckInputIsNumber("Введите число n: "); //Row
            int col = CheckInputIsNumber("Введите число k: "); // Col
            int elem = CheckInputIsNumber("Введите число m: "); // Elem
            int[,,] array = new int[row, col, elem];

            FillArrayTrheeX(array);                                          
        }

        private static void PrintArrayThreeX(int[,,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    for (int elem = 0; elem < array.GetLength(2); elem++)
                    {
                        Console.Write(" | ");
                        Console.Write($"{array[row, col, elem]} {" | "} [{row}, {col}, {elem}]");                                                                       
                    }
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void FillArrayTrheeX(int[,,] arrayTrheeX)
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>();

            for (int i = -99; i < 100; i++)
                if (i < -9 || i > 9)
                    numbers.Add(i);

            if (arrayTrheeX.GetLength(0) * arrayTrheeX.GetLength(1) * arrayTrheeX.GetLength(2) > numbers.Count)
                Console.WriteLine("Невозможно создать массив двузначных чисел, недостаточно элементов");
            else
            {
                for (int row = 0; row < arrayTrheeX.GetLength(0); row++)
                {
                    for (int col = 0; col < arrayTrheeX.GetLength(1); col++)
                    {
                        for (int elem = 0; elem < arrayTrheeX.GetLength(2); elem++)
                        {
                            int randomNumber = rnd.Next(0, numbers.Count() - 1);
                            arrayTrheeX[row, col, elem] = numbers[randomNumber];
                            numbers.Remove(numbers[randomNumber]);
                        }
                    }
                }
                PrintArrayThreeX(arrayTrheeX);
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
