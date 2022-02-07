// Показать четные числа от 1 до N
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine("Write number: ");
            int m = int.Parse(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
