// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 8;
            int[] array = new int[count];

            Random rnd = new Random(); 

            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(0, 2);
            }
            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine();
            Console.WriteLine($"Длина массива array = {array.Length}" );
        }
    }
}
