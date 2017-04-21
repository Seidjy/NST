using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    class ContaCorrente : Conta //herança
    {  
        // override que permite fazer a sobrescrita 
        public override bool Saque(decimal valor)
        {
            valor += 0.2m;
            return base.Saque(valor);
        }
    }
}
