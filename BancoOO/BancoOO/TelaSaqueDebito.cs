using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoOO
{
    public partial class TelaSaqueDebito : Form
    {
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaSaqueDebito()
        {
            InitializeComponent();
        }

        public TelaSaqueDebito(Conta conta, TelaConsulta telaConsulta)
        {
            Conta = conta;
            TelaConsulta = telaConsulta;
            InitializeComponent();
        }

               private void TelaSaqueDebito_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            Conta conta = new Conta();
         
            if (rbDebito.Checked)
            {
               Conta.Debito (Convert.ToDecimal(txtValor.Text));
            }
            else if (rbSaque.Checked)
            {
                Conta.Saque(Convert.ToDecimal(txtValor.Text));
            }


            dal.Alterar(conta);
        
    }

        private void TelaSaqueDebito_Load_1(object sender, EventArgs e)
        {

        }

      }
}
