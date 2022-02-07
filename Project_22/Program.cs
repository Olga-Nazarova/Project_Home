// Задача 22: Найти расстояние между точками в пространстве 2D/3D
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project22
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Программа рассчитывает расстояние между точками в пространстве 2D или 3D. Введите 1 для рассчёта в 2D или 2 для рассчёта в 3D");
                string mode = Console.ReadLine();
                if (mode == "1")
                {
                    PlaneMode();
                    break;
                }
                else if (mode == "2")
                {
                    AreaMode();
                    break;
                }
                else
                    Console.WriteLine("Вы ввели недопустимую операцию. Попробуйте ещё раз");
            }

        }

        private static void PlaneMode()
        {
            Console.WriteLine("Вы выбрали рассчёт в 2D. Для рассчёта программе нужны координаты x1, x2, y1, y2");

            double x1 = InputDouble("Введите x1: ");
            double x2 = InputDouble("Введите x2: ");
            double y1 = InputDouble("Введите y1: ");
            double y2 = InputDouble("Введите y2: ");

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками в 2D равно {result}");

        }

        private static void AreaMode()
        {
            Console.WriteLine("Вы выбрали рассчёт в 3D. Для рассчёта программе нужны координаты x1, x2, y1, y2, z1, z2");

            double x1 = InputDouble("Введите x1: ");
            double x2 = InputDouble("Введите x2: ");
            double y1 = InputDouble("Введите y1: ");
            double y2 = InputDouble("Введите y2: ");
            double z1 = InputDouble("Введите z1: ");
            double z2 = InputDouble("Введите z2: ");

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine($"Расстояние между двумя точками в 3D равно {result}");
        }

        private static double InputDouble(string text)
        {
            while (true)
            {
                Console.WriteLine(text);
                string input = Console.ReadLine();
                bool isDouble = double.TryParse(input, out double chDouble);

                if (isDouble)
                {
                    return chDouble;
                }
                else
                    Console.WriteLine("Вы ввели не число. Попробуйте ещё раз");
            }

        }
    }
}