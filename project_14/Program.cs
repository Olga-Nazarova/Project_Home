// Найти третью цифру числа или сообщить, что её нет
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inNum = InputNumber();

            string str = inNum.ToString();
            try
            {
                Console.WriteLine(str[2]);
            }
            catch
            {
                Console.WriteLine($"Третьей цифры нет. Число {str.Length}-значное.");
            }

        }

        private static int InputNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string inputStr = Console.ReadLine();

                bool isNum = int.TryParse(inputStr, out int chNum);

                if (!isNum)
                    Console.WriteLine("Вы ввели не число. Попробуйте ещё раз");
                else return chNum;
            }
        }
    }
}
        
    

