using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const decimal usdltorub = 64.3675m;
            const decimal rubltousd = 0.01552m;

            Currency rubl = new Currency(100000, "Рубль");
            Currency usd = new Currency(100000, "Доллар");
            Currency eur = new Currency(100000, "Евро");



            var draw = 1000m;
            if (rubl.Withdraw(draw))
            {
                usd.Add(draw, rubltousd);
                Console.WriteLine(rubl);
                Console.WriteLine(usd);
            }
            else
                Console.WriteLine("Не хватает средства для данной операции");
        }
    }

    public class Currency
    {
        public decimal Balance { private set; get; }
        public string Name { private set; get; }

        public Currency(decimal balance, string name)
        {
            Balance = balance;
            Name = name;
        }

        public void Add(decimal money)
        {
            Balance += money;
        }


        public void Add(decimal money, decimal kurs)
        {
            Balance += Decimal.Multiply(money, kurs);
        }

        public bool Withdraw(decimal money)
        {
            if (Balance - money < 0) return false;
            Balance -= money;
            return true;
        }

        public bool Withdraw(decimal money, decimal kurs)
        {
            if (Balance - Decimal.Multiply(money, kurs) < 0) return false;
            Balance -= Decimal.Multiply(money, kurs);
            return true;
        }

        public override string ToString()
        {
            return String.Format("Валюта - {0}; Текущий баланс = {1}", Name, Balance);
        }
    }
}
    

