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
    public partial class TelaConsulta : Form
    {

        public List<Conta> Contas { get; set; }

        public TelaConsulta()
        {
            Contas = new List<Conta>();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var stringConexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conexao = new SqlConnection(stringConexao);

            conexao.Open();

            SqlCommand comando = new SqlCommand("Select * from Contas", conexao);
            SqlDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {

                Conta conta = new Conta();

                conta.Id = Convert.ToInt32(reader["Id"]);
                conta.Numero = Convert.ToString(reader["Numero"]);
                conta.Agencia = Convert.ToString(reader["Agencia"]);
                conta.Tipo = Convert.ToString(reader["Tipo"]);
                conta.Saldo = Convert.ToDecimal(reader["Saldo"]);

                Contas.Add(conta);

            }

            dataGridView1.DataSource = Contas;
            conexao.Close();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Conta linha = dataGridView1.SelectedRows[0].DataBoundItem as Conta;
            //Criar um novo form para editar e atualiza-lo no BD

            TelaAlterar form2 = new TelaAlterar(linha);
            form2.Show();
            

        }
    }
}
