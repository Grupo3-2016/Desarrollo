using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseConexion;
using System.Text.RegularExpressions;

namespace Vistas
{
    public partial class FrmProveedor : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmProveedor()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100,Color.Ivory);
            this.ProvidersList();
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
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.EnableFields(true);
                this.btnNewProv.Enabled = false;
                this.btnSaveProv.Enabled = true;
                this.btnEditProv.Enabled = false;
                this.btnCancelProv.Enabled = true;
            }
            else
            {
                this.EnableFields(false);
                this.btnNewProv.Enabled = true;
                this.btnSaveProv.Enabled = false;
                this.btnEditProv.Enabled = true;
                this.btnCancelProv.Enabled = false;
            }

        }
        private void ClearFields()
        {
            this.txtProv_Nom.Text = string.Empty;
            this.txtProv_Dep.Text = string.Empty;
            this.txtProv_Dom.Text = string.Empty;
            this.txtProv_Tel.Text = string.Empty;
            this.txtProv_CP.Text = string.Empty;
            this.txtProv_Mail.Text = string.Empty;
            this.txtProv_Id.Text = string.Empty;

        }
        private void EnableFields(bool valor)
        {
            this.txtProv_Nom.ReadOnly = !valor;
            this.txtProv_Dom.ReadOnly = !valor;
            this.txtProv_Dep.ReadOnly = !valor;
            this.txtProv_Tel.ReadOnly = !valor;
            this.txtProv_CP.ReadOnly = !valor;
            this.txtProv_Mail.ReadOnly = !valor;
        }
        private void HideColumns()
        {
            this.dgwProveedores.Columns[0].Visible = false;
            this.dgwProveedores.Columns[1].Visible = false;
        }
        private void ProvidersList()
        {
            this.dgwProveedores.DataSource = TrabajarProveedor.ViewProvider();
            this.HideColumns();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgwProveedores.Rows.Count);
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
        private void ValidateFieldText(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
                errorIcon.Clear();
            }
            else
            {
                e.Handled = true;
                errorIcon.SetError(((TextBox)sender), "Caracter Inválido");
            }
        }
        private void ValidateFieldNumber(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorIcon.Clear();
            }
            else
            {
                e.Handled = true;
                errorIcon.SetError(((TextBox)sender), "Solo permite números");
            }
        }
        private Boolean ValidateFields()
        {
            Boolean bValid = true;
            errorIcon.Clear();

            if (this.txtProv_Nom.Text == string.Empty)
            {
                errorIcon.SetError(txtProv_Nom, "Ingrese un Valor");
                bValid = false;
            }
            if (this.txtProv_CP.Text == string.Empty)
            {
                bValid = false;
                errorIcon.SetError(txtProv_CP, "Ingrese un Valor");
            }
            if (txtProv_Dom.Text == string.Empty)
            {
                bValid = false;
                errorIcon.SetError(txtProv_Dom, "Ingrese un Valor");
            }
            if (txtProv_Dep.Text == string.Empty)
            {
                bValid = false;
                errorIcon.SetError(txtProv_Dep, "Ingrese un Valor");
            }
            if (txtProv_Tel.Text == string.Empty)
            {
                bValid = false;
                errorIcon.SetError(txtProv_Tel, "Ingrese un Valor");
            }
            if (txtProv_Mail.Text == string.Empty)
            {
                bValid = false;
                errorIcon.SetError(txtProv_Mail, "Ingrese un Valor");
            }
            if (!bValid)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }

            return bValid;
        }
        private bool ValidateMail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }

        //Botones de la sección de Mantenimiento
        private void btnNewProv_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.ActivateButtons();
            this.ClearFields();
            this.EnableFields(true);
            this.txtProv_Nom.Focus();
        }
        private void btnSaveProv_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(ValidateFields())
                {
                    if (this.IsNuevo)
                    {
                        rpta = TrabajarProveedor.InsertProvider(txtProv_Nom.Text.Trim(),txtProv_Dom.Text, txtProv_Dep.Text,
                            txtProv_CP.Text, txtProv_Tel.Text, txtProv_Mail.Text);

                    }
                    else
                    {
                        rpta = TrabajarProveedor.EditProvider(Convert.ToInt32(this.txtProv_Id.Text),txtProv_Nom.Text.Trim(),
                            txtProv_Dom.Text, txtProv_Dep.Text,txtProv_CP.Text, txtProv_Tel.Text, txtProv_Mail.Text);
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
                    this.ProvidersList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnEditProv_Click(object sender, EventArgs e)
        {
            if (!this.txtProv_Id.Text.Equals(""))
            {
                this.IsEditar = true;
                this.ActivateButtons();
                this.EnableFields(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
        private void btnCancelProv_Click_1(object sender, EventArgs e)
        {
            errorIcon.Clear();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.ActivateButtons();
            this.ClearFields();
            this.txtProv_Id.Text = string.Empty;
        }

        //Botones de la sección de Listado
        private void btnSearchProv_Click(object sender, EventArgs e)
        {
            if (txtSearchProv.Text != "")
            {
                dgwProveedores.DataSource = TrabajarProveedor.SearchProvider(txtSearchProv.Text);
                HideColumns();
            }
            else
            {
                ProvidersList();
            }
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwProveedores.Rows.Count);
        }
        private void btnDeleteProv_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwProveedores.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = TrabajarProveedor.DeleteProvider(Convert.ToInt32(Codigo));

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
                    this.ProvidersList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnOrderProv_Click(object sender, EventArgs e)
        {
            txtSearchProv.Text = "";
            dgwProveedores.DataSource = TrabajarProveedor.OrderProvider();
            HideColumns();
        }
        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwProveedores.Columns[0].Visible = true;
            }
            else
            {
                this.dgwProveedores.Columns[0].Visible = false;
            }
        }

        // Eventos del DataGridView de Usuarios
        private void dgwProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwProveedores.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgwProveedores.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void dgwProveedores_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtProv_Id.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["prov_id"].Value);
                this.txtProv_Nom.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["Nombre"].Value);
                this.txtProv_CP.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["Codigo Postal"].Value);
                this.txtProv_Dep.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["Departamento"].Value);
                this.txtProv_Dom.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["Domicilio"].Value);
                this.txtProv_Tel.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["Telefono"].Value);
                this.txtProv_Mail.Text = Convert.ToString(this.dgwProveedores.CurrentRow.Cells["Email"].Value);

                this.tabControl1.SelectedIndex = 1;
                this.IsNuevo = false;
                ActivateButtons();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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

        //Validaciones de Campos
        private void ValidateField_Leave(object sender, EventArgs e)
        {
            string sColumna = "";
            if (((TextBox)sender).Name.Trim() == "txtProv_Nom") sColumna = "Nombre";
            if (((TextBox)sender).Name.Trim() == "txtProv_Dom") sColumna = "Domicilio"; 
            if (((TextBox)sender).Name.Trim() == "txtProv_Tel") sColumna = "Telefono";
            
            if (txtProv_Nom.Text.Trim() != "" && SearchField(((TextBox)sender).Text.Trim(), sColumna, dgwProveedores))
                {
                    errorIcon.SetError(((TextBox)sender), "Valor en Uso");
                    ((TextBox)sender).SelectAll();
                    ((TextBox)sender).Focus();
                }
        }
        private void txtProv_Mail_Leave(object sender, EventArgs e)
        {
            btnSaveProv.Enabled = true;
            if (txtProv_Mail.Text.Trim() != "")
            {
                if (ValidateMail(txtProv_Mail.Text) == false)
                {
                    errorIcon.SetError(txtProv_Mail, "ej: example@example.com");
                    btnSaveProv.Enabled = false;
                }
                else if (SearchField(txtProv_Mail.Text.Trim(), "Email", dgwProveedores))
                {
                    errorIcon.SetError(txtProv_Mail, "Correo en Uso");
                    btnSaveProv.Enabled = false;
                }
                txtProv_Mail.SelectAll();
                txtProv_Mail.Focus();
            }
        }
        private void txtProv_CP_Leave(object sender, EventArgs e)
        {
            btnSaveProv.Enabled = true;
            if (txtProv_CP.Text != "" && txtProv_CP.Text.Trim().Length < 4)
            {
                errorIcon.SetError(txtProv_CP, "Debe poseer más de 3 digitos");
                txtProv_CP.SelectAll();
                txtProv_CP.Focus();
                btnSaveProv.Enabled = false;
            }
        }

        private void txtProv_Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcon.Clear();
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.') e.Handled = false;
            else
            {
                e.Handled = true;
                errorIcon.SetError(((TextBox)sender), "Caracter Inválido");
            }
        }
        private void ValidateText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateFieldText(sender, e);
        }
        private void ValidateDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateFieldNumber(sender, e);
        }
    }
       
}
