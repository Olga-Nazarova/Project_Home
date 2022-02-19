//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  k1 ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  b1 ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  k2 ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  b2 ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            if (k1 == k2)
                Console.WriteLine("Нет точек пересечения");
            else
            Console.WriteLine($"Координаты точки пересечения X0 = {(b2 - b1) / (k1 - k2)}, Y0 ={k1 * (b2 - b1) / (k1 - k2) + b1}");

            
        }
    }
}
