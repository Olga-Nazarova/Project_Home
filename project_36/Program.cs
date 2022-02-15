//Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных и четных чисел
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_36
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int[] array = new int[20];
            Random rnd = new Random();
            int chet = 0;
            int nechet = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int number = rnd.Next(100, 121);
                array[i] = number;
            }
            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine();

            foreach (int i in array)
                if (i % 2 == 0)
                    chet += 1;
                else nechet += 1;
            Console.WriteLine($"Количество четных чисел равно: {chet} \nКоличество нечетных чисел равно: {nechet}");
        }
    }
}
