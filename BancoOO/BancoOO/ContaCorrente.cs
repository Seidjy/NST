using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    class ContaCorrente : Conta
    {
        public override bool Saque(decimal valor)
        {

            return base.Saque(valor);
        }

    }
}
