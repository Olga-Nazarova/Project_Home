// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[123];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int number = rnd.Next(0, 124);
                array[i] = number;
            }

            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // следуя ТЗ мы должны определить количество ЭЛЕМЕНТОВ в массиве из отрезка от 10 элемента до 99
            int result = 0;
            result = 99 - 10;
            Console.WriteLine("В условиях задания сказано что массив состоит из чисел, подразумеваем по умолчанию тип int. В массиве типа int с указанным количеством элементов, даже в случае если массив не заполнен, каждый элемент равен нулю. Соответственно количество элементов в отрезке от 10 до 99 всегда будет статичным");
            Console.WriteLine($"Исходя из ТЗ, между 10 и 99 элементами массива количество элементов будет равно {result}");


            // решение если подразумеваем что нужно найти внутри массива элементы которые больше 10 и меньше 99
            int minDiapazon = 10;
            int maxDiapazon = 99;
            int elements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minDiapazon && array[i] < maxDiapazon)
                    elements += 1;
            }
            Console.WriteLine($"Если подразумевается что нужно найти внутри массива элементы, которые больше 10 и меньше 99, то их количество - {elements}");
        }
    }
}
