using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inDay = InputDayWeek();

            switch (inDay)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Это будний день");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Это выходной день");
                    break;
            }
        }

        private static int InputDayWeek()
        {
            while (true)
            {
                Console.WriteLine("Введите день недели в формате от 1 до 7: ");
                string inputStr = Console.ReadLine();

                bool isNum = int.TryParse(inputStr, out int chNum);
                if (isNum && chNum > 0 && chNum < 8)
                    return chNum;
                else Console.WriteLine("Вы ввели недопустимое число. Попробуйте ещё раз");
            }
        }
    }
}
