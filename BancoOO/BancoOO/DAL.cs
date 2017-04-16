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

        public DAL()
        {
            //Seidjy
            var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            conexao = new SqlConnection(caminho);
            conexao.Open();

        }

        public Conta Buscar(Conta conta)
        {
            var sql = "select * from Contas where Id = @id";
            var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", conta.Id);

            SqlDataReader reader = comando.ExecuteReader();
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
            var comando = new SqlCommand(sql, conexao);

            SqlDataReader reader = comando.ExecuteReader();
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
            return listContas;
        }

        public bool Inserir(Conta conta)
        {
            var sql = "Insert into Contas (Numero, Agencia,Tipo) " +
                         "values (@Numero ,@Agencia,@Tipo)";
            var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Numero", conta.Numero);
            comando.Parameters.AddWithValue("@Agencia", conta.Agencia);
            comando.Parameters.AddWithValue("@Tipo", conta.Tipo);
            var retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }
        public bool Alterar(Conta conta)
        {
            var sql = "Update Contas set Agencia = @agencia, " +
                "Numero = @numero, Tipo = @tipo, Saldo = @saldo WHERE Id = @id";

            var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@agencia", conta.Agencia);
            comando.Parameters.AddWithValue("@numero", conta.Numero);
            comando.Parameters.AddWithValue("@tipo", conta.Tipo);
            comando.Parameters.AddWithValue("@saldo", conta.Saldo);
            comando.Parameters.AddWithValue("@id", conta.Id);
            var retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }

        public bool Deletar(Conta conta)
        {
            var sql = "Delete from Contas where Id = @id";

            var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", conta.Id);
            var retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
                return true;
            else
                return false;
        }
    }
}
