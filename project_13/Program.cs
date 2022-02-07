// Выяснить, кратно ли число заданному, если нет, вывести остаток.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number1 = 45;
            int Number2 = 7;
            if (Number2 % Number1 == 0)
            {
                Console.WriteLine("Число кратно " + Number1);
            }
            else Console.WriteLine("Остаток от деления " + Number2 % Number1);

        }
    }
}
