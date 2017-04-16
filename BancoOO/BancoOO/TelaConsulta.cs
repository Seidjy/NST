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

            this.Atualizar();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Conta linha = dataGridView1.SelectedRows[0].DataBoundItem as Conta;
            //Criar um novo form para editar e atualiza-lo no BD

            TelaAlterar form2 = new TelaAlterar(linha, this);
            form2.Show();

        }

        public void Atualizar()
        {
            DAL dal = new DAL();

            dataGridView1.DataSource = dal.GetAll();
        }
    }
}
