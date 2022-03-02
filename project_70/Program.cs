//Найти сумму цифр числа
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = CheckInputIsNumber("Введите число n: ");
            Console.Write($"Сумма цифр числа равна: {Summ(num)} ");

            Console.WriteLine();
        }

        static int Summ(int num)
        {
            if (num < 10) return num;
            else return num % 10 + Summ(num / 10);
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
