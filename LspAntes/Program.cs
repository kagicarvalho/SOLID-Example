using LspAntes.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspAntes
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();

            SantaderRewards card = new SantaderRewards();
            card.Validate();
            card.CollectPayment();
            Console.ReadLine();
        }
    }
}
