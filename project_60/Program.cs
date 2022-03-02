// Составить частотный словарь элементов двумерного массива
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();

            char[] diction = { ' ', ',', '.', ':', ';', '!', '?' };
            string[] massiv = str.Split(diction, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (string symbol in massiv)
            {
                if (dictionary.ContainsKey(symbol))
                    ++dictionary[symbol];
                else
                    dictionary[symbol] = 1;
            }

            foreach (KeyValuePair<string, int> pair in dictionary)
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }
}
