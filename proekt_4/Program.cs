// Найти максимальное из трех чисел
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите число 2");
            string str2 = Console.ReadLine();

            Console.WriteLine("Введите число 3");
            string str3 = Console.ReadLine();

            int n1 = int.Parse(str1);
            int n2 = int.Parse(str2);
            int n3 = int.Parse(str3);

            if (n1 >= n2 && n1 >= n3)
                Console.WriteLine(n1);

            else if (n2 >= n1 && n2 >= n3)
                Console.WriteLine(n2);

            else
                Console.WriteLine(n3);
        }
    }
}
