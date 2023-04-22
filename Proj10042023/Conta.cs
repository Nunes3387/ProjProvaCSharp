using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10042023
{
    internal class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoMoeda TipoMoeda { get; set; }
        public decimal Saldo { get; set; }
        public TipoConta TipoConta { get; set; }


        public override string ToString()
        {
            return base.ToString() +
                                     "\nId Conta: " + Id +
                                     "\nTipoMoeda da Conta: " + TipoMoeda +
                                     "\nSaldo da Conta: " + Saldo +
                                     "\nTipo da Conta: " + TipoConta +
                                     "\nDescricao da conta: " + Descricao +
                                     "\n______________________________\n";
        }
    }
}
