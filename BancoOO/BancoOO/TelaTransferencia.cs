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
    public partial class TelaTransferencia : Form
    {
        public Conta Conta { get; set; }
        public TelaConsulta TelaConsulta { get; set; }

        public TelaTransferencia()
        {
            InitializeComponent();
        }

        public TelaTransferencia(Conta conta, TelaConsulta telaConsulta)
        {
            Conta = conta;
            TelaConsulta = telaConsulta;
            InitializeComponent();
        }

        private void TelaTransferencia_Load(object sender, EventArgs e)
        {

        }
    }
}
