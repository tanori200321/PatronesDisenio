using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoPayPal : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pagando con PayPal (Email:prueba@gmail.com)");
        }
    }
}
