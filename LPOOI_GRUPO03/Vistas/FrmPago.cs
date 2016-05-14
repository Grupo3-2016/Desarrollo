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
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
            LoadProvider();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            LoadOrden();
            LoadProvider();
            ListPagos();
            dtFechaDesde.MaxDate = DateTime.Now;
        }

        //Mensajes utilizados para interactuar con el Usuario
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Procedimientos del Formulario
        private void LoadOrden()
        {
            DataTable nuevo = TrabajarPago.ViewOrden();
            DataRow row = nuevo.NewRow();
            row["Orden"] = 0;
            row["Proveedor"] = "<Seleccione valor...>";
            nuevo.Rows.InsertAt(row, 0);
            cmbOrden.DisplayMember = "Proveedor";
            cmbOrden.ValueMember = "Orden";
            cmbOrden.DataSource = nuevo;
        }
        private void LoadProvider()
        {
            DataTable rolNuevo = TrabajarProveedor.ViewProvider();
            DataRow row = rolNuevo.NewRow();
            row["prov_id"] = 0;
            row["Nombre"] = "<Seleccione uno...>";
            rolNuevo.Rows.InsertAt(row, 0);
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "prov_id";
            cmbProveedor.DataSource = rolNuevo;
        }

        private void ListPagos()
        {
            this.dgwPagos.DataSource = TrabajarPago.ViewPagos();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwPagos.Rows.Count);
            dgwPagos.Columns[4].Visible = false;
        }
        private void ListPagos(int nProv)
        {
            this.dgwPagos.DataSource = TrabajarPago.ViewPagos(nProv);
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwPagos.Rows.Count);
            dgwPagos.Columns[4].Visible = false;
        }
        private void ListPagos(DateTime dFecha1, DateTime dFecha2)
        {
            this.dgwPagos.DataSource = TrabajarPago.ViewPagos(dFecha1,dFecha2);
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwPagos.Rows.Count);
            dgwPagos.Columns[4].Visible = false;
        }

        private void cmbOrden_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbOrden.SelectedValue) != 0)
            {
                DataTable tabla = TrabajarOrden.GetOrden(Convert.ToInt32(cmbOrden.SelectedValue));
                txtProv_Id.Text = tabla.Rows[0][5].ToString();
                txtOP_Importe.Text = tabla.Rows[0][4].ToString();
                dtOP_Fecha.Value = (DateTime)tabla.Rows[0][2];
                dtOP_Fecha.MinDate = (DateTime)tabla.Rows[0][2];
                btnSaveOP.Enabled = true;
                btnCancelOP.Enabled = true;
                dtOP_Fecha.Enabled = true;
            }
            else
            {
                txtProv_Id.Text = string.Empty;
                txtOP_Importe.Text = string.Empty;
                dtOP_Fecha.Value = DateTime.Now;
                btnSaveOP.Enabled = false;
                btnCancelOP.Enabled = false;
                dtOP_Fecha.Enabled = false;
            }
        }

        private void btnSaveOP_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Convert.ToInt32(cmbOrden.SelectedValue)!=0 && Opcion==DialogResult.OK)
                {
                    //Vamos a insertar un Trabajador 
                        Rpta = TrabajarPago.InsertOrden(Convert.ToInt32(cmbOrden.SelectedValue),Convert.ToInt32(txtProv_Id.Text.Trim()),
                            dtOP_Fecha.Value,Convert.ToDecimal(txtOP_Importe.Text.Trim()));
                    
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se insertó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                    this.cmbOrden.SelectedValue = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnCancelOP_Click(object sender, EventArgs e)
        {
            cmbOrden.SelectedValue = 0;
            cmbOrden.Focus();
        }

        private void cmbProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProveedor.SelectedValue) != 0)
            {
                ListPagos(Convert.ToInt32(cmbProveedor.SelectedValue));
            }
            else
            {
                ListPagos();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtFechaHasta.Value >= dtFechaDesde.Value)
            {
                cmbProveedor.SelectedValue = 0;
                ListPagos(dtFechaDesde.Value, dtFechaHasta.Value);
            }
            else dtFechaHasta.Focus();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        
    }
}
