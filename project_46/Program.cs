// Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "2";
            double k = double.Parse(a);


            string input = "(0,0) (2,0) (2,2) (0,2)";
            string[] arrInput = input.Split(' ');

            List<double> numbers = new List<double> { };
            foreach (string i in arrInput)
            {
                string element = i;
                element = element.Replace("(", "");
                element = element.Replace(")", "");
                //Console.WriteLine(element);
                numbers.Add(double.Parse(element));
            }


            foreach (double i in numbers)
                Console.Write($"({i * k:F1}) ");

            Console.WriteLine();

        }
    }
}
