//Определить количество цифр в числе
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string str = Console.ReadLine();

            int x = Convert.ToInt32(str);

            int counter = 0;

            while (x > 0)
            {
                counter++;
                x = x / 10;
            }

            Console.WriteLine("Данное число содержит цифр: " + counter);
        }
    }
}
