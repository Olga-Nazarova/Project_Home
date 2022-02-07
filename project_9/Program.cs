// Показать последнюю цифру трёхзначного числа
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int num = int.Parse(Console.ReadLine());
            int c = num % 10;

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
