//По двум заданным числам проверять является ли одно квадратом другого
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 * n1 == n)
                Console.WriteLine($"Число - {n} является квадратом {n1}");
            else Console.WriteLine($"Число - {n} не является квадратом {n1}");
        
        }
    }
}
