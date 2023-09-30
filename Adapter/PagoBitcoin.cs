using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoBitcoin : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pagando con Bitcoin Num Cartera 1234");
        }
    }
}
