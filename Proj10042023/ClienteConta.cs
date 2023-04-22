using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10042023
{
    internal class ClienteConta
    {
        public Cliente Cliente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public DateTime Data { get; set; }

    }
}
