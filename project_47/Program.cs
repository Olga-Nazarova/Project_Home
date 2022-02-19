//Написать программу копирования массива
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void FillArray(int[] arrays)
            {
                for (int i = 0; i < arrays.Length; i++)
                    arrays[i] = new Random().Next(100, 1000);
            }
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "   ");
                }
                Console.WriteLine();
            }
            void CopyArray(int[] arr, int[] arrays)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arrays[i] = arr[i];
                }
                Console.WriteLine();
            }
            int[] array = new int[8];
            int[] newArray = new int[array.Length];
            FillArray(array);
            PrintArray(array);
            CopyArray(array, newArray);
            PrintArray(newArray);
        }
    }
}
