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
    public partial class TelaSaqueCredito : Form
    {
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaSaqueCredito()
        {
            InitializeComponent();
        }

        public TelaSaqueCredito(Conta conta, TelaConsulta telaConsulta) //poli vai herdar da superclasse e ter comportamento diferente.
        {
            Conta = conta;
            if(conta.Tipo =="C")
            {
                Conta = new ContaCorrente();

            }
            else if (conta.Tipo == "P")
            {
                Conta = new ContaPoupanca();
            }

            Conta.Id = conta.Id;
            Conta.Tipo = conta.Tipo;
            Conta.Saldo = conta.Saldo;
            Conta.Numero = conta.Numero;
            Conta.Agencia = conta.Agencia; 

            TelaConsulta = telaConsulta;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DAL dal = new DAL();
                bool ok = false;

                if (rbDebito.Checked)
                {
                    Conta.Credito(Convert.ToDecimal(textBox1.Text));
                    ok = true;
                }
                else if (rbSaque.Checked)
                {
                    ok = Conta.Saque(Convert.ToDecimal(textBox1.Text));
                }
                if (ok)
                {
                    dal.Alterar(Conta);
                    TelaConsulta.Atualizar();//atualiza a tela de consulta.
                    this.Close();
                }
                else
                {
                    label3.Text = "Saldo Insuficiente!";
                }
                
            }
            else
            {
                label3.Text = "Digite algum valor";
            }

        }

        private void TelaSaqueCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
