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
    public partial class FrmFamilia : Form
    {
        //Variable que nos indica si vamos a insertar un nuevo producto
        private bool IsNuevo = false;
        //Variable que nos indica si vamos a modificar un producto
        private bool IsEditar = false;

        public FrmFamilia()
        {
            InitializeComponent();
        }
        private void FrmFamilia_Load(object sender, EventArgs e)
        {
            FamilyList();
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
                this.btnNewFam.Enabled = false;
                this.btnSaveFam.Enabled = true;
                this.btnEditFam.Enabled = false;
                this.btnCancelFam.Enabled = true;
            }
            else
            {
                this.EnableFields(false);
                this.btnNewFam.Enabled = true;
                this.btnSaveFam.Enabled = false;
                this.btnEditFam.Enabled = true;
                this.btnCancelFam.Enabled = false;
            }
        }
        private void ClearFields()
        {
            this.txtFam_ID.Text = string.Empty;
            this.txtFam_Descrip.Text = string.Empty;
        }
        private void EnableFields(bool Valor)
        {
            this.txtFam_Descrip.ReadOnly = !Valor;
        }
        private void HideColumns()
        {
            this.dgwFamilia.Columns[0].Visible = false;
        }
        private void FamilyList()
        {
            this.dgwFamilia.DataSource = TrabajarFamilia.ViewFamilia();
            this.HideColumns();
            lblTotal.Text = "Total Registros: " + Convert.ToString(dgwFamilia.Rows.Count);
        }
        private Boolean ValidateFields()
        {
            Boolean bValid = true;
            errorIconos.Clear();

            if (this.txtFam_Descrip.Text == string.Empty)
            {
                errorIconos.SetError(txtFam_Descrip, "Ingrese un Valor");
                bValid = false;
            }
            if (!bValid)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
            }

            return bValid;
        }

        // Eventos del DataGridView
        private void dgwFamilia_DoubleClick(object sender, EventArgs e)
        {
            this.txtFam_ID.Text = Convert.ToString(this.dgwFamilia.CurrentRow.Cells["fam_id"].Value);
            this.txtFam_Descrip.Text = Convert.ToString(this.dgwFamilia.CurrentRow.Cells["fam_descrip"].Value);

            this.IsNuevo = false;
            ActiveBottons();
        }
        private void dgwFamilia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgwFamilia.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar =
                    (DataGridViewCheckBoxCell)dgwFamilia.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
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

        //Botones ABM
        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dgwFamilia.Columns[0].Visible = true;
            }
            else
            {
                this.dgwFamilia.Columns[0].Visible = false;
            }
        }
        private void btnDeleteFam_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgwFamilia.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = TrabajarProveedor.DeleteProvider(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.FamilyList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnNewFam_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.ActiveBottons();
            this.ClearFields();
            this.EnableFields(true);
            this.txtFam_Descrip.Focus();
        }
        private void btnSaveFam_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (ValidateFields())
                {
                    if (this.IsNuevo)
                    {
                        //Vamos a insertar un Trabajador 
                        Rpta = TrabajarFamilia.InsertFamily(this.txtFam_Descrip.Text.Trim());
                    }
                    else
                    {
                        //Vamos a modificar un Trabajador
                        Rpta = TrabajarFamilia.EditFamily(Convert.ToInt32(this.txtFam_ID.Text), this.txtFam_Descrip.Text.Trim());
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
                    this.FamilyList();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnEditFam_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un producto no puede modificar
            if (!this.txtFam_ID.Text.Equals(""))
            {
                this.IsEditar = true;
                this.ActiveBottons();
            }
            else
            {
                this.MensajeError("Debe de buscar un registro para Modificar");
            }
        }
        private void btnCancelFam_Click(object sender, EventArgs e)
        {
            errorIconos.Clear();
            this.IsNuevo = false;
            this.IsEditar = false;
            this.ActiveBottons();
            this.ClearFields();
        }

        private void lnkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
