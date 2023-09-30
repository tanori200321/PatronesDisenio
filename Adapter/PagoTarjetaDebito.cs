using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoTarjetaDebito : IPago
    {
        private readonly string _numTarjeta;
        public PagoTarjetaDebito(string numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando con tarjeta de debito terminación {_numTarjeta}");
        }
    }
}
