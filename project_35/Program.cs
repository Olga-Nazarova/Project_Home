// Определить, присутствует ли в заданном массиве, некоторое число

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());

            int [] array = new int[20];
            bool result = true;
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int number = rnd.Next(100, 121);
                array[i] = number;
            }
            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine();

            foreach (int i in array)
                if (n == i)
                {
                    Console.WriteLine($"Число {n} присутствует в массиве");
                    result = true;
                    break;
                }
                    
                else result = false;

            if(!result)
                Console.WriteLine($"Числа {n} нет в массиве");
        }

    }
}
