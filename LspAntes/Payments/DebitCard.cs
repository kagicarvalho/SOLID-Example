using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspAntes.Payments
{
    class DebitCard : SantaderXCard
    {

        public override void Validate()
        {
            Console.WriteLine("Verificando saldo da conta");
            Console.WriteLine("Saldo Disponivel!");
        }
    }
}
