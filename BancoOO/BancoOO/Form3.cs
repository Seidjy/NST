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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stringConexao = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BancoTransaction; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            //criar a conexão com o "using" e passando a variável da string de conexão
            using (SqlConnection conexao = new SqlConnection(stringConexao))
            {
                //abrir a conexão
                conexao.Open();
                //Abrir transação na conexão
                SqlTransaction transacao = conexao.BeginTransaction();

                //Criar um comando
                SqlCommand comando = conexao.CreateCommand();
                //atribuir a trasação ao comando
                comando.Transaction = transacao;

                //Iniciar try para realização da transação
                try
                {
                    //Começo da UoW
                    //comando recebe o insert e tenta executar
                    comando.CommandText = "insert into Contas (Nome, Valor) values ('Produto excepcionalmente horrível', 1)";
                    comando.ExecuteNonQuery();

                    comando.ExecuteNonQuery();

                    //realizar o commit
                    transacao.Commit();
                    Console.WriteLine("Commit realizado com sucesso!");
                    //Fim do UoW
                }
                catch (Exception)
                {
                    //realizar o rollback
                    transacao.Rollback();
                    Console.WriteLine("Commit não realizado com sucesso, rollback executado com sucesso!");
                }

                //Ler uma tecla para realizar uma pausa no aplicativo
                Console.ReadKey();
            }
        }
    }
}
