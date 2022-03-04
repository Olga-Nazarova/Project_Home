// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alf = "аисв";
            int n = 1;
            string[] res = Worlds(alf, n);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
        string [] Worlds(string a, int num)
        {
            if (num == 0)
            {
                return new string[] { "" };

            }
            string[] w = Worlds(a, num - 1);
            string[] result = new string[w.Length * 4];
            int k = 0;
            for (int i = 0; i < w.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    result[k] = w[i] + a[j];
                    k++;
                }
            }
            return result;
           
        }
        

}
}
