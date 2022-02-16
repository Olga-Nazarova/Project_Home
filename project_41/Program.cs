// Выяснить являются ли три числа сторонами треугольника

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value1 = rnd.Next(1, 100);
            Console.WriteLine(value1);

            int value2 = rnd.Next(1, 100);
            Console.WriteLine(value2);

            int value3 = rnd.Next(1, 100);
            Console.WriteLine(value3);

            if ((value1 + value2 > value3) && (value2 + value3 > value1) && (value1 + value3 > value2))
            {
                double p = (value1 + value2 + value3) / 2;
                Console.WriteLine("Это треугольник");
            }
            else
            
                Console.WriteLine("Это не треугольник");
            
            Console.ReadKey();
        }
    }
}
