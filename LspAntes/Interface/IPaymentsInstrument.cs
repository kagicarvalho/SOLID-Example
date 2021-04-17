using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspAntes.Interface
{
    interface IPaymentsInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
