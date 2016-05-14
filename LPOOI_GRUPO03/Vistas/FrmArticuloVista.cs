using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseConexion;

namespace Vistas
{
    public partial class FrmArticuloVista : Form
    {
        public FrmArticuloVista()
        {
            InitializeComponent();
        }

        private void FrmVistaArticulo_Load(object sender, EventArgs e)
        {
            this.ArticlesList();
        }

        //Procedimientos de la Vista
        private void ArticlesList()
        {
            this.dgwArticulo.DataSource = TrabajarArticulo.ViewArticles();
            this.HideColumns();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwArticulo.Rows.Count);
        }
        private void HideColumns()
        {
            this.dgwArticulo.Columns[0].Visible = false;
            this.dgwArticulo.Columns[6].Visible = false;
            this.dgwArticulo.Columns[8].Visible = false;
            this.dgwArticulo.Columns[9].Visible = false;
            this.dgwArticulo.Columns[10].Visible = false;
            this.dgwArticulo.Columns[12].Visible = false;
            this.dgwArticulo.Columns[13].Visible = false;
            this.dgwArticulo.Columns[14].Visible = false;
        }

        //Evento del DataGridView
        private void dgwArticulo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                FrmCompra form = FrmCompra.GetInstancia();
                //string par1, par2;
                //par1 = convert.tostring(this.dgwarticulo.currentrow.cells["id"].value);
                //par2 = convert.tostring(this.dgwarticulo.currentrow.cells["descripcion"].value);
                //form.setarticulo(par1, par2);
                DataGridViewRow artSeleccionado = this.dgwArticulo.CurrentRow;
                form.SetArticulo(artSeleccionado);
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
