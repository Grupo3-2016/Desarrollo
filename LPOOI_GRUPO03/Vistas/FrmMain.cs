using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public string sLogInApellido = Program.ssApellido;
        public string sLogInNombre = Program.ssNombre;
        public int nLogInRol = Program.snRol;
        public int nLogInUser= Program.snUser;
        private string sRol;

        public FrmMain()
        {
            InitializeComponent();
            msMenu.Renderer = new MyRenderer();
        }

        //Aspecto MenuStrip
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Ivory; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Transparent; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Transparent; }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UserAccess();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblUserLogin.Text = "Bienvenido: " + sLogInApellido +", "+sLogInNombre+"  ("+sRol+")";
            lblClock.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        //Acceso de Usuario
        private void UserAccess()
        {
            if (nLogInRol == 1)
            {
                sRol = "Administrador";
                tsmStock.Visible = true;
                tsmBuy.Visible = true;
                tsmProduct.Visible = true;
                tsmSell.Visible = true;
                tsmUser.Visible = true;
            }
            if (nLogInRol == 2)
            {
                sRol = "Repositor";
                tsmStock.Visible = true;
            }
            if (nLogInRol == 3)
            {
                sRol = "Pastelero";
                tsmProduct.Visible = true;
            }
            if (nLogInRol == 4)
            {
                sRol = "Comprador";
                tsmBuy.Visible = true;
            }
            if (nLogInRol == 5)
            {
                sRol = "Vendedor";
                tsmSell.Visible = true;
            }
            if (nLogInRol == 6)
            {
                sRol = "Cajero";
                tsmBuy.Visible = true;
                tsmSell.Visible = true;
            }
        }

        //Botones de Control
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea Salir?", "◄ AVISO | Grupo 03 ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void tsmLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea Cerrar Sesión?", "◄ AVISO | Grupo 03 ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        //Evento TSM Click
        private void tsmCompras_Click(object sender, EventArgs e)
        {
            FrmCompra oComp = FrmCompra.GetInstancia();
            oComp.MdiParent = this;
            oComp.Show();
        }
        private void tsmStock_Click(object sender, EventArgs e)
        {
            FrmArticulo oArt = FrmArticulo.GetInstancia();
            oArt.MdiParent = this;
            oArt.Show();
        }
        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario oUsuario = FrmUsuario.GetInstancia();
            oUsuario.MdiParent = this;
            oUsuario.Show();
        }

        //Efecto de Imagenes de los TSM
        private void ChangeImage_MouseEnter(object sender, EventArgs e)
        {
            string sImage = ((ToolStripMenuItem)sender).Name.Remove(0, 3).ToLower() + "2";
            ((ToolStripMenuItem)sender).Image = (Image)Properties.Resources.ResourceManager.GetObject(sImage);
        }
        private void ChangeImage_MouseLeave(object sender, EventArgs e)
        {
            string sImage = ((ToolStripMenuItem)sender).Name.Remove(0, 3).ToLower() + "1";
            ((ToolStripMenuItem)sender).Image = (Image)Properties.Resources.ResourceManager.GetObject(sImage);
        }
    }
}
