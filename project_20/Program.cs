//Задача 20: Задать номер четверти, показать диапазоны для возможных координат

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project20
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode = InputNumber();

            if (mode == 1)
                Console.WriteLine($"В первой координатной четверти может быть диапазон от x0,y0 до x(inf), y(inf)");
            if (mode == 2)
                Console.WriteLine("Во второй координатной четверти может быть диапазон от x0,y0 до -x(inf), y(inf)");
            if (mode == 3)
                Console.WriteLine("В третьей координатной четверти может быть диапазон от x0,y0 до -x(inf), -y(inf)");
            if (mode == 4)
                Console.WriteLine("В четвертой координатной четверти может быть диапазон от x0,y0 до x(inf), -y(inf)");
        }

        private static int InputNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите номер координатной четверти (1, 2, 3 или 4): ");
                string inputStr = Console.ReadLine();

                bool isNum = int.TryParse(inputStr, out int chNum);

                if (!isNum && chNum < 1 && chNum > 4)
                    Console.WriteLine("Вы ввели некорректную команду. Попробуйте ещё раз");
                else return chNum;
            }
        }
    }
}