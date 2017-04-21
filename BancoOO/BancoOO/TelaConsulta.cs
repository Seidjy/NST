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
        DAL dal = new DAL();

        public TelaConsulta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Atualizar();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Conta linha = dataGridView1.SelectedRows[0].DataBoundItem as Conta;
            
            if (rbAlterar.Checked)
            {
                    TelaAlterar telaAlterar = new TelaAlterar(linha, this);
                    telaAlterar.Show();
                }
                else if (rbSaqueDebito.Checked)
                {
                    TelaSaqueCredito telaSaqueDebito = new TelaSaqueCredito(linha, this);
                    telaSaqueDebito.Show();
                }
                else if (rbTransferencia.Checked)
                {
                    TelaTransferencia telaAlterar = new TelaTransferencia(linha, this);
                    telaAlterar.Show();
                }else if (rbExcluir.Checked)
                {
                    dal.Deletar(linha);
                    Atualizar();
                }
            
        }

        public void Atualizar()
        {
            dataGridView1.DataSource = dal.GetAll();
        }

        private void rbExcluir_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
