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
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class FrmCompra : Form
    {
        private bool IsNuevo;
        //Variables utilizadas para informar el movimiento del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Orden_Compra ordenCompra= new Orden_Compra();
        private DataTable listaDetalles;
        private Decimal total;
        private Decimal subTotal;
        private int idArtSeleccionado ;
        private static FrmCompra _instancia;

        //Obtenemos la instancia del Form Activarlo(Traerlo a primer plano) o Cerrado(Null)
        public static FrmCompra GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmCompra();
            }
            else
            {
                _instancia.Activate();
                if (_instancia.WindowState == FormWindowState.Minimized) _instancia.WindowState = FormWindowState.Normal;
            }
            return _instancia;
        }
        private void FrmCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        public FrmCompra()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        private void FrmCompra_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, Color.Ivory);
            this.ShoppingList();
            this.LoadProviders();
            this.EnableFields(false);
            this.ActivateButtons();
            this.CreateTable();
        }

        //Mensajes utilizados para interactuar con el Usuario
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Procedimientos del Formulario
        private void ActivateButtons()
        {
            if (this.IsNuevo) //Alt + 124
            {
                this.EnableFields(true);
                this.btnNewOC.Enabled = false;
                this.btnSaveOC.Enabled = true;
                this.btnCancelOC.Enabled = true;
            }
            else
            {
                this.EnableFields(false);
                this.btnNewOC.Enabled = true;
                this.btnSaveOC.Enabled = false;
                this.btnCancelOC.Enabled = false;
            }

        }
        private void CalculateTotal()
        {
            total = 0;
            foreach(DataRow item in listaDetalles.Rows)
            {
                total += Convert.ToDecimal(item["Subtotal"]);
            }
            lblTotal_Pagado.Text = Convert.ToString(total);
        }
        private void ClearDetail()
        {
            this.txtArt_Descrip.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtArt_Costo.Text = string.Empty;
            this.dtOc_Fecha.Value = DateTime.Now;
            this.cmbProv_ID.DataSource = null;
            this.dgvDetallesItems.DataSource = null;

            lblTotal_Pagado.Text = "0.0";
            errorIcono.Clear();
        }
        private void CreateTable()
        {
            this.listaDetalles = new DataTable("Detalle");
            this.listaDetalles.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.listaDetalles.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.listaDetalles.Columns.Add("Articulo", System.Type.GetType("System.String"));
            this.listaDetalles.Columns.Add("Costo", System.Type.GetType("System.Decimal"));
            this.listaDetalles.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dgvDetallesItems.DataSource = this.listaDetalles;
            this.dgvDetallesItems.Columns[0].Visible = false;
        }
        private void DetailsList()
        {
            this.dgvDetallesItems.DataSource = TrabajarOrden.ViewItem(Convert.ToInt32(this.txtOc_ID.Text));
        }
        private void EnableFields(bool value)
        {
            this.dtOc_Fecha.Enabled = value;
            this.rbNo.Enabled = value;
            this.rbYes.Enabled = value;
            this.cmbProv_ID.Enabled = value;
            this.btnSearchArt.Enabled = value;
            this.btnAdd.Enabled = value;
            this.btnRemove.Enabled = value;
            btnSaveOC.Enabled = value;
            btnNewOC.Enabled = !value;
            btnCancelOC.Enabled = value;
        }
        private void LoadProvider()
        {
            DataTable rolNuevo = TrabajarProveedor.ViewProvider();
            DataRow row = rolNuevo.NewRow();
            row["prov_id"] = 0;
            row["Nombre"] = "<Seleccione uno...>";
            rolNuevo.Rows.InsertAt(row, 0);
            cmbProv_ID.DisplayMember = "Nombre";
            cmbProv_ID.ValueMember = "prov_id";
            cmbProv_ID.DataSource = rolNuevo;
        }
        private void LoadProviders()
        {
            DataTable nuevo = TrabajarProveedor.ViewProvider();
            DataRow row = nuevo.NewRow();
            row["prov_id"] = 0;
            row["Nombre"] = "<Seleccione uno...>";
            nuevo.Rows.InsertAt(row, 0);
            cmbProv.DisplayMember = "Nombre";
            cmbProv.ValueMember = "prov_id";
            cmbProv.DataSource = nuevo;
        }
        public void SetArticulo(DataGridViewRow rowArtSelecionado)
        {
            idArtSeleccionado = Convert.ToInt32(rowArtSelecionado.Cells["Codigo"].Value);
            this.txtArt_Descrip.Text = Convert.ToString(rowArtSelecionado.Cells["Descripcion"].Value);
            this.txtArt_Costo.Text = Convert.ToString(rowArtSelecionado.Cells["Costo"].Value);
            txtCantidad.Text = "1";
            txtArt_Costo.Enabled = true;
            txtCantidad.Enabled = true;
        }
        private void ShoppingList()
        {
            this.dataListado.DataSource = TrabajarOrden.ViewOrden();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            dataListado.Columns[5].Visible = false;
        }
        private void ShoppingList(int nProv)
        {
            this.dataListado.DataSource = TrabajarOrden.ViewOrden(nProv);
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            dataListado.Columns[5].Visible = false;
        }
        private void ValidateFieldDecimal(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.Clear();
                return;
            }
            if (char.IsDigit(e.KeyChar) || ((e.KeyChar == ',') && (!((TextBox)sender).Text.Contains(","))))
            {
                e.Handled = false;
                errorIcono.Clear();
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(((TextBox)sender), "No admite letras");
            }

            for (int i = 0; i < ((TextBox)sender).Text.Length; i++)
            {
                if (((TextBox)sender).Text[i] == ',')
                    IsDec = true;
                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                }
            }

        }
        public Boolean ValidateFieldsArticle()
        {
            try
            {
                errorIcono.Clear();
                Boolean isValido = true;
                if (txtArt_Descrip.Text == "")
                {
                    MensajeError("Seleccione un articulo");
                    return false;
                }
                if (this.txtCantidad.Text == string.Empty)
                {
                    isValido = false;
                    errorIcono.SetError(txtCantidad, "Ingrese un Valor");
                }
                if (this.txtArt_Costo.Text == string.Empty)
                {
                    isValido = false;
                    errorIcono.SetError(txtArt_Costo, "Ingrese un Valor");
                }
                
                if (!isValido)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                }
                return isValido;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public Boolean ValidateFieldsOC()
        {
            try
            {
                errorIcono.Clear();
                Boolean isValido = true;
                if (cmbProv_ID.SelectedIndex <= 0)
                {
                    isValido = false;
                    errorIcono.SetError(cmbProv_ID, "seleccione un proveedor");
                }

                if (!rbNo.Checked && !rbYes.Checked)
                {
                    isValido = false;
                    errorIcono.SetError(rbNo, "seleccione un estado para la orden");
                }

                if (dtOc_Fecha.Text == String.Empty)
                {
                    isValido = false;
                    errorIcono.SetError(dtOc_Fecha, "seleccione una Fecha");
                }
                if (!isValido)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                }
                return isValido;
            }
            catch (Exception ex)
            {
                MensajeError("los datos son incorrectos");
                Console.WriteLine(ex);
                return false;
            }
        }

        //Boton de Proveedor
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor vista = new FrmProveedor();
            vista.ShowDialog();
            if (btnNewOC.Enabled == false) LoadProvider();
        }

        //Botones de la sección de Mantenimiento
        private void btnSearchArt_Click(object sender, EventArgs e)
        {
            FrmArticuloVista vista = new FrmArticuloVista();
            vista.ShowDialog();
        }
        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsArticle())
            {
                Boolean registro = true;
                foreach (DataRow row in listaDetalles.Rows)
                {
                    if (Convert.ToInt32(row["idarticulo"]) == idArtSeleccionado)
                    {
                        registro = false;
                        this.MensajeError("YA se encuentra el artículo en el detalle");
                    }
                }
                if (registro)
                {
                    DataRow row = this.listaDetalles.NewRow();
                    row["idarticulo"] = idArtSeleccionado;
                    row["Cantidad"] = Convert.ToDecimal(this.txtCantidad.Text);
                    row["Articulo"] = this.txtArt_Descrip.Text;
                    row["Costo"] = Convert.ToDecimal(this.txtArt_Costo.Text);
                    row["Subtotal"] = subTotal;
                    this.listaDetalles.Rows.Add(row);
                    CalculateTotal();
                }
            }
        }
        private void btnRemoveDetail_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.dgvDetallesItems.CurrentCell.RowIndex;
                DataRow row = this.listaDetalles.Rows[indiceFila];
                this.listaDetalles.Rows.Remove(row);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }
        private void btnNewOC_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.ActivateButtons();
            this.EnableFields(true);
            this.LoadProvider();
            this.CreateTable();
            this.cmbProv_ID.Focus();
        }
        private void btnSaveOC_Click(object sender, EventArgs e)
        {
            string sRpta = "";
            if (ValidateFieldsOC())
            {
                if (this.IsNuevo)
                {
                    sRpta = TrabajarOrden.InsertOrden(Convert.ToInt32(cmbProv_ID.SelectedValue),dtOc_Fecha.Value,rbYes.Checked,total,listaDetalles);
                }
                if(sRpta.Equals("OK"))
                {
                    if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                }
                else
                {
                    MensajeError(sRpta);
                }
                this.IsNuevo = false;
                EnableFields(false);
                ClearDetail();
                ShoppingList();
                txtArt_Costo.Enabled = false;
                txtCantidad.Enabled = false;                

            }

        }
        private void btnCancelOC_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.ActivateButtons();

            this.EnableFields(false);
            this.ClearDetail();
        }

        // Eventos del DataGridView de Ordenes de Compra
        private void dgwOrdenCompra_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtOc_ID.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Número OC"].Value);
                this.cmbProv_ID.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Proveedor"].Value);
                this.dtOc_Fecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["Fecha"].Value);
                this.DetailsList();
                this.tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        //Eventos de los campos Cantidad y Costo
        private void ValidateDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateFieldDecimal(sender, e);
        }
        private void CalculateSubTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtArt_Costo.Text);
                lblSubTotal.Text = Convert.ToString(subTotal);
            }
            catch (Exception)
            {
                lblSubTotal.Text = "0";                
            }
            
        }
        
        //Botones de Control del Formulario
        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void lnkMinimized_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Cambio de Colores de los Botones
        private void btnColor_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.buttonHEnter;
        }
        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.buttonH;
        }
        private void btnColor_EnabledChanged(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == true)
            {
                ((Button)sender).BackgroundImage = Properties.Resources.buttonH;
            }
            else
            {
                ((Button)sender).BackgroundImage = Properties.Resources.buttonHDis;
            }
        }

        //Permite Mover el formulario desde cualquier parte del mismo
        private void FrmCompra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPago vista = new FrmPago();
            vista.ShowDialog();
            ShoppingList();
        }

        private void cmbProv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbProv.SelectedValue) != 0)
            {
                ShoppingList(Convert.ToInt32(cmbProv.SelectedValue));
                
            }
            else
            {
                ShoppingList();
            }
        }
    }
}
