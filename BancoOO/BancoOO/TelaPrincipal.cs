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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsulta telaConsulta = new TelaConsulta();
            telaConsulta.Show();
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
