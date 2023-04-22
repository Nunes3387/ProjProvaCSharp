using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10042023
{
    internal class TipoConta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Bonus { get; set; }


        public override string ToString()
        {
            return base.ToString() +
                                     "\nId Tipo da conta: " + Id +
                                     "\nId Bonus: " + Bonus +
                                     "\nDescricao do tipo da conta: " + Descricao +
                                     "\n______________________________\n";
        }
    }
}
