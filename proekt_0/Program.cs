//Вывести квадрат числа
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите число от 0 до 10: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} в квадрате {1}", a, Math.Pow(a, 2));
            Console.ReadLine();

        }
    }
}
