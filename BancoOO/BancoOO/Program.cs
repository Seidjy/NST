using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
    /*
     * Nathália Adriele de Lima - 547621
     * Samuel Seidjy Padovan - 548596
     * Tamara da Silva Zoner - 438367 
     */
namespace BancoOO
{
    static class Program
    {

        /// Ponto de entrada principal para o aplicativo.
   
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
        }
    }
}
