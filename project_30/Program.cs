// Показать кубы чисел, заканчивающихся на четную цифру
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            
            {
                Console.WriteLine("Введите положительное целое число: " + " ");
                a = int.Parse(Console.ReadLine());
                if (a < 1)
                    Console.WriteLine("Вы ввели ноль или отрицательное число. Попробуйте ещё раз " + " ");
                else break;
            }
            for (int i = 1; i <= a; i++)
                 if(i % 2 == 0) Console.WriteLine($"Куб с четным окончанием: {i} это {i*i*i}");
               
        }
    }
}

