using AfterDip.Factory;
using AfterDip.Interface;
using AfterDip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterDip.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            IDbProduct product = DbProductFactory.Create();
            var productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
