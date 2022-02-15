// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[rnd.Next(1, 100)];

            for (int i = 0; i < array.Length; i++)
            {
                int number = rnd.Next(-100, 100);
                array[i] = number;
            }


            foreach (int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();

            int indexStart = 0;
            int indexFin = array.Length - 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (indexStart <= indexFin)
                {
                    Console.WriteLine($"Умножаем элемент {array[indexStart]} на элемент {array[indexFin]} и получаем {array[indexStart] * array[indexFin]}");
                    indexStart += 1;
                    indexFin -= 1;
                }

            }
        }
    }
}
