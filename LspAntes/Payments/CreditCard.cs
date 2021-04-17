using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspAntes.Payments
{
    class CreditCard : SantaderXCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite do cartão");
            Console.WriteLine("Limite Disponivel!");
        }
    }
}
