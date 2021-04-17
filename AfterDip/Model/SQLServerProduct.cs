using AfterDip.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterDip.Model
{
    class SQLServerProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}";
        }
    }
}
