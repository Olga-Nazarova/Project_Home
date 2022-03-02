// Найти сумму элементов от M до N, N и M заданы
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = CheckInputIsNumber("Введите число m: ");
            int n = CheckInputIsNumber("Введите число n: ");
            Console.WriteLine($"Сумма элементов от {m} до {n} равна - {SummRecurse(m, n)}");


            Console.WriteLine();
        }
        private static int SummRecurse(int m, int n)
        {
            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            if (m == n) return m;
            else return m + SummRecurse(m + 1, n);
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

