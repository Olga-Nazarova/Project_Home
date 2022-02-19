// Написать программу вывода чисел Фибоначчи
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int f1 = 1;
            int f2 = 1;
            int result;

            for (int i = 0; i < num; i++)
            {
                result = f1 + f2;
                Console.Write(result + " ");

                f1 = f2;
                f2 = result;
            }
        }
    }
}
