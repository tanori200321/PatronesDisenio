using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoApplePay : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pagando con Apple Pay (Nombre Apellido)");
        }
    }
}
