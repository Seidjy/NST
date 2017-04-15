﻿using System;
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
    public partial class Form2 : Form
    {
        public Conta Conta { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Conta conta)
        {
            Conta = conta;
            InitializeComponent();
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            textBox1.Text = Conta.Agencia.ToString();
            textBox3.Text = Conta.Saldo.ToString();

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
            var stringConexao = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conexao = new SqlConnection(stringConexao);

            conexao.Open();            

            Conta conta = new Conta();

            conta.Agencia = Convert.ToString(textBox1.Text);
            
            conta.Saldo = Convert.ToDecimal(textBox3.Text);

            if (radioButton1.Checked)
            {
                conta.Tipo = "C";
            }
            else
            {
                conta.Tipo = "P";
            }

            SqlCommand comando = new SqlCommand("UPDATE Contas SET Agencia = @agencia, Saldo = @saldo, Tipo = @tipo where Id = @id", conexao);
            comando.Parameters.AddWithValue("@agencia", conta.Agencia);
            comando.Parameters.AddWithValue("@saldo", conta.Saldo);
            comando.Parameters.AddWithValue("@tipo", conta.Tipo);
            comando.Parameters.AddWithValue("@id",  conta.Id);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}
