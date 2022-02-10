// Задать массив из 8 элементов и вывести их на экран
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Random rand1 = new Random();

            for (int a = 0; a < array.Length; a++)
            {
                array[a] = rand1.Next(1, 7);
                Console.Write(array[a] + " ");

            }
            Console.WriteLine();

        }
    }
}
