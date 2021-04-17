using DipBefore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipBefore.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            SQLServerProduct product = new SQLServerProduct();
            var productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
