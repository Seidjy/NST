using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoOO
{
    public partial class TelaAlterar : Form
    {
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaAlterar(TelaConsulta telaConsulta)
        {
            TelaConsulta = telaConsulta;
            InitializeComponent();
        }

        public TelaAlterar(Conta conta, TelaConsulta telaConsulta)
        {
            TelaConsulta = telaConsulta;
            Conta = conta;
            InitializeComponent();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            textBox1.Text = Conta.Agencia.ToString();

            if(Convert.ToChar(Conta.Tipo) == 'C' )
            {
                radioButton1.Select();
            }
            else
            {
                radioButton2.Select();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();

            Conta.Agencia = Convert.ToString(textBox1.Text);

            if (radioButton1.Checked)
            {
                Conta.Tipo = "C";
            }
            else
            {
                Conta.Tipo = "P";
            }

            dal.Alterar(Conta);            
            TelaConsulta.Atualizar();
        }
    }
}
