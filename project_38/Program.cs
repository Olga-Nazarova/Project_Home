//Найти сумму чисел одномерного массива стоящих на нечетной позиции
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            Random rnd = new Random();
            int nechet = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int number = rnd.Next(100, 121);
                array[i] = number;
            }
            foreach (int i in array)
                Console.Write($"{i} ");

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    nechet += array[i];
            }
            Console.WriteLine($"Cумма чисел на нечетных позициях равна: {nechet}");
        }
    }
}
