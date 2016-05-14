namespace Vistas
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSearchUsr = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnDeleteUsr = new System.Windows.Forms.Button();
            this.btnSearchUsr = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.txtUsr_Pass = new System.Windows.Forms.TextBox();
            this.lblUsr_Pass = new System.Windows.Forms.Label();
            this.txtUsr_UsrName = new System.Windows.Forms.TextBox();
            this.lblUsr_UsrName = new System.Windows.Forms.Label();
            this.lblRol_ID = new System.Windows.Forms.Label();
            this.txtUsr_Mail = new System.Windows.Forms.TextBox();
            this.lblUsr_Mail = new System.Windows.Forms.Label();
            this.cmbRol_ID = new System.Windows.Forms.ComboBox();
            this.txtUsr_Ape = new System.Windows.Forms.TextBox();
            this.lblUsr_Ape = new System.Windows.Forms.Label();
            this.txtUsr_Nom = new System.Windows.Forms.TextBox();
            this.txtUsr_ID = new System.Windows.Forms.TextBox();
            this.lblUsr_Nom = new System.Windows.Forms.Label();
            this.lblUsr_ID = new System.Windows.Forms.Label();
            this.btnCancelUsr = new System.Windows.Forms.Button();
            this.btnEditUsr = new System.Windows.Forms.Button();
            this.btnSaveUsr = new System.Windows.Forms.Button();
            this.btnNewUsr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.lnkMinimized = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(495, 67);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = " ";
            // 
            // txtSearchUsr
            // 
            this.txtSearchUsr.Location = new System.Drawing.Point(146, 29);
            this.txtSearchUsr.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUsr.Name = "txtSearchUsr";
            this.txtSearchUsr.Size = new System.Drawing.Size(169, 20);
            this.txtSearchUsr.TabIndex = 0;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.AllowUserToAddRows = false;
            this.dgwUsuarios.AllowUserToDeleteRows = false;
            this.dgwUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwUsuarios.ColumnHeadersHeight = 30;
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgwUsuarios.Location = new System.Drawing.Point(18, 87);
            this.dgwUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgwUsuarios.MultiSelect = false;
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.ReadOnly = true;
            this.dgwUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwUsuarios.RowHeadersVisible = false;
            this.dgwUsuarios.RowTemplate.Height = 24;
            this.dgwUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUsuarios.Size = new System.Drawing.Size(590, 215);
            this.dgwUsuarios.TabIndex = 3;
            this.dgwUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuarios_CellContentClick);
            this.dgwUsuarios.DoubleClick += new System.EventHandler(this.dgwUsuarios_DoubleClick);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(10, 64);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(62, 17);
            this.chkDelete.TabIndex = 2;
            this.chkDelete.Text = "Eliminar";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(50, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.lblAviso);
            this.tabPage1.Controls.Add(this.dgwUsuarios);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkDelete);
            this.tabPage1.Controls.Add(this.btnDeleteUsr);
            this.tabPage1.Controls.Add(this.btnSearchUsr);
            this.tabPage1.Controls.Add(this.txtSearchUsr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(632, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(24, 31);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(117, 13);
            this.lblAviso.TabIndex = 7;
            this.lblAviso.Text = "Busca Apellido-Nombre";
            // 
            // btnDeleteUsr
            // 
            this.btnDeleteUsr.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteUsr.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnDeleteUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsr.ForeColor = System.Drawing.Color.Ivory;
            this.btnDeleteUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUsr.Location = new System.Drawing.Point(455, 24);
            this.btnDeleteUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUsr.Name = "btnDeleteUsr";
            this.btnDeleteUsr.Size = new System.Drawing.Size(81, 28);
            this.btnDeleteUsr.TabIndex = 4;
            this.btnDeleteUsr.Text = "&Eliminar";
            this.btnDeleteUsr.UseVisualStyleBackColor = false;
            this.btnDeleteUsr.Click += new System.EventHandler(this.btnDeleteUsr_Click);
            this.btnDeleteUsr.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnDeleteUsr.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnSearchUsr
            // 
            this.btnSearchUsr.BackColor = System.Drawing.Color.Silver;
            this.btnSearchUsr.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnSearchUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUsr.ForeColor = System.Drawing.Color.Ivory;
            this.btnSearchUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchUsr.Location = new System.Drawing.Point(356, 24);
            this.btnSearchUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchUsr.Name = "btnSearchUsr";
            this.btnSearchUsr.Size = new System.Drawing.Size(81, 28);
            this.btnSearchUsr.TabIndex = 1;
            this.btnSearchUsr.Text = "&Buscar";
            this.btnSearchUsr.UseVisualStyleBackColor = false;
            this.btnSearchUsr.Click += new System.EventHandler(this.btnSearchUsr_Click);
            this.btnSearchUsr.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnSearchUsr.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Ivory;
            this.tabPage2.Controls.Add(this.gbUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(632, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.txtUsr_Pass);
            this.gbUsers.Controls.Add(this.lblUsr_Pass);
            this.gbUsers.Controls.Add(this.txtUsr_UsrName);
            this.gbUsers.Controls.Add(this.lblUsr_UsrName);
            this.gbUsers.Controls.Add(this.lblRol_ID);
            this.gbUsers.Controls.Add(this.txtUsr_Mail);
            this.gbUsers.Controls.Add(this.lblUsr_Mail);
            this.gbUsers.Controls.Add(this.cmbRol_ID);
            this.gbUsers.Controls.Add(this.txtUsr_Ape);
            this.gbUsers.Controls.Add(this.lblUsr_Ape);
            this.gbUsers.Controls.Add(this.txtUsr_Nom);
            this.gbUsers.Controls.Add(this.txtUsr_ID);
            this.gbUsers.Controls.Add(this.lblUsr_Nom);
            this.gbUsers.Controls.Add(this.lblUsr_ID);
            this.gbUsers.Controls.Add(this.btnCancelUsr);
            this.gbUsers.Controls.Add(this.btnEditUsr);
            this.gbUsers.Controls.Add(this.btnSaveUsr);
            this.gbUsers.Controls.Add(this.btnNewUsr);
            this.gbUsers.Location = new System.Drawing.Point(10, 17);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(2);
            this.gbUsers.Size = new System.Drawing.Size(596, 297);
            this.gbUsers.TabIndex = 0;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Usuarios";
            // 
            // txtUsr_Pass
            // 
            this.txtUsr_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsr_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsr_Pass.Location = new System.Drawing.Point(455, 171);
            this.txtUsr_Pass.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsr_Pass.Name = "txtUsr_Pass";
            this.txtUsr_Pass.Size = new System.Drawing.Size(95, 20);
            this.txtUsr_Pass.TabIndex = 5;
            this.txtUsr_Pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClearError_KeyPress);
            this.txtUsr_Pass.Leave += new System.EventHandler(this.txtUsr_Pass_Leave);
            // 
            // lblUsr_Pass
            // 
            this.lblUsr_Pass.AutoSize = true;
            this.lblUsr_Pass.Location = new System.Drawing.Point(395, 174);
            this.lblUsr_Pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsr_Pass.Name = "lblUsr_Pass";
            this.lblUsr_Pass.Size = new System.Drawing.Size(56, 13);
            this.lblUsr_Pass.TabIndex = 50;
            this.lblUsr_Pass.Text = "Password:";
            // 
            // txtUsr_UsrName
            // 
            this.txtUsr_UsrName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsr_UsrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsr_UsrName.Location = new System.Drawing.Point(259, 172);
            this.txtUsr_UsrName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsr_UsrName.Name = "txtUsr_UsrName";
            this.txtUsr_UsrName.Size = new System.Drawing.Size(95, 20);
            this.txtUsr_UsrName.TabIndex = 4;
            this.txtUsr_UsrName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClearError_KeyPress);
            this.txtUsr_UsrName.Leave += new System.EventHandler(this.txtUsr_UsrName_Leave);
            // 
            // lblUsr_UsrName
            // 
            this.lblUsr_UsrName.AutoSize = true;
            this.lblUsr_UsrName.Location = new System.Drawing.Point(213, 174);
            this.lblUsr_UsrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsr_UsrName.Name = "lblUsr_UsrName";
            this.lblUsr_UsrName.Size = new System.Drawing.Size(46, 13);
            this.lblUsr_UsrName.TabIndex = 48;
            this.lblUsr_UsrName.Text = "Usuario:";
            // 
            // lblRol_ID
            // 
            this.lblRol_ID.AutoSize = true;
            this.lblRol_ID.Location = new System.Drawing.Point(38, 174);
            this.lblRol_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol_ID.Name = "lblRol_ID";
            this.lblRol_ID.Size = new System.Drawing.Size(29, 13);
            this.lblRol_ID.TabIndex = 47;
            this.lblRol_ID.Text = "Rol: ";
            // 
            // txtUsr_Mail
            // 
            this.txtUsr_Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsr_Mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsr_Mail.Location = new System.Drawing.Point(77, 120);
            this.txtUsr_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsr_Mail.Name = "txtUsr_Mail";
            this.txtUsr_Mail.Size = new System.Drawing.Size(204, 20);
            this.txtUsr_Mail.TabIndex = 2;
            this.txtUsr_Mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsr_Mail_KeyPress);
            this.txtUsr_Mail.Leave += new System.EventHandler(this.txtUsr_Mail_Leave);
            // 
            // lblUsr_Mail
            // 
            this.lblUsr_Mail.AutoSize = true;
            this.lblUsr_Mail.Location = new System.Drawing.Point(38, 122);
            this.lblUsr_Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsr_Mail.Name = "lblUsr_Mail";
            this.lblUsr_Mail.Size = new System.Drawing.Size(35, 13);
            this.lblUsr_Mail.TabIndex = 45;
            this.lblUsr_Mail.Text = "Email:";
            // 
            // cmbRol_ID
            // 
            this.cmbRol_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmbRol_ID.FormattingEnabled = true;
            this.cmbRol_ID.Location = new System.Drawing.Point(71, 170);
            this.cmbRol_ID.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRol_ID.Name = "cmbRol_ID";
            this.cmbRol_ID.Size = new System.Drawing.Size(138, 21);
            this.cmbRol_ID.TabIndex = 3;
            // 
            // txtUsr_Ape
            // 
            this.txtUsr_Ape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsr_Ape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsr_Ape.Location = new System.Drawing.Point(370, 75);
            this.txtUsr_Ape.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsr_Ape.Name = "txtUsr_Ape";
            this.txtUsr_Ape.Size = new System.Drawing.Size(204, 20);
            this.txtUsr_Ape.TabIndex = 1;
            this.txtUsr_Ape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateLetters_KeyPress);
            // 
            // lblUsr_Ape
            // 
            this.lblUsr_Ape.AutoSize = true;
            this.lblUsr_Ape.Location = new System.Drawing.Point(314, 77);
            this.lblUsr_Ape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsr_Ape.Name = "lblUsr_Ape";
            this.lblUsr_Ape.Size = new System.Drawing.Size(52, 13);
            this.lblUsr_Ape.TabIndex = 34;
            this.lblUsr_Ape.Text = "Apellidos:";
            // 
            // txtUsr_Nom
            // 
            this.txtUsr_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsr_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsr_Nom.Location = new System.Drawing.Point(89, 75);
            this.txtUsr_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsr_Nom.Name = "txtUsr_Nom";
            this.txtUsr_Nom.Size = new System.Drawing.Size(192, 20);
            this.txtUsr_Nom.TabIndex = 0;
            this.txtUsr_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateLetters_KeyPress);
            // 
            // txtUsr_ID
            // 
            this.txtUsr_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtUsr_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsr_ID.Location = new System.Drawing.Point(89, 39);
            this.txtUsr_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsr_ID.Name = "txtUsr_ID";
            this.txtUsr_ID.ReadOnly = true;
            this.txtUsr_ID.Size = new System.Drawing.Size(94, 20);
            this.txtUsr_ID.TabIndex = 0;
            this.txtUsr_ID.Visible = false;
            // 
            // lblUsr_Nom
            // 
            this.lblUsr_Nom.AutoSize = true;
            this.lblUsr_Nom.Location = new System.Drawing.Point(38, 77);
            this.lblUsr_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsr_Nom.Name = "lblUsr_Nom";
            this.lblUsr_Nom.Size = new System.Drawing.Size(47, 13);
            this.lblUsr_Nom.TabIndex = 29;
            this.lblUsr_Nom.Text = "Nombre:";
            // 
            // lblUsr_ID
            // 
            this.lblUsr_ID.AutoSize = true;
            this.lblUsr_ID.Location = new System.Drawing.Point(38, 41);
            this.lblUsr_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsr_ID.Name = "lblUsr_ID";
            this.lblUsr_ID.Size = new System.Drawing.Size(43, 13);
            this.lblUsr_ID.TabIndex = 28;
            this.lblUsr_ID.Text = "Código:";
            this.lblUsr_ID.Visible = false;
            // 
            // btnCancelUsr
            // 
            this.btnCancelUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelUsr.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnCancelUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUsr.ForeColor = System.Drawing.Color.Ivory;
            this.btnCancelUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelUsr.Location = new System.Drawing.Point(407, 223);
            this.btnCancelUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelUsr.Name = "btnCancelUsr";
            this.btnCancelUsr.Size = new System.Drawing.Size(80, 28);
            this.btnCancelUsr.TabIndex = 9;
            this.btnCancelUsr.Text = "&Cancelar";
            this.btnCancelUsr.UseVisualStyleBackColor = false;
            this.btnCancelUsr.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnCancelUsr.Click += new System.EventHandler(this.btnCancelUsr_Click);
            this.btnCancelUsr.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnCancelUsr.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnEditUsr
            // 
            this.btnEditUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditUsr.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnEditUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUsr.ForeColor = System.Drawing.Color.Ivory;
            this.btnEditUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUsr.Location = new System.Drawing.Point(305, 223);
            this.btnEditUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditUsr.Name = "btnEditUsr";
            this.btnEditUsr.Size = new System.Drawing.Size(80, 28);
            this.btnEditUsr.TabIndex = 8;
            this.btnEditUsr.Text = "E&ditar";
            this.btnEditUsr.UseVisualStyleBackColor = false;
            this.btnEditUsr.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnEditUsr.Click += new System.EventHandler(this.btnEditUsr_Click);
            this.btnEditUsr.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnEditUsr.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnSaveUsr
            // 
            this.btnSaveUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveUsr.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnSaveUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUsr.ForeColor = System.Drawing.Color.Ivory;
            this.btnSaveUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUsr.Location = new System.Drawing.Point(208, 223);
            this.btnSaveUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveUsr.Name = "btnSaveUsr";
            this.btnSaveUsr.Size = new System.Drawing.Size(80, 28);
            this.btnSaveUsr.TabIndex = 7;
            this.btnSaveUsr.Text = "&Guardar";
            this.btnSaveUsr.UseVisualStyleBackColor = false;
            this.btnSaveUsr.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnSaveUsr.Click += new System.EventHandler(this.btnSaveUsr_Click);
            this.btnSaveUsr.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnSaveUsr.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnNewUsr
            // 
            this.btnNewUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewUsr.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnNewUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewUsr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUsr.ForeColor = System.Drawing.Color.Ivory;
            this.btnNewUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUsr.Location = new System.Drawing.Point(112, 223);
            this.btnNewUsr.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewUsr.Name = "btnNewUsr";
            this.btnNewUsr.Size = new System.Drawing.Size(80, 28);
            this.btnNewUsr.TabIndex = 6;
            this.btnNewUsr.Text = "&Nuevo";
            this.btnNewUsr.UseVisualStyleBackColor = false;
            this.btnNewUsr.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnNewUsr.Click += new System.EventHandler(this.btnNewUsr_Click);
            this.btnNewUsr.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnNewUsr.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuarios";
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorIcono.ContainerControl = this;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkClose.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lnkClose.Location = new System.Drawing.Point(720, 9);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(18, 17);
            this.lnkClose.TabIndex = 2;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "X";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // lnkMinimized
            // 
            this.lnkMinimized.AutoSize = true;
            this.lnkMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMinimized.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkMinimized.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lnkMinimized.Location = new System.Drawing.Point(700, 9);
            this.lnkMinimized.Name = "lnkMinimized";
            this.lnkMinimized.Size = new System.Drawing.Size(14, 17);
            this.lnkMinimized.TabIndex = 1;
            this.lnkMinimized.TabStop = true;
            this.lnkMinimized.Text = "-";
            this.lnkMinimized.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMinimized_LinkClicked);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.lnkMinimized);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: Panel de Usuarios ::..";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmUsuario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSearchUsr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnDeleteUsr;
        private System.Windows.Forms.Button btnSearchUsr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.Button btnCancelUsr;
        private System.Windows.Forms.Button btnEditUsr;
        private System.Windows.Forms.Button btnSaveUsr;
        private System.Windows.Forms.Button btnNewUsr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblUsr_Pass;
        private System.Windows.Forms.TextBox txtUsr_UsrName;
        private System.Windows.Forms.Label lblUsr_UsrName;
        private System.Windows.Forms.Label lblRol_ID;
        private System.Windows.Forms.TextBox txtUsr_Mail;
        private System.Windows.Forms.Label lblUsr_Mail;
        private System.Windows.Forms.ComboBox cmbRol_ID;
        private System.Windows.Forms.TextBox txtUsr_Ape;
        private System.Windows.Forms.Label lblUsr_Ape;
        private System.Windows.Forms.TextBox txtUsr_Nom;
        private System.Windows.Forms.TextBox txtUsr_ID;
        private System.Windows.Forms.Label lblUsr_Nom;
        private System.Windows.Forms.Label lblUsr_ID;
        private System.Windows.Forms.TextBox txtUsr_Pass;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.LinkLabel lnkMinimized;
    }
}