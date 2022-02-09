//Найти сумму чисел от 1 до А

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                a = InputNumber();

                if (a < 1)
                    Console.WriteLine("Вы ввели ноль или отрицательное число. Попробуйте ещё раз");
                else break;
            }


            int summ = 0;
            for (int i = 1; i <= a; i++)
            {
                summ += i;
            }

            Console.WriteLine($"Сумма чисел от 1 до {a} будет равна {summ}");
        }

        private static int InputNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string inputStr = Console.ReadLine();

                bool isNum = int.TryParse(inputStr, out int chNum);

                if (!isNum)
                    Console.WriteLine("Вы ввели не число. Попробуйте ещё раз");
                else return chNum;
            }
        }
    }
}