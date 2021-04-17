using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipBefore.Model
{
    class SQLServerProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}";
        }
    }
}
