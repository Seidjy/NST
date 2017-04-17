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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaSaqueDebito_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            bool ok = false; 

            if (rbDebito.Checked)
            {
                Conta.Debito(Convert.ToDecimal(textBox1.Text));
                ok = true;
            }
            else if (rbSaque.Checked)
            {
                ok = Conta.Saque(Convert.ToDecimal(textBox1.Text));
            }
            if (ok)
            {
                dal.Alterar(Conta);
                TelaConsulta.Atualizar();
            }
        }
    }
}
