#region Описание задачи
// Написать программу вычисления значения функции y = f(a)
// Предположим что функция это y = 2x − 1
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число a");
                string a = Console.ReadLine();
                int chNum;
                int y;
                bool isNum = int.TryParse(a, out chNum);

                if (isNum)
                {
                    y = 2 * chNum - 1;
                    Console.WriteLine($"Результатом функции y = f(a), при условии что функция 2x - 1 и a равен {chNum}, будет: {y}");
                    break;
                }
                else Console.WriteLine("Вы ввели не целое число или это не число, попробуйте снова");
            }
        }
    }
}
