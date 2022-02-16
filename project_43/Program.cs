// Написать программу преобразования десятичного числа в двоичное
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = " ";
            int b;
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());


            while (num != 1)
            {
                num = num / 2;
                b = num % 2;
                result = Convert.ToString(b) + result;
            }
            result = result + num;
            int number = int.Parse(result.Replace(" ", ""));
            Console.WriteLine(number);
        }
    }
}
