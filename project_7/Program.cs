// Показать числа от -N до N
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            int N = int.Parse(Console.ReadLine());

            int i = -N;

            while (i <= N)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

        }
    }
}
