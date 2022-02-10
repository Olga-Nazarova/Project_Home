// Возведите число А в натуральную степень B используя цикл
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите число ");
            string sa = Console.ReadLine();
            double a = Convert.ToDouble(sa), b = 1;

            Console.Write(" В какую степень возводить? ");
            string sn = Console.ReadLine();
            int n = Convert.ToInt32(sn);

            for (int i = 0; i < n; i++) b *= a;
            Console.Write(b); Console.Read();

        }
    }
}
