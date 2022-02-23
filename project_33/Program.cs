//Задать массив из 12 элементов, заполненных числами из [0,9].
//Найти сумму положительных/отрицательных элементов массива

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_33
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[12];
            int checkRandom = 0;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                checkRandom = rnd.Next(0, 2);
                if (checkRandom == 0)
                    array[i] = 0;
                else
                    array[i] = 9;
            }

            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine();
            SummArray(array);
        }        
        
        private static void SummArray(int[] array)
        {
            int summ = 0;
            foreach (int i in array)
                summ += i;
                      
            Console.WriteLine($"Сумма чисел равна {summ} ");
        }
    }
}
