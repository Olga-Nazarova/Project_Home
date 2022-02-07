// Удалить вторую цифру трёхзначного числа
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите трёхзначное число: ");
                string inputStr = Console.ReadLine();
                int chNum;
                bool isNum = int.TryParse(inputStr, out chNum);
                string result = "";

                if (isNum && (chNum / 100 > 0) && (chNum / 1000 == 0))
                {
                    foreach (char c in inputStr)
                    {
                        if (c != inputStr[1])
                            result += c;
                    }
                    Console.WriteLine(inputStr.Remove(1, 1));
                    break;
                }
                else
                    Console.WriteLine("Вы ввели не трёхзначное число или ввели не число. Попробуйте ещё раз.");
            }


            Console.ReadKey();
        }
    }
}
