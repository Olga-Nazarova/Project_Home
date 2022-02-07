// Является ли пятизначное число полиндромом
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50005; //new Random().Next(10000, 99999);
            Console.WriteLine(a);

            if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10)
            {
                Console.WriteLine("Число палиндром");
            }
            else Console.WriteLine("Число не палиндром или Вы ввели не пятизначное число");

        }
    }
}
