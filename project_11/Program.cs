// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Random rnd = new Random();
                int number = rnd.Next(10, 100); 
                int a = number / 10;
                int b = number % 10;
                int Max;
                if (a > b)
                    Max = a;
                else
                    Max = b;

                Console.WriteLine($"Выбранное число из диапазона [10,99] - {number}. Наибольшая цифра этого числа: {Max}");
            }
        }
    }
}
