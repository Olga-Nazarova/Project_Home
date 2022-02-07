// Показать вторую цифру трёхзначного числа
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число ");
                string numStr = Console.ReadLine();

                bool isNum = int.TryParse(numStr, out int chNum);

                if (isNum && (chNum / 100 > 0) && (chNum / 1000 == 0))
                    Console.WriteLine(numStr[1]);
                else
                    Console.WriteLine("Некорректное число. Повторите ввод");

            }
        }
    }
}
