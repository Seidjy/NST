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
            valor += 0.2m;
         //   valor += 22;
            return base.Saque(valor);
        }
    }
}
