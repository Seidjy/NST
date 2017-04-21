using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoOO
{
    /*
     * Nathália Adriele de Lima - 547621
     * Samuel Seidjy Padovan - 548596
     * Tamara da Silva Zoner - 438367 
     */
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Item do menu que irá abrir a tela de cadastro
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //item do menu que irá abrir a tela de consulta
            TelaConsulta telaConsulta = new TelaConsulta();
            telaConsulta.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
