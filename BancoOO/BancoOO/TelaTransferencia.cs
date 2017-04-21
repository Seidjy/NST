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

            Conta.Saque(Convert.ToDecimal(txtValor.Text));
            linha.Debito(Convert.ToDecimal(txtValor.Text));

            if (Conta.Id != linha.Id)//if para evitar a transação entre mesma conta
            {
                SqlTransaction sqlTransaction = dal.conexao.BeginTransaction();
                try
                {
                    dal.Alterar(Conta, sqlTransaction);
                    dal.Alterar(linha, sqlTransaction);
                    sqlTransaction.Commit();
                }
                catch (Exception)
                {
                    sqlTransaction.Rollback();
                }

                TelaConsulta.Atualizar();
                Atualizar();
                Close();
            }            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
