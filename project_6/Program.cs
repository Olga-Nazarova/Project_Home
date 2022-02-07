// Выяснить является ли число чётным
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            string str1 = Console.ReadLine();

            int i = int.Parse(str1);

            if (i % 2 == 0)
            {
                Console.WriteLine("четное");
            }

            else
            {
                Console.WriteLine("не четное");
            }

            Console.ReadKey();
        }
    }
}
