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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            Conta conta = new Conta();

            conta.Agencia = txtAgencia.Text;
            conta.Numero = txtNumero.Text;

            if (rbCorrente.Checked)
            {
                conta.Tipo = "C";
            }
            else if (rbPoupanca.Checked)
            {
                conta.Tipo = "P";
            }

            dal.Inserir(conta);
        }
    }
}
