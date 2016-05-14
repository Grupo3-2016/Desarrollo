using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseConexion;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class FrmArticulo : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        //Variables utilizadas para informar el movimiento del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private static FrmArticulo _instancia;

        //Obtenemos la instancia del Form Activarlo(Traerlo a primer plano) o Cerrado(Null)
        public static FrmArticulo GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmArticulo();
            }
            else
            {
                _instancia.Activate();
                if (_instancia.WindowState == FormWindowState.Minimized) _instancia.WindowState = FormWindowState.Normal;
            }
            return _instancia;
        }
        private void FrmArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        public FrmArticulo()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100,Color.Ivory);
            this.ArticlesList();
            this.EnableFields(false);
            this.ActivateButtons();
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
            if (this.IsNuevo || this.IsEditar)
            {
                this.EnableFields(true);
                this.btnNewArt.Enabled = false;
                this.btnSaveArt.Enabled = true;
                this.btnEditArt.Enabled = false;
                this.btnCancelArt.Enabled = true;
            }
            else
            {
                this.EnableFields(false);
                this.btnNewArt.Enabled = true;
                this.btnSaveArt.Enabled = false;
                this.btnEditArt.Enabled = true;
                this.btnCancelArt.Enabled = false;
            }
        }
        private void ArticlesList()
        {
            this.dgwArticulo.DataSource = TrabajarArticulo.ViewArticles();
            this.HideColumns();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwArticulo.Rows.Count);
        }
        private void CalculatePrice(object sender)
        {
            decimal precio;
            if (((TextBox)sender).Text != "")
            {
                decimal dCambio = decimal.Parse(((TextBox)sender).Text);
                ((TextBox)sender).Text = dCambio.ToString("N2");
            }
            if (txtArt_Costo.Text != "" && txtArt_MB.Text != "")
            {
                precio = decimal.Parse(txtArt_Costo.Text) / (1 - (decimal.Parse(txtArt_MB.Text) / 100));
                txtArt_Precio.Text = precio.ToString("N2");
            }
            else
            {
                txtArt_Precio.Text = "";
            }
        }
        private void ClearFields()
        {
            this.txtArt_ID.Text = string.Empty;
            this.txtArt_Descrip.Text = string.Empty;
            this.txtArt_Costo.Text = string.Empty;
            this.txtArt_Precio.Text = string.Empty;
            this.txtArt_SA.Text = string.Empty;
            this.txtArt_SMax.Text = string.Empty;
            this.txtArt_SMin.Text = string.Empty;
            this.txtArt_SR.Text = string.Empty;
            this.cbArt_Fam.DataSource = null;
            this.cbArt_UM.DataSource = null;
            this.rbYes.Checked = false;
            this.rbNo.Checked = false;
        }
        private void EnableFields(bool valor)
        {
            this.txtArt_Descrip.ReadOnly = !valor;
            this.txtArt_SMin.ReadOnly = !valor;
            this.txtArt_SMax.ReadOnly = !valor;
            this.cbArt_Fam.Enabled = valor;
            this.cbArt_UM.Enabled = valor;
            this.rbYes.Enabled = valor;
            this.rbNo.Enabled = valor;
            this.txtArt_Precio.ReadOnly = !valor;
            this.txtArt_Costo.ReadOnly = !valor;
            this.txtArt_MB.ReadOnly = !valor;
            this.txtArt_SR.ReadOnly = !valor;
            this.txtArt_SA.ReadOnly = !valor;
        }
        private void HideColumns()
        {
            this.dgwArticulo.Columns[0].Visible = false;
            this.dgwArticulo.Columns[6].Visible = false;
            this.dgwArticulo.Columns[8].Visible = false;
            this.dgwArticulo.Columns[9].Visible = false;
            this.dgwArticulo.Columns[10].Visible = false;
        }
        private void HighLoadFamily()
        {
            DataTable newTable = TrabajarArticulo.ViewFamilia();
            DataRow row = newTable.NewRow();
            row["fam_id"] = 0;
            row["fam_descrip"] = "<Seleccione valor...>";
            newTable.Rows.InsertAt(row, 0);
            cbArt_Fam.DisplayMember = "fam_descrip";
            cbArt_Fam.ValueMember = "fam_id";
            cbArt_Fam.DataSource = newTable;
        }
        private void HighLoadMeasure()
        {
            DataTable newTable = TrabajarArticulo.ViewUM();
            DataRow row = newTable.NewRow();
            row["um_id"] = 0;
            row["um_descrip"] = "<Seleccione valor...>";
            newTable.Rows.InsertAt(row, 0);
            cbArt_UM.DisplayMember = "um_descrip";
            cbArt_UM.ValueMember = "um_id";
            cbArt_UM.DataSource = newTable;
        }
        private void LoadFamily()
        {
            cbArt_Fam.DisplayMember = "fam_descrip";
            cbArt_Fam.ValueMember = "fam_id";
            cbArt_Fam.DataSource = TrabajarArticulo.ViewFamilia();
        }
        private void LoadMeasure()
        {
            cbArt_UM.DisplayMember = "um_descrip";
            cbArt_UM.ValueMember = "um_id";
            cbArt_UM.DataSource = TrabajarArticulo.ViewUM();
        }
        private bool SearchField(string TextoABuscar, string Columna, DataGridView grid)
        {
            bool encontrado = false;
            if (grid.RowCount == 0) return false;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (Convert.ToString(row.Cells[Columna].Value) == TextoABuscar)
                {
                    return true;
                }
            }
            return encontrado;
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
        private void ValidateFieldLetters(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorIcono.Clear();
            }
            else
            {
                e.Handled = true;
                errorIcono.SetError(((TextBox)sender), "Caracter Inválido");
            }
        }
        private Boolean ValidateFields()
        {
            Boolean valido = true;
            errorIcono.Clear();
            if (this.txtArt_Descrip.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_Descrip, "Ingrese un Valor");
                valido = false;
            }

            if (this.txtArt_SMin.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_SMin, "Ingrese un Valor");
                valido = false;
            }

            if (this.txtArt_SMax.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_SMax, "Ingrese un Valor");
                valido = false;
            }
            if (this.txtArt_Costo.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_Costo, "Ingrese un Valor");
                valido = false;
            }
            if (this.txtArt_MB.Text == string.Empty)
            {
                errorIcono.SetError(txtArt_MB, "Ingrese un Valor");
                valido = false;
            }

            if ((int)cbArt_Fam.SelectedValue == 0)
            {
                errorIcono.SetError(cbArt_Fam, "Seleccione valor");
                valido = false;
            }

            if ((int)cbArt_UM.SelectedValue == 0)
            {
                errorIcono.SetError(cbArt_UM, "Seleccione valor");
                valido = false;
            }

            if ((rbYes.Checked == false) && (rbNo.Checked == false))
            {
                errorIcono.SetError(rbNo, "Selecione opción");
                valido = false;
            }

            if (!valido)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }

            return valido;
        }

        //Botones de la sección de Mantenimiento
        private void btnNewArt_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.ActivateButtons();
            this.ClearFields();
            this.EnableFields(true);
            this.HighLoadFamily();
            this.HighLoadMeasure();
            this.txtArt_Descrip.Focus();
        }
        private void btnSaveArt_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (ValidateFields())
                {
                    if (this.IsNuevo)
                    {
                        rpta = TrabajarArticulo.InsertArt(txtArt_Descrip.Text, Convert.ToInt32(cbArt_Fam.SelectedValue),
                            Convert.ToInt32(cbArt_UM.SelectedValue), Convert.ToDecimal(txtArt_Costo.Text), Convert.ToDecimal(txtArt_MB.Text), 
                            Convert.ToDecimal(txtArt_Precio.Text), Convert.ToDecimal(txtArt_SMin.Text), Convert.ToDecimal(txtArt_SMax.Text), 
                            Convert.ToDecimal(txtArt_SR.Text), Convert.ToDecimal(txtArt_SA.Text), rbYes.Checked);
                    }
                    else
                    {
                        rpta = TrabajarArticulo.EditArt(Convert.ToInt32(txtArt_ID.Text), txtArt_Descrip.Text, Convert.ToInt32(cbArt_Fam.SelectedValue),
                            Convert.ToInt32(cbArt_UM.SelectedValue), Convert.ToDecimal(txtArt_Costo.Text), Convert.ToDecimal(txtArt_MB.Text),
                            Convert.ToDecimal(txtArt_Precio.Text), Convert.ToDecimal(txtArt_SMin.Text), Convert.ToDecimal(txtArt_SMax.Text),
                            Convert.ToDecimal(txtArt_SR.Text), Convert.ToDecimal(txtArt_SA.Text), rbYes.Checked);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.ActivateButtons();
                    this.ClearFields();
                    this.ArticlesList();
                }
                else
                {
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnEditArt_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            if (!this.txtArt_ID.Text.Equals(""))
            {
                string sNameFam = cbArt_Fam.Text;
                string sNameUM = cbArt_UM.Text;
                this.IsEditar = true;
                this.ActivateButtons();
                this.EnableFields(true);
                this.LoadFamily();
                this.LoadMeasure();
                this.cbArt_Fam.Text = sNameFam;
                this.cbArt_UM.Text = sNameUM;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
        private void btnCancelArt_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.ActivateButtons();
            this.ClearFields();
            this.EnableFields(false);
        }

        //Botones Listado
        private void btnOrderArt_Click(object sender, EventArgs e)
        {
            if (rbCod.Checked)
            {
                txtSearchArt.Text = "";
                dgwArticulo.DataSource = TrabajarArticulo.ViewArticles();
                HideColumns();
            }
            if (rbDescrip.Checked)
            {
                txtSearchArt.Text = "";
                dgwArticulo.DataSource = TrabajarArticulo.OrderArticles();
                HideColumns();
            }
        }
        private void btnDeleteArt_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = TrabajarArticulo.DeleteArt(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.ArticlesList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnSearchArt_Click(object sender, EventArgs e)
        {
            if (txtSearchArt.Text != "")
            {
                dgwArticulo.DataSource = TrabajarArticulo.SearchArt(txtSearchArt.Text);
                HideColumns();
            }
            else
            {
                ArticlesList();
            }
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwArticulo.Rows.Count);
        }
        private void dgwArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwArticulo.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgwArticulo.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void dgwArticulo_DoubleClick(object sender, EventArgs e)
        {
            this.txtArt_ID.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Codigo"].Value);
            this.txtArt_Descrip.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Descripcion"].Value);
            this.cbArt_Fam.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Familia"].Value);
            this.cbArt_UM.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Unidad Medida"].Value);
            this.txtArt_Costo.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Costo"].Value);
            this.txtArt_MB.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Margen Beneficio"].Value);
            this.txtArt_Precio.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Precio"].Value);
            this.txtArt_SMin.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Min."].Value);
            this.txtArt_SMax.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Max."].Value);
            this.txtArt_SR.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Reposicion"].Value);
            this.txtArt_SA.Text = Convert.ToString(this.dgwArticulo.CurrentRow.Cells["Stock Actual"].Value);
            if (Convert.ToBoolean(this.dgwArticulo.CurrentRow.Cells["Maneja Stock"].Value))
            {
                this.rbYes.Checked = Convert.ToBoolean(this.dgwArticulo.CurrentRow.Cells["Maneja Stock"].Value);
            }
            else
            {
                this.rbNo.Checked = Convert.ToBoolean(this.dgwArticulo.CurrentRow.Cells["Maneja Stock"].Value);
            }

            this.tabControl1.SelectedIndex = 1;
            this.IsNuevo = false;
            ActivateButtons();
        }
        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwArticulo.Columns[0].Visible = true;
            }
            else
            {
                this.dgwArticulo.Columns[0].Visible = false;
            }
        }

        //Eventos de los campos Costo y Margen Beneficio
        private void ValidateDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateFieldDecimal(sender, e);
        }
        private void ValidateLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateFieldLetters(sender, e);
        }
        
        private void txtArt_Costo_Leave(object sender, EventArgs e)
        {
            CalculatePrice(sender);
        }
        private void txtArt_MB_Leave(object sender, EventArgs e)
        {
            if (txtArt_MB.Text.Trim() != "" && (Convert.ToDecimal(txtArt_MB.Text.Trim()) >= 100))
            {
                errorIcono.SetError(txtArt_MB, "Valor inválido (0-99,99)");
                txtArt_MB.SelectAll();
                txtArt_MB.Focus();
            }
            else CalculatePrice(sender);
        }
        private void txtArt_SMax_Leave(object sender, EventArgs e)
        {
            if (txtArt_SMax.Text.Trim() != "" && (Convert.ToDecimal(txtArt_SMax.Text.Trim()) < Convert.ToDecimal(txtArt_SMin.Text.Trim())))
            {
                errorIcono.SetError(txtArt_SMax, "El valor debe ser mayor que Min");
                txtArt_SMax.SelectAll();
                txtArt_SMax.Focus();
            }
        }
        private void txtArt_Descrip_Leave(object sender, EventArgs e)
        {
            if (txtArt_Descrip.Text != "" && SearchField(txtArt_Descrip.Text.Trim(), "Descripcion", dgwArticulo))
            {
                errorIcono.SetError(txtArt_Descrip, "Usuario en Uso");
                txtArt_Descrip.SelectAll();
                txtArt_Descrip.Focus();
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
        private void FrmArticulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            FrmFamilia vista = new FrmFamilia();
            vista.ShowDialog();
            if (btnNewArt.Enabled == false) LoadFamily();
        }
    }
}
