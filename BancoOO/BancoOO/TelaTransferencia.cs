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
    public partial class TelaTransferencia : Form
    {
        DAL dal = new DAL();
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaTransferencia()
        {
            InitializeComponent();
        }

        /* Construtor recebendo a conta e a tela de consulta
         * irá instânciar Conta de acordo com o tipo da conta recebida
         * após atribuirá os valores da conta recebida para a Conta
         * TelaConsulta será utilizada para atualizar a tela de consulta após o fim das ações
         */
        public TelaTransferencia(Conta conta, TelaConsulta telaConsulta)
        {
            Conta = conta;
            if (conta.Tipo == "C")
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
            this.Atualizar();
        }

        private void TelaTransferencia_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();

        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          //  Conta linha = dataGridView1.SelectedRows[0].DataBoundItem as Conta;
        }
        public void Atualizar()
        {
            dataGridView1.DataSource = dal.GetAll();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
                Conta linha = dataGridView1.SelectedRows[0].DataBoundItem as Conta;
                bool ok;


                if (txtValor.Text.Equals(""))//if para não permitir valor nulo
                {
                    label3.Text = "Coloque valor para a transferência!";
                }
                else
                {
                    if (Conta.Saque(Convert.ToDecimal(txtValor.Text)))
                    {
                        linha.Credito(Convert.ToDecimal(txtValor.Text));
                        if (Conta.Id != linha.Id)//if para evitar a transação entre mesma conta
                        {
                            dal.Transacao(Conta, linha);
                            ok = true;
                        }
                        else
                        {
                            label3.Text = "Não permitido transferir para mesma conta!";
                            ok = false;
                        }
                    }
                    else
                    {
                        label3.Text = "Saldo Insuficiente, lembre-se que o saque retira a taxa mais o valor!";
                        ok = false;
                    }//Conta recebe a conta do datagrid da Tela Consulta
                     //linha recebe a conta do datagrid desta tela(TelaTransferencia)
                    if (ok)
                    {
                        TelaConsulta.Atualizar();
                        Atualizar();
                        Close();
                    }
                }

        }

    }
}
