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
       public SqlConnection conexao { get; set; } //foi criada a conexao

        public DAL()//construtor inicia conexão e abre ela //metodo que instancia o objeto.
        {
            //Seidjy
            //   var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //Tamara
            var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //Nathalia
            //var caminho = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            conexao = new SqlConnection(caminho); //instancia junto com o caminho
            conexao.Open();
        }
   
        public Conta Buscar(Conta conta) //o metodo retorna e recebe conta
        {

            conexao.Open(); //abri a conexao com o banco do caminho recebido
            var sql = "select * from Contas where Id = @id"; // comando que excutará no banco junto com o @id parametro.
            SqlCommand SqlCommand = new SqlCommand(sql, conexao); // comando que vai executar
            SqlCommand.Parameters.AddWithValue("@Id", conta.Id); // seleciona parametro e onde ta id vai por conta.id

            SqlDataReader reader = SqlCommand.ExecuteReader(); //executereader executa comando no banco e retorna um valor do tipo sqldatareader.
            //conta = null;
            while (reader.Read()) //vai ler o que recebeu do banco.
            {
                conta = new Conta(); //banco ta passando pra conta
                conta.Id = Convert.ToInt32(reader["id"]);
                conta.Numero = reader["Numero"].ToString();
                conta.Agencia = reader["Agencia"].ToString();
                conta.Saldo = Convert.ToDecimal(reader["Saldo"]);
                conta.Tipo = reader["Tipo"].ToString();
            }

            return conta;
        }

        public List<Conta> GetAll() //retorna a lista de conta
        {
            conexao.Close();
            conexao.Open(); //abri a conexao com o banco do caminho recebido
            var sql = "select * from Contas"; 
            SqlCommand SqlCommand = new SqlCommand(sql, conexao);

            SqlDataReader reader = SqlCommand.ExecuteReader();
            Conta conta = null; //conta esta nula
            List<Conta> listContas = new List<Conta>(); //lista foi instanciada.
            while (reader.Read()) //vai ficar rodando o reader ate a lista do reader tiver sido lida.
            {
                conta = new Conta();
                conta.Id = Convert.ToInt32(reader["id"]);
                conta.Numero = reader["Numero"].ToString();
                conta.Agencia = reader["Agencia"].ToString();
                conta.Saldo = Convert.ToDecimal(reader["Saldo"]);
                conta.Tipo = reader["Tipo"].ToString();
                listContas.Add(conta);
            }
            //reader.Close();
            return listContas;
        }

        public bool Inserir(Conta conta)
        {
            conexao.Close();
            conexao.Open(); //abri a conexao com o banco do caminho recebido
            var sql = "Insert into Contas (Numero, Agencia,Tipo) " +
                         "values (@Numero ,@Agencia,@Tipo)";
            SqlCommand SqlCommand = new SqlCommand(sql, conexao);
            SqlCommand.Parameters.AddWithValue("@Numero", conta.Numero);
            SqlCommand.Parameters.AddWithValue("@Agencia", conta.Agencia);
            SqlCommand.Parameters.AddWithValue("@Tipo", conta.Tipo);
            var retorno = SqlCommand.ExecuteNonQuery(); //usado para inserir ou alterar e o numero de linhas que foi alterado.
            if (retorno > 0)
                return true; 
            else
                return false;
        }

        public bool Alterar(Conta conta)
        {
            conexao.Close();
            conexao.Open(); //abri a conexao com o banco do caminho recebido
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

        public bool Alterar(Conta conta, SqlTransaction sqlTransaction)//Alteração com transação
        {

            var sql = "Update Contas set Agencia = @agencia, " +
                "Numero = @numero, Tipo = @tipo, Saldo = @saldo WHERE Id = @id";

            SqlCommand SqlCommand = new SqlCommand(sql, conexao, sqlTransaction); //toda vez que for alterado vai marcar na transaction
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

        public bool Transacao(Conta conta, Conta conta2) 
        {
            conexao.Close();
            //Criar e iniciar transação
            conexao.Open();
            SqlTransaction sqlTransaction = conexao.BeginTransaction();//Conexão Transação
            try
            {
                Alterar(conta,sqlTransaction);//Conta onde ocorre o saque
                Alterar(conta2, sqlTransaction);//Conta onde ocorre o debito
                sqlTransaction.Commit();
                return true;
            }
            catch (Exception)
            {
                sqlTransaction.Rollback();//caso alguma alterações deu errado voltar o estado do banco ao estado anterior delas
                return false;
            }
        }

        public bool Deletar(Conta conta)
        {
            conexao.Close();
            conexao.Open(); //abri a conexao com o banco do caminho recebido
            var sql = "Delete from Contas where Id = @id";

            SqlCommand SqlCommand = new SqlCommand(sql, conexao);
            SqlCommand.Parameters.AddWithValue("@id", conta.Id);
            var retorno = SqlCommand.ExecuteNonQuery();  //retorna se tive alteração no banco.
            if (retorno > 0)
                return true;
            else
                return false;
        }
    }
}
