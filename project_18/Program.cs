//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_18
{
    internal class Program
    {

        static void Main(string[] args)
        {
            foreach (bool x in new[] { false, true })
            {
                foreach (bool y in new[] { false, true })
                {
                    if (!(x | y) == (!x & !y))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
        }
    }
}
