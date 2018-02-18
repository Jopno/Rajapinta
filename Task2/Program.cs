using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransActionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String datenow = DateTime.Now.ToString("d.M.yyy");
            PaidWithCard card = new PaidWithCard();
            PaidWithCash cash = new PaidWithCash();

            card.CardTransaction(78.95F);
            Console.WriteLine(card.ShowTransaction());

            card.CardTransaction(45.65F);
            Console.WriteLine(card.ShowTransaction());
            card.CardTransaction(12.65F);
            Console.WriteLine(card.ShowTransaction());
            card.CardTransaction(423.65F);
            Console.WriteLine(card.ShowTransaction());

            Console.WriteLine("Total money to our bankaccout: " + card.TotalSales);

            cash.CashTransaction(100);
            Console.WriteLine(cash.ShowTransaction());
            cash.CashTransaction(50);
            Console.WriteLine(cash.ShowTransaction());
            cash.CashTransaction(1234);
            Console.WriteLine(cash.ShowTransaction());
            cash.CashTransaction(123);
            Console.WriteLine(cash.ShowTransaction());

            Console.WriteLine("Total money in cash: " + cash.ShowCash());

            float total = cash.TotalSales + card.TotalSales;
            Console.WriteLine("Total sales today {0} is: {1}", datenow, total);


            Console.ReadKey();

        }
    }
}
