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
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaCadastro()
        {
            InitializeComponent();
        }

        public TelaCadastro(Conta conta, TelaConsulta telaConsulta)
        {
            Conta = conta;
            TelaConsulta = telaConsulta;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            Conta conta = new Conta();
            
            if (rbCorrente.Checked)
            {
                conta.Tipo = "C";
            }
            else if (rbPoupanca.Checked)
            {
                conta.Tipo = "P";                
            }

            conta.Agencia = txtAgencia.Text;
            conta.Numero = txtNumero.Text;

            dal.Inserir(conta);
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
