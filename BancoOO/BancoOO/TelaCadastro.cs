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
            if ((txtAgencia.Text != "") &&(txtNumero.Text != "") )
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
                TelaConsulta telaConsulta = new TelaConsulta();
                telaConsulta.Show();
                Close();
            }
            else
            {
                label1.Text = "Digite um valor para agência e número!";
            }
            
        }
    }
}
