using UNASP.SisAmigos.Windows.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNASP.SisAmigos.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // A aplicação inicia a execução pelo form de autenticação
            Application.Run(new frmAutenticacao());
        }
    }
}
