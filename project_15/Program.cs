// Дано число. Проверить кратно ли оно 7 и 23
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxCount = 200;
            for (int i = 1; i < maxCount; i++)
            {
                if (i % 7 == 0 && i % 23 == 0)
                    Console.WriteLine($"Число {i} кратно 7 и 23");
            }
        }
    }
}
