using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    class ContaPoupanca : Conta
    { //// override que permite fazer a sobrescrita sobrecarga m
        public override bool Saque(decimal valor) //sobrescrita substituir o metodo.
        {
            if (valor > 1000)
            {
                return false;
            }
            else
                valor += 0.10m;
          return base.Saque(valor);
        }
    }
}
