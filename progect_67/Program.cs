//Показать натуральные числа от N до 1, N задано.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progect_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = CheckInputIsNumber("Введите число n: ");
            //Console.Write($"Сумма цифр числа равна: {n} ");

            //Console.WriteLine();

            NaturalRecurce(n);
            Console.WriteLine();
        }
        private static void NaturalRecurce(int n)
        {
            if (n > 1)
            {
                Console.Write($"{n}, ");
                n--;
                NaturalRecurce(n);
            }
            else
                Console.Write(n);
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
