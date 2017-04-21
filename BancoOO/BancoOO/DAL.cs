using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoOO
{
    class DAL
    {
        public SqlConnection conexao { get; set; }

        public DAL()//construtor inicia conexão e abre ela
        {
            //Seidjy
            var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //Tamara
            //var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Conta;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            conexao = new SqlConnection(caminho);
            conexao.Open();

        }

        public Conta Buscar(Conta conta)
        {
            var sql = "select * from Contas where Id = @id";
            SqlCommand SqlCommand = new SqlCommand(sql, conexao);
            SqlCommand.Parameters.AddWithValue("@Id", conta.Id);

            SqlDataReader reader = SqlCommand.ExecuteReader();
            //conta = null;
            while (reader.Read())
            {
                conta = new Conta();
                conta.Id = Convert.ToInt32(reader["id"]);
                conta.Numero = reader["Numero"].ToString();
                conta.Agencia = reader["Agencia"].ToString();
                conta.Saldo = Convert.ToDecimal(reader["Saldo"]);
                conta.Tipo = reader["Tipo"].ToString();
            }

            return conta;
        }

        public List<Conta> GetAll()
        {
            var sql = "select * from Contas";
            SqlCommand SqlCommand = new SqlCommand(sql, conexao);

            SqlDataReader reader = SqlCommand.ExecuteReader();
            Conta conta = null;
            List<Conta> listContas = new List<Conta>();
            while (reader.Read())
            {
                conta = new Conta();
                conta.Id = Convert.ToInt32(reader["id"]);
                conta.Numero = reader["Numero"].ToString();
                conta.Agencia = reader["Agencia"].ToString();
                conta.Saldo = Convert.ToDecimal(reader["Saldo"]);
                conta.Tipo = reader["Tipo"].ToString();
                listContas.Add(conta);
            }
            reader.Close();
            return listContas;
        }

        public bool Inserir(Conta conta)
        {
            var sql = "Insert into Contas (Numero, Agencia,Tipo) " +
                         "values (@Numero ,@Agencia,@Tipo)";
            SqlCommand SqlCommand = new SqlCommand(sql, conexao);
            SqlCommand.Parameters.AddWithValue("@Numero", conta.Numero);
            SqlCommand.Parameters.AddWithValue("@Agencia", conta.Agencia);
            SqlCommand.Parameters.AddWithValue("@Tipo", conta.Tipo);
            var retorno = SqlCommand.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }

        public bool Alterar(Conta conta)
        {
            var sql = "Update Contas set Agencia = @agencia, " +
                "Numero = @numero, Tipo = @tipo, Saldo = @saldo WHERE Id = @id";

            SqlCommand SqlCommand = new SqlCommand(sql, conexao);
            SqlCommand.Parameters.AddWithValue("@agencia", conta.Agencia);
            SqlCommand.Parameters.AddWithValue("@numero", conta.Numero);
            SqlCommand.Parameters.AddWithValue("@tipo", conta.Tipo);
            SqlCommand.Parameters.AddWithValue("@saldo", conta.Saldo);
            SqlCommand.Parameters.AddWithValue("@id", conta.Id);
            var retorno = SqlCommand.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }

        public bool Alterar(Conta conta, SqlTransaction sqlTransaction)
        {
            var sql = "Update Contas set Agencia = @agencia, " +
                "Numero = @numero, Tipo = @tipo, Saldo = @saldo WHERE Id = @id";

            SqlCommand SqlCommand = new SqlCommand(sql, conexao, sqlTransaction);
            SqlCommand.Parameters.AddWithValue("@agencia", conta.Agencia);
            SqlCommand.Parameters.AddWithValue("@numero", conta.Numero);
            SqlCommand.Parameters.AddWithValue("@tipo", conta.Tipo);
            SqlCommand.Parameters.AddWithValue("@saldo", conta.Saldo);
            SqlCommand.Parameters.AddWithValue("@id", conta.Id);
            var retorno = SqlCommand.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }

        public bool Deletar(Conta conta)
        {
            var sql = "Delete from Contas where Id = @id";

            SqlCommand SqlCommand = new SqlCommand(sql, conexao);
            SqlCommand.Parameters.AddWithValue("@id", conta.Id);
            var retorno = SqlCommand.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }
    }
}
