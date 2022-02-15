// Написать программу замену элементов массива на противоположные

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[12];
            int[] arrayNumbers = new int[] { 1, 12, 3, 4, 11, 9, 5, 7, 6, 10, 8, 2 };
            PrintArray(arrayNumbers);
            ChangeArray(arrayNumbers);
            Console.WriteLine();

            PrintArray(arrayNumbers);
            Console.ReadKey();
        }
        private static void PrintArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        private static void ChangeArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                array[i] = array[i] * -1;
        }
    }
}
