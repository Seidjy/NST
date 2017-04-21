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
    public partial class TelaSaqueDebito : Form
    {
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaSaqueDebito()
        {
            InitializeComponent();
        }

        public TelaSaqueDebito(Conta conta, TelaConsulta telaConsulta)
        {
            Conta = conta;
            TelaConsulta = telaConsulta;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaSaqueDebito_Load(object sender, EventArgs e)
        {

        }
    }
}
