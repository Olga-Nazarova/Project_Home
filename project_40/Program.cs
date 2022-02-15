// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[12];
            Random rand = new Random();

            double min = 1;
            double max = 0;


            for (int i = 0; i < array.Length; i++)  
            {
                double a = Math.Round(rand.NextDouble(), 2);
                array[i] = a;                 
            }
            foreach (double i in array)
                Console.Write($"{i} ");
            Console.WriteLine();

            foreach (double i in array)
            {
                if (min >= i)
                    min = i;
                if (max <= i)
                    max = i;               
            }
            double result = max - min;
            Console.WriteLine($"Максимальное число: {max} минимальное число: {min}. Разница между максимальным и минимальным числом: {result}");
            
        }
    }
}
