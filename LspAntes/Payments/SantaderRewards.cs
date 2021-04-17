using LspAntes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspAntes.Payments
{
    class SantaderRewards : IPaymentsInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento Realizado com sucesso!");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite Disponivel, Rewards Lançado!");
        }
    }
}
