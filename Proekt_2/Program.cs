// Даны два числа. Показать большее и меньшее число
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число n1");
                string inNum1 = Console.ReadLine();

                Console.WriteLine("Введите число n2");
                string inNum2 = Console.ReadLine();

                int chNum1;
                int chNum2;

                bool isNum1 = int.TryParse(inNum1, out chNum1);
                bool isNum2 = int.TryParse(inNum2, out chNum2);

                if (isNum1 && isNum2)
                {
                    if (chNum1 == chNum2)
                    {
                        Console.WriteLine("равны");
                    }
                    else if (chNum1 < chNum2)
                    {
                        Console.WriteLine($"Число n2: {chNum2} больше чем число n1: {chNum1}");
                    }
                    else
                    {
                        Console.WriteLine($"Число n1: {chNum1} больше чем число n2: {chNum2}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nВы ввели не целое число. Повторите ввод.");
                }
            }
        }
    }
}
