using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseConexion;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        //Boton de Logueo al Sistema
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                DataTable oUser = TrabajarUsuario.LogIn(txtUserName.Text, txtPassword.Text);
                if (oUser.Rows.Count == 0)
                {
                    MessageBox.Show("Datos de acceso incorrectos.");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
                else
                {
                    //TrabajarHistorial.InsertHLog((int)oUser.Rows[0][0],DateTime.Now);

                    Program.snUser = (int)oUser.Rows[0][0];
                    Program.ssApellido = oUser.Rows[0][1].ToString();
                    Program.ssNombre = oUser.Rows[0][2].ToString();
                    Program.snRol = (int)oUser.Rows[0][3];

                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Datos Vacíos, introduzca datos");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtUserName.Focus();
            }
        }

        //Botones Minimizar y Cerrar con LinkLabels
        private void lnkMinimized_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea Salir?", "◄ AVISO | Grupo 03 ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Evento del botón LogIn
        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.White;
            btnLogIn.BackColor = Color.RosyBrown;
        }
        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.BackColor = Color.LavenderBlush;
        }

        
    }
}
