// Написать программу возведения числа А в целую стень B
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите число ");
            string sa = Console.ReadLine();
            int a = Convert.ToInt32(sa);

            Console.WriteLine(" В какую степень возводить? ");
            string sn = Console.ReadLine();
            int n = Convert.ToInt32(sn);

            Console.Write($" Число {a} в степени {n} равно: {Pow(a,n)} ");
            Console.WriteLine();
        }

        static int Pow(int number, int power)
        {
            if (power == 1)
                return number;
            return number * Pow(number, --power);
        }
    }
}
