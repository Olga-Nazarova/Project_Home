//Определить сколько чисел больше 0 введено с клавиатуры
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(true)
            {
                Console.WriteLine("Введите целое число, для выхода введите не число: ");
                string input = Console.ReadLine();

                bool isNum = int.TryParse(input, out int chNum);
                if (isNum && chNum > 0) count++;
                else if (isNum && chNum <= 0) continue;
                else break;
            }
            Console.WriteLine($"Вы ввели {count} чисел больше 0");

        }
    }
}
