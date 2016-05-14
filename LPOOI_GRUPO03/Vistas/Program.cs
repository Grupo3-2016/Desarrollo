using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static int snUser = 0;
        public static string ssApellido = "";
        public static string ssNombre = "";
        public static int snRol = 0;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmUsuario());
            FrmLogin oLogin = new FrmLogin();
            oLogin.ShowDialog();

            if (oLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}
