//Показать таблицу квадратов чисел от 1 до N
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел для вывода:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Число" + "\t" + "Квадрат");
            for (int i = 1; i <= N; i++)
                Console.WriteLine(i + "\t" + i * i);

            Console.ReadLine();
        }
    }
}
