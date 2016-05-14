namespace Vistas
{
    partial class FrmArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbArticulos = new System.Windows.Forms.GroupBox();
            this.txtArt_SR = new System.Windows.Forms.TextBox();
            this.txtArt_MB = new System.Windows.Forms.TextBox();
            this.txtArt_Costo = new System.Windows.Forms.TextBox();
            this.txtArt_Precio = new System.Windows.Forms.TextBox();
            this.txtArt_SA = new System.Windows.Forms.TextBox();
            this.lblArt_SR = new System.Windows.Forms.Label();
            this.lblArt_Precio = new System.Windows.Forms.Label();
            this.lblArt_SA = new System.Windows.Forms.Label();
            this.lblArt_MB = new System.Windows.Forms.Label();
            this.lblArt_Costo = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lblArt_Maneja = new System.Windows.Forms.Label();
            this.cbArt_Fam = new System.Windows.Forms.ComboBox();
            this.txtArt_SMax = new System.Windows.Forms.TextBox();
            this.txtArt_SMin = new System.Windows.Forms.TextBox();
            this.lblArt_SMax = new System.Windows.Forms.Label();
            this.lblArt_SMin = new System.Windows.Forms.Label();
            this.cbArt_UM = new System.Windows.Forms.ComboBox();
            this.lblArt_UM = new System.Windows.Forms.Label();
            this.lblArt_Fam = new System.Windows.Forms.Label();
            this.btnCancelArt = new System.Windows.Forms.Button();
            this.btnEditArt = new System.Windows.Forms.Button();
            this.btnSaveArt = new System.Windows.Forms.Button();
            this.btnNewArt = new System.Windows.Forms.Button();
            this.txtArt_Descrip = new System.Windows.Forms.TextBox();
            this.txtArt_ID = new System.Windows.Forms.TextBox();
            this.lblArt_Descrip = new System.Windows.Forms.Label();
            this.lblArt_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDescrip = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.btnOrderArt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwArticulo = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.btnDeleteArt = new System.Windows.Forms.Button();
            this.btnSearchArt = new System.Windows.Forms.Button();
            this.txtSearchArt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.lnkMinimized = new System.Windows.Forms.LinkLabel();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.gbArticulos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulo)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Ivory;
            this.tabPage2.Controls.Add(this.gbArticulos);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(632, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // gbArticulos
            // 
            this.gbArticulos.Controls.Add(this.txtArt_SR);
            this.gbArticulos.Controls.Add(this.txtArt_MB);
            this.gbArticulos.Controls.Add(this.txtArt_Costo);
            this.gbArticulos.Controls.Add(this.txtArt_Precio);
            this.gbArticulos.Controls.Add(this.txtArt_SA);
            this.gbArticulos.Controls.Add(this.lblArt_SR);
            this.gbArticulos.Controls.Add(this.lblArt_Precio);
            this.gbArticulos.Controls.Add(this.lblArt_SA);
            this.gbArticulos.Controls.Add(this.lblArt_MB);
            this.gbArticulos.Controls.Add(this.lblArt_Costo);
            this.gbArticulos.Controls.Add(this.rbNo);
            this.gbArticulos.Controls.Add(this.rbYes);
            this.gbArticulos.Controls.Add(this.lblArt_Maneja);
            this.gbArticulos.Controls.Add(this.cbArt_Fam);
            this.gbArticulos.Controls.Add(this.txtArt_SMax);
            this.gbArticulos.Controls.Add(this.txtArt_SMin);
            this.gbArticulos.Controls.Add(this.lblArt_SMax);
            this.gbArticulos.Controls.Add(this.lblArt_SMin);
            this.gbArticulos.Controls.Add(this.cbArt_UM);
            this.gbArticulos.Controls.Add(this.lblArt_UM);
            this.gbArticulos.Controls.Add(this.lblArt_Fam);
            this.gbArticulos.Controls.Add(this.btnCancelArt);
            this.gbArticulos.Controls.Add(this.btnEditArt);
            this.gbArticulos.Controls.Add(this.btnSaveArt);
            this.gbArticulos.Controls.Add(this.btnNewArt);
            this.gbArticulos.Controls.Add(this.txtArt_Descrip);
            this.gbArticulos.Controls.Add(this.txtArt_ID);
            this.gbArticulos.Controls.Add(this.lblArt_Descrip);
            this.gbArticulos.Controls.Add(this.lblArt_ID);
            this.gbArticulos.Location = new System.Drawing.Point(24, 17);
            this.gbArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.gbArticulos.Name = "gbArticulos";
            this.gbArticulos.Padding = new System.Windows.Forms.Padding(2);
            this.gbArticulos.Size = new System.Drawing.Size(584, 299);
            this.gbArticulos.TabIndex = 0;
            this.gbArticulos.TabStop = false;
            this.gbArticulos.Text = "Artículos";
            // 
            // txtArt_SR
            // 
            this.txtArt_SR.Location = new System.Drawing.Point(423, 212);
            this.txtArt_SR.Name = "txtArt_SR";
            this.txtArt_SR.Size = new System.Drawing.Size(100, 20);
            this.txtArt_SR.TabIndex = 10;
            this.txtArt_SR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal_KeyPress);
            // 
            // txtArt_MB
            // 
            this.txtArt_MB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_MB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_MB.Location = new System.Drawing.Point(272, 193);
            this.txtArt_MB.Name = "txtArt_MB";
            this.txtArt_MB.Size = new System.Drawing.Size(100, 20);
            this.txtArt_MB.TabIndex = 8;
            this.txtArt_MB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal_KeyPress);
            this.txtArt_MB.Leave += new System.EventHandler(this.txtArt_MB_Leave);
            // 
            // txtArt_Costo
            // 
            this.txtArt_Costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_Costo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_Costo.Location = new System.Drawing.Point(94, 193);
            this.txtArt_Costo.Name = "txtArt_Costo";
            this.txtArt_Costo.Size = new System.Drawing.Size(100, 20);
            this.txtArt_Costo.TabIndex = 7;
            this.txtArt_Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal_KeyPress);
            this.txtArt_Costo.Leave += new System.EventHandler(this.txtArt_Costo_Leave);
            // 
            // txtArt_Precio
            // 
            this.txtArt_Precio.Location = new System.Drawing.Point(94, 227);
            this.txtArt_Precio.Name = "txtArt_Precio";
            this.txtArt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txtArt_Precio.TabIndex = 35;
            // 
            // txtArt_SA
            // 
            this.txtArt_SA.Location = new System.Drawing.Point(303, 227);
            this.txtArt_SA.Name = "txtArt_SA";
            this.txtArt_SA.Size = new System.Drawing.Size(100, 20);
            this.txtArt_SA.TabIndex = 9;
            this.txtArt_SA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal_KeyPress);
            // 
            // lblArt_SR
            // 
            this.lblArt_SR.AutoSize = true;
            this.lblArt_SR.Location = new System.Drawing.Point(420, 196);
            this.lblArt_SR.Name = "lblArt_SR";
            this.lblArt_SR.Size = new System.Drawing.Size(94, 13);
            this.lblArt_SR.TabIndex = 33;
            this.lblArt_SR.Text = "Stock Reposición:";
            // 
            // lblArt_Precio
            // 
            this.lblArt_Precio.AutoSize = true;
            this.lblArt_Precio.Location = new System.Drawing.Point(41, 230);
            this.lblArt_Precio.Name = "lblArt_Precio";
            this.lblArt_Precio.Size = new System.Drawing.Size(40, 13);
            this.lblArt_Precio.TabIndex = 32;
            this.lblArt_Precio.Text = "Precio:";
            // 
            // lblArt_SA
            // 
            this.lblArt_SA.AutoSize = true;
            this.lblArt_SA.Location = new System.Drawing.Point(213, 230);
            this.lblArt_SA.Name = "lblArt_SA";
            this.lblArt_SA.Size = new System.Drawing.Size(71, 13);
            this.lblArt_SA.TabIndex = 31;
            this.lblArt_SA.Text = "Stock Actual:";
            // 
            // lblArt_MB
            // 
            this.lblArt_MB.AutoSize = true;
            this.lblArt_MB.Location = new System.Drawing.Point(213, 196);
            this.lblArt_MB.Name = "lblArt_MB";
            this.lblArt_MB.Size = new System.Drawing.Size(46, 13);
            this.lblArt_MB.TabIndex = 30;
            this.lblArt_MB.Text = "Margen:";
            // 
            // lblArt_Costo
            // 
            this.lblArt_Costo.AutoSize = true;
            this.lblArt_Costo.Location = new System.Drawing.Point(41, 196);
            this.lblArt_Costo.Name = "lblArt_Costo";
            this.lblArt_Costo.Size = new System.Drawing.Size(37, 13);
            this.lblArt_Costo.TabIndex = 29;
            this.lblArt_Costo.Text = "Costo:";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(158, 145);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 4;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(115, 145);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(34, 17);
            this.rbYes.TabIndex = 3;
            this.rbYes.Text = "Si";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // lblArt_Maneja
            // 
            this.lblArt_Maneja.AutoSize = true;
            this.lblArt_Maneja.Location = new System.Drawing.Point(9, 145);
            this.lblArt_Maneja.Name = "lblArt_Maneja";
            this.lblArt_Maneja.Size = new System.Drawing.Size(85, 13);
            this.lblArt_Maneja.TabIndex = 26;
            this.lblArt_Maneja.Text = "¿Maneja Stock?";
            // 
            // cbArt_Fam
            // 
            this.cbArt_Fam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbArt_Fam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArt_Fam.FormattingEnabled = true;
            this.cbArt_Fam.Items.AddRange(new object[] {
            "Seleccione Familia"});
            this.cbArt_Fam.Location = new System.Drawing.Point(408, 34);
            this.cbArt_Fam.Margin = new System.Windows.Forms.Padding(2);
            this.cbArt_Fam.Name = "cbArt_Fam";
            this.cbArt_Fam.Size = new System.Drawing.Size(115, 21);
            this.cbArt_Fam.TabIndex = 1;
            // 
            // txtArt_SMax
            // 
            this.txtArt_SMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_SMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_SMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt_SMax.Location = new System.Drawing.Point(408, 142);
            this.txtArt_SMax.Name = "txtArt_SMax";
            this.txtArt_SMax.Size = new System.Drawing.Size(100, 20);
            this.txtArt_SMax.TabIndex = 6;
            this.txtArt_SMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal_KeyPress);
            this.txtArt_SMax.Leave += new System.EventHandler(this.txtArt_SMax_Leave);
            // 
            // txtArt_SMin
            // 
            this.txtArt_SMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_SMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_SMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt_SMin.Location = new System.Drawing.Point(408, 106);
            this.txtArt_SMin.Name = "txtArt_SMin";
            this.txtArt_SMin.Size = new System.Drawing.Size(100, 20);
            this.txtArt_SMin.TabIndex = 5;
            this.txtArt_SMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDecimal_KeyPress);
            // 
            // lblArt_SMax
            // 
            this.lblArt_SMax.AutoSize = true;
            this.lblArt_SMax.Location = new System.Drawing.Point(333, 145);
            this.lblArt_SMax.Name = "lblArt_SMax";
            this.lblArt_SMax.Size = new System.Drawing.Size(61, 13);
            this.lblArt_SMax.TabIndex = 22;
            this.lblArt_SMax.Text = "Stock Max:";
            // 
            // lblArt_SMin
            // 
            this.lblArt_SMin.AutoSize = true;
            this.lblArt_SMin.Location = new System.Drawing.Point(333, 109);
            this.lblArt_SMin.Name = "lblArt_SMin";
            this.lblArt_SMin.Size = new System.Drawing.Size(58, 13);
            this.lblArt_SMin.TabIndex = 21;
            this.lblArt_SMin.Text = "Stock Min:";
            // 
            // cbArt_UM
            // 
            this.cbArt_UM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbArt_UM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArt_UM.FormattingEnabled = true;
            this.cbArt_UM.Location = new System.Drawing.Point(408, 72);
            this.cbArt_UM.Margin = new System.Windows.Forms.Padding(2);
            this.cbArt_UM.Name = "cbArt_UM";
            this.cbArt_UM.Size = new System.Drawing.Size(115, 21);
            this.cbArt_UM.TabIndex = 2;
            // 
            // lblArt_UM
            // 
            this.lblArt_UM.AutoSize = true;
            this.lblArt_UM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt_UM.Location = new System.Drawing.Point(333, 75);
            this.lblArt_UM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt_UM.Name = "lblArt_UM";
            this.lblArt_UM.Size = new System.Drawing.Size(45, 13);
            this.lblArt_UM.TabIndex = 19;
            this.lblArt_UM.Text = "Medida:";
            // 
            // lblArt_Fam
            // 
            this.lblArt_Fam.AutoSize = true;
            this.lblArt_Fam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt_Fam.Location = new System.Drawing.Point(333, 37);
            this.lblArt_Fam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt_Fam.Name = "lblArt_Fam";
            this.lblArt_Fam.Size = new System.Drawing.Size(42, 13);
            this.lblArt_Fam.TabIndex = 15;
            this.lblArt_Fam.Text = "Familia:";
            // 
            // btnCancelArt
            // 
            this.btnCancelArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnCancelArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnCancelArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelArt.Location = new System.Drawing.Point(383, 261);
            this.btnCancelArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelArt.Name = "btnCancelArt";
            this.btnCancelArt.Size = new System.Drawing.Size(80, 27);
            this.btnCancelArt.TabIndex = 14;
            this.btnCancelArt.Text = "&Cancelar";
            this.btnCancelArt.UseVisualStyleBackColor = false;
            this.btnCancelArt.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnCancelArt.Click += new System.EventHandler(this.btnCancelArt_Click);
            this.btnCancelArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnCancelArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnEditArt
            // 
            this.btnEditArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEditArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnEditArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnEditArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditArt.Location = new System.Drawing.Point(281, 261);
            this.btnEditArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditArt.Name = "btnEditArt";
            this.btnEditArt.Size = new System.Drawing.Size(80, 27);
            this.btnEditArt.TabIndex = 13;
            this.btnEditArt.Text = "E&ditar";
            this.btnEditArt.UseVisualStyleBackColor = false;
            this.btnEditArt.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnEditArt.Click += new System.EventHandler(this.btnEditArt_Click);
            this.btnEditArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnEditArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnSaveArt
            // 
            this.btnSaveArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnSaveArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnSaveArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveArt.Location = new System.Drawing.Point(186, 261);
            this.btnSaveArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveArt.Name = "btnSaveArt";
            this.btnSaveArt.Size = new System.Drawing.Size(80, 27);
            this.btnSaveArt.TabIndex = 12;
            this.btnSaveArt.Text = "&Guardar";
            this.btnSaveArt.UseVisualStyleBackColor = false;
            this.btnSaveArt.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnSaveArt.Click += new System.EventHandler(this.btnSaveArt_Click);
            this.btnSaveArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnSaveArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnNewArt
            // 
            this.btnNewArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnNewArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnNewArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewArt.Location = new System.Drawing.Point(88, 261);
            this.btnNewArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewArt.Name = "btnNewArt";
            this.btnNewArt.Size = new System.Drawing.Size(80, 26);
            this.btnNewArt.TabIndex = 11;
            this.btnNewArt.Text = "&Nuevo";
            this.btnNewArt.UseVisualStyleBackColor = false;
            this.btnNewArt.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnNewArt.Click += new System.EventHandler(this.btnNewArt_Click);
            this.btnNewArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnNewArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // txtArt_Descrip
            // 
            this.txtArt_Descrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_Descrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt_Descrip.Location = new System.Drawing.Point(88, 80);
            this.txtArt_Descrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtArt_Descrip.Multiline = true;
            this.txtArt_Descrip.Name = "txtArt_Descrip";
            this.txtArt_Descrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArt_Descrip.Size = new System.Drawing.Size(226, 43);
            this.txtArt_Descrip.TabIndex = 0;
            this.txtArt_Descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateLetters_KeyPress);
            this.txtArt_Descrip.Leave += new System.EventHandler(this.txtArt_Descrip_Leave);
            // 
            // txtArt_ID
            // 
            this.txtArt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt_ID.Location = new System.Drawing.Point(88, 35);
            this.txtArt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtArt_ID.Name = "txtArt_ID";
            this.txtArt_ID.Size = new System.Drawing.Size(61, 20);
            this.txtArt_ID.TabIndex = 3;
            this.txtArt_ID.Visible = false;
            // 
            // lblArt_Descrip
            // 
            this.lblArt_Descrip.AutoSize = true;
            this.lblArt_Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt_Descrip.Location = new System.Drawing.Point(6, 82);
            this.lblArt_Descrip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt_Descrip.Name = "lblArt_Descrip";
            this.lblArt_Descrip.Size = new System.Drawing.Size(66, 13);
            this.lblArt_Descrip.TabIndex = 2;
            this.lblArt_Descrip.Text = "Descripción:";
            // 
            // lblArt_ID
            // 
            this.lblArt_ID.AutoSize = true;
            this.lblArt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt_ID.Location = new System.Drawing.Point(6, 37);
            this.lblArt_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArt_ID.Name = "lblArt_ID";
            this.lblArt_ID.Size = new System.Drawing.Size(43, 13);
            this.lblArt_ID.TabIndex = 0;
            this.lblArt_ID.Text = "Código:";
            this.lblArt_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Artículos";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dgwArticulo);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkDelete);
            this.tabPage1.Controls.Add(this.btnDeleteArt);
            this.tabPage1.Controls.Add(this.btnSearchArt);
            this.tabPage1.Controls.Add(this.txtSearchArt);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(632, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDescrip);
            this.groupBox1.Controls.Add(this.rbCod);
            this.groupBox1.Controls.Add(this.btnOrderArt);
            this.groupBox1.Location = new System.Drawing.Point(150, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 41);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar";
            // 
            // rbDescrip
            // 
            this.rbDescrip.AutoSize = true;
            this.rbDescrip.Location = new System.Drawing.Point(107, 16);
            this.rbDescrip.Name = "rbDescrip";
            this.rbDescrip.Size = new System.Drawing.Size(81, 17);
            this.rbDescrip.TabIndex = 12;
            this.rbDescrip.TabStop = true;
            this.rbDescrip.Text = "Descripcion";
            this.rbDescrip.UseVisualStyleBackColor = true;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Location = new System.Drawing.Point(6, 16);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(58, 17);
            this.rbCod.TabIndex = 11;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "Codigo";
            this.rbCod.UseVisualStyleBackColor = true;
            // 
            // btnOrderArt
            // 
            this.btnOrderArt.BackColor = System.Drawing.Color.Silver;
            this.btnOrderArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnOrderArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrderArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnOrderArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderArt.Location = new System.Drawing.Point(225, 9);
            this.btnOrderArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderArt.Name = "btnOrderArt";
            this.btnOrderArt.Size = new System.Drawing.Size(81, 28);
            this.btnOrderArt.TabIndex = 10;
            this.btnOrderArt.Text = "&Ordenar";
            this.btnOrderArt.UseVisualStyleBackColor = false;
            this.btnOrderArt.Click += new System.EventHandler(this.btnOrderArt_Click);
            this.btnOrderArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnOrderArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Busca Descripcion-Familia";
            // 
            // dgwArticulo
            // 
            this.dgwArticulo.AllowUserToAddRows = false;
            this.dgwArticulo.AllowUserToDeleteRows = false;
            this.dgwArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwArticulo.BackgroundColor = System.Drawing.Color.White;
            this.dgwArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwArticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwArticulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwArticulo.ColumnHeadersHeight = 30;
            this.dgwArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwArticulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwArticulo.Location = new System.Drawing.Point(10, 133);
            this.dgwArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.dgwArticulo.MultiSelect = false;
            this.dgwArticulo.Name = "dgwArticulo";
            this.dgwArticulo.ReadOnly = true;
            this.dgwArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwArticulo.RowHeadersVisible = false;
            this.dgwArticulo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwArticulo.RowTemplate.Height = 24;
            this.dgwArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwArticulo.Size = new System.Drawing.Size(613, 165);
            this.dgwArticulo.TabIndex = 3;
            this.dgwArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArticulo_CellContentClick);
            this.dgwArticulo.DoubleClick += new System.EventHandler(this.dgwArticulo_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(392, 105);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = " ";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelete.Location = new System.Drawing.Point(27, 105);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(62, 17);
            this.chkDelete.TabIndex = 2;
            this.chkDelete.Text = "Eliminar";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // btnDeleteArt
            // 
            this.btnDeleteArt.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnDeleteArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnDeleteArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteArt.Location = new System.Drawing.Point(469, 64);
            this.btnDeleteArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteArt.Name = "btnDeleteArt";
            this.btnDeleteArt.Size = new System.Drawing.Size(81, 28);
            this.btnDeleteArt.TabIndex = 4;
            this.btnDeleteArt.Text = "&Eliminar";
            this.btnDeleteArt.UseVisualStyleBackColor = false;
            this.btnDeleteArt.Click += new System.EventHandler(this.btnDeleteArt_Click);
            this.btnDeleteArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnDeleteArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnSearchArt
            // 
            this.btnSearchArt.BackColor = System.Drawing.Color.Silver;
            this.btnSearchArt.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnSearchArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchArt.ForeColor = System.Drawing.Color.Ivory;
            this.btnSearchArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchArt.Location = new System.Drawing.Point(375, 64);
            this.btnSearchArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchArt.Name = "btnSearchArt";
            this.btnSearchArt.Size = new System.Drawing.Size(81, 28);
            this.btnSearchArt.TabIndex = 1;
            this.btnSearchArt.Text = "&Buscar";
            this.btnSearchArt.UseVisualStyleBackColor = false;
            this.btnSearchArt.Click += new System.EventHandler(this.btnSearchArt_Click);
            this.btnSearchArt.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnSearchArt.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // txtSearchArt
            // 
            this.txtSearchArt.Location = new System.Drawing.Point(218, 69);
            this.txtSearchArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchArt.Name = "txtSearchArt";
            this.txtSearchArt.Size = new System.Drawing.Size(133, 20);
            this.txtSearchArt.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl1.Location = new System.Drawing.Point(50, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
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
            // btnFamilia
            // 
            this.btnFamilia.BackColor = System.Drawing.Color.Silver;
            this.btnFamilia.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilia.ForeColor = System.Drawing.Color.White;
            this.btnFamilia.Location = new System.Drawing.Point(581, 31);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnFamilia.TabIndex = 7;
            this.btnFamilia.Text = "Familia";
            this.btnFamilia.UseVisualStyleBackColor = false;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btnFamilia);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.lnkMinimized);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:. Mantenimiento de Artículos .:.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmArticulo_FormClosing);
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmArticulo_MouseDown);
            this.tabPage2.ResumeLayout(false);
            this.gbArticulos.ResumeLayout(false);
            this.gbArticulos.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbArticulos;
        private System.Windows.Forms.Button btnCancelArt;
        private System.Windows.Forms.Button btnEditArt;
        private System.Windows.Forms.Button btnSaveArt;
        private System.Windows.Forms.Button btnNewArt;
        private System.Windows.Forms.TextBox txtArt_Descrip;
        private System.Windows.Forms.TextBox txtArt_ID;
        private System.Windows.Forms.Label lblArt_Descrip;
        private System.Windows.Forms.Label lblArt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgwArticulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnDeleteArt;
        private System.Windows.Forms.Button btnSearchArt;
        private System.Windows.Forms.TextBox txtSearchArt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ComboBox cbArt_UM;
        private System.Windows.Forms.Label lblArt_UM;
        private System.Windows.Forms.Label lblArt_Fam;
        private System.Windows.Forms.TextBox txtArt_SMax;
        private System.Windows.Forms.TextBox txtArt_SMin;
        private System.Windows.Forms.Label lblArt_SMax;
        private System.Windows.Forms.Label lblArt_SMin;
        private System.Windows.Forms.ComboBox cbArt_Fam;
        private System.Windows.Forms.TextBox txtArt_SR;
        private System.Windows.Forms.TextBox txtArt_MB;
        private System.Windows.Forms.TextBox txtArt_Costo;
        private System.Windows.Forms.TextBox txtArt_Precio;
        private System.Windows.Forms.TextBox txtArt_SA;
        private System.Windows.Forms.Label lblArt_SR;
        private System.Windows.Forms.Label lblArt_Precio;
        private System.Windows.Forms.Label lblArt_SA;
        private System.Windows.Forms.Label lblArt_MB;
        private System.Windows.Forms.Label lblArt_Costo;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label lblArt_Maneja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.LinkLabel lnkMinimized;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDescrip;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.Button btnOrderArt;
        private System.Windows.Forms.Button btnFamilia;
    }
}