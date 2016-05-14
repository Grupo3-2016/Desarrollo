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
using System.Text.RegularExpressions;

namespace Vistas
{
    public partial class FrmUsuario : Form
    {
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsEditar = false;
        //Variables utilizadas para informar el movimiento del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private static FrmUsuario _instancia;

        //Obtenemos la instancia del Form Activarlo(Traerlo a primer plano) o Cerrado(Null)
        public static FrmUsuario GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmUsuario();
            }
            else
            {
                _instancia.Activate();
                if (_instancia.WindowState == FormWindowState.Minimized) _instancia.WindowState = FormWindowState.Normal;
            }
            return _instancia;
        }
        private void FrmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        public FrmUsuario()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            UsersList();
            this.BackColor = Color.FromArgb(100, Color.Ivory);
            this.EnableFields(false);
            this.ActiveBottons();
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
        private void ActiveBottons()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.EnableFields(true);
                this.btnNewUsr.Enabled = false;
                this.btnSaveUsr.Enabled = true;
                this.btnEditUsr.Enabled = false;
                this.btnCancelUsr.Enabled = true;
            }
            else
            {
                this.EnableFields(false);
                this.btnNewUsr.Enabled = true;
                this.btnSaveUsr.Enabled = false;
                this.btnEditUsr.Enabled = true;
                this.btnCancelUsr.Enabled = false;
            }
        }
        private void ClearFields()
        {
            this.txtUsr_ID.Text = string.Empty;
            this.txtUsr_Nom.Text = string.Empty;
            this.txtUsr_Ape.Text = string.Empty;
            this.txtUsr_Mail.Text = string.Empty;
            this.txtUsr_UsrName.Text = string.Empty;
            this.txtUsr_Pass.Text = string.Empty;
            this.cmbRol_ID.DataSource = null;
        }
        private void EnableFields(bool Valor)
        {
            this.txtUsr_Nom.ReadOnly = !Valor;
            this.txtUsr_Ape.ReadOnly = !Valor;
            this.txtUsr_Mail.ReadOnly = !Valor;
            this.txtUsr_UsrName.ReadOnly = !Valor;
            this.txtUsr_Pass.ReadOnly = !Valor;
            this.cmbRol_ID.Enabled = Valor;
        }
        private void HideColumns()
        {
            this.dgwUsuarios.Columns[0].Visible = false;
            this.dgwUsuarios.Columns[1].Visible = false;
        }
        private void HighLoadRole()
        {
            DataTable rolNuevo = TrabajarUsuario.ViewRol();
            DataRow row = rolNuevo.NewRow();
            row["rol_id"] = 0;
            row["rol_descrip"] = "<Seleccione valor...>";
            rolNuevo.Rows.InsertAt(row, 0);
            cmbRol_ID.DisplayMember = "rol_descrip";
            cmbRol_ID.ValueMember = "rol_id";
            cmbRol_ID.DataSource = rolNuevo;
        }
        private void LoadRole()
        {
            cmbRol_ID.DisplayMember = "rol_descrip";
            cmbRol_ID.ValueMember = "rol_id";
            cmbRol_ID.DataSource = TrabajarUsuario.ViewRol();
        }
        private void UsersList()
        {
            this.dgwUsuarios.DataSource = TrabajarUsuario.ViewUser();
            this.HideColumns();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwUsuarios.Rows.Count);
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
            Boolean bValid = true;
            errorIcono.Clear();

            if (this.txtUsr_Nom.Text == string.Empty)
            {
                errorIcono.SetError(txtUsr_Nom, "Ingrese un Valor");
                bValid = false;
            }
            if (this.txtUsr_Ape.Text == string.Empty)
            {
                bValid = false;
                errorIcono.SetError(txtUsr_Ape, "Ingrese un Valor");
            }
            if (txtUsr_Mail.Text == string.Empty)
            {
                bValid = false;
                errorIcono.SetError(txtUsr_Mail, "Ingrese un Valor");
            }
            if (txtUsr_UsrName.Text == string.Empty)
            {
                bValid = false;
                errorIcono.SetError(txtUsr_UsrName, "Ingrese un Valor");
            }
            if (txtUsr_Pass.Text == string.Empty)
            {
                bValid = false;
                errorIcono.SetError(txtUsr_Pass, "Ingrese un Valor");
            }
            if ((int)cmbRol_ID.SelectedValue == 0)
            {
                errorIcono.SetError(cmbRol_ID, "Seleccione un Valor");
                bValid = false;
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
        private void btnSaveUsr_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (ValidateFields())
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un Trabajador 
                        Rpta = TrabajarUsuario.InsertUser(Convert.ToInt32(cmbRol_ID.SelectedValue), this.txtUsr_Ape.Text.Trim(), this.txtUsr_Nom.Text.Trim(),
                            txtUsr_UsrName.Text, txtUsr_Pass.Text, txtUsr_Mail.Text);
                    }
                    else
                    {
                        //Vamos a modificar un Trabajador
                        Rpta = TrabajarUsuario.EditUser(Convert.ToInt32(this.txtUsr_ID.Text), this.txtUsr_Ape.Text.Trim(), this.txtUsr_Nom.Text.Trim(),
                            txtUsr_UsrName.Text, txtUsr_Pass.Text, txtUsr_Mail.Text, Convert.ToInt32(cmbRol_ID.SelectedValue));
                    }
                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.ActiveBottons();
                    this.ClearFields();
                    this.UsersList();
                    this.txtUsr_ID.Text = "";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnNewUsr_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.ActiveBottons();
            this.ClearFields();
            this.EnableFields(true);
            this.HighLoadRole();
            this.txtUsr_Nom.Focus();
        }
        private void btnEditUsr_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un producto no puede modificar
            if (!this.txtUsr_ID.Text.Equals(""))
            {
                string sNombreRol=cmbRol_ID.Text;
                this.IsEditar = true;
                this.ActiveBottons();
                this.LoadRole();
                this.cmbRol_ID.Text = sNombreRol;
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }
        private void btnCancelUsr_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.ActiveBottons();
            this.ClearFields();
            this.txtUsr_ID.Text = string.Empty;
        }
        
        //Botones de la sección de Listado
        private void btnSearchUsr_Click(object sender, EventArgs e)
        {
            if (txtSearchUsr.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.SearchUser(txtSearchUsr.Text);
                HideColumns();
            }
            else
            {
                UsersList();
            }
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwUsuarios.Rows.Count);
        }
        private void btnDeleteUsr_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value)){
                            if (Usuario.LastAdmin() == false || row.Cells[2].Value.ToString()!="Administrador"){
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                Rpta = TrabajarUsuario.DeleteUser(Convert.ToInt32(Codigo));

                                if (Rpta.Equals("OK")){
                                    this.MensajeOK("Se Eliminó Correctamente el registro");
                                }else{
                                    this.MensajeError(Rpta);
                                }
                            }else{
                                MessageBox.Show("No se puede eliminar al ultimo Administrador.");
                            }
                        }
                    }
                    this.UsersList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwUsuarios.Columns[0].Visible = true;
            }
            else
            {
                this.dgwUsuarios.Columns[0].Visible = false;
            }
        }
        // Eventos del DataGridView de Usuarios
        private void dgwUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.txtUsr_ID.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["usr_id"].Value);
            this.txtUsr_Nom.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Nombre"].Value);
            this.txtUsr_Ape.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Apellido"].Value);
            this.txtUsr_Mail.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Email"].Value);
            this.txtUsr_UsrName.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Usuario"].Value);
            this.txtUsr_Pass.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Contraseña"].Value);
            this.cmbRol_ID.Text = Convert.ToString(this.dgwUsuarios.CurrentRow.Cells["Rol"].Value);
            
            this.tabControl1.SelectedIndex = 1;
            this.IsNuevo = false;
            ActiveBottons();
        }
        private void dgwUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwUsuarios.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dgwUsuarios.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
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
        private void FrmUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Validación de Campos en tiempo de ejecución
        private void ValidateLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateFieldLetters(sender, e);
        }
        private void txtUsr_Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcono.Clear();
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.') e.Handled = false;
            else
            {
                e.Handled = true;
                errorIcono.SetError(((TextBox)sender), "Caracter Inválido");
            }
        }
        private void ClearError_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorIcono.Clear();
        }
        private void txtUsr_Mail_Leave(object sender, EventArgs e)
        {
            btnSaveUsr.Enabled = true;
            if (txtUsr_Mail.Text.Trim() != "")
            {
                if (ValidateMail(txtUsr_Mail.Text) == false)
                {
                    errorIcono.SetError(txtUsr_Mail, "ej: example@example.com");
                    txtUsr_Mail.SelectAll();
                    txtUsr_Mail.Focus();
                    btnSaveUsr.Enabled = false;
                }
                else if (SearchField(txtUsr_Mail.Text.Trim(), "Email", dgwUsuarios))
                {
                    errorIcono.SetError(txtUsr_Mail, "Correo en Uso");
                    txtUsr_Mail.SelectAll();
                    txtUsr_Mail.Focus();
                    btnSaveUsr.Enabled = false;
                }
            }
        }
        private void txtUsr_UsrName_Leave(object sender, EventArgs e)
        {
            btnSaveUsr.Enabled = true;
            if (txtUsr_UsrName.Text !="" && txtUsr_UsrName.Text.Trim().Length < 4)
            {
                errorIcono.SetError(txtUsr_UsrName, "Debe tener más de 4 digitos");
                txtUsr_UsrName.SelectAll();
                txtUsr_UsrName.Focus();
                btnSaveUsr.Enabled = false;
            }
            else
            {
                if (txtUsr_UsrName.Text != "" && SearchField(txtUsr_UsrName.Text.Trim(), "Usuario", dgwUsuarios))
                {
                    errorIcono.SetError(txtUsr_UsrName, "Usuario en Uso");
                    txtUsr_UsrName.SelectAll();
                    txtUsr_UsrName.Focus();
                    btnSaveUsr.Enabled = false;
                }
            }
        }
        private void txtUsr_Pass_Leave(object sender, EventArgs e)
        {
            if (txtUsr_Pass.Text != "" && txtUsr_Pass.Text.Trim().Length < 4)
            {
                errorIcono.SetError(txtUsr_Pass, "Debe tener más de 4 digitos");
                txtUsr_Pass.SelectAll();
                txtUsr_Pass.Focus();
            }
        }
    }
}