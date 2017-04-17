using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    class ContaPoupanca : Conta
    {
        public override bool Saque(decimal valor)
        {
            if(valor > 1000)
            {
                return false;
            }else

          return base.Saque((valor + 0.10m));
       //     return base.Saque((valor + 11));
        }
    }
}
