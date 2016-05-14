namespace Vistas
{
    partial class FrmFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamilia));
            this.dgwFamilia = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblFam_Descrip = new System.Windows.Forms.Label();
            this.txtFam_Descrip = new System.Windows.Forms.TextBox();
            this.txtFam_ID = new System.Windows.Forms.TextBox();
            this.btnEditFam = new System.Windows.Forms.Button();
            this.btnCancelFam = new System.Windows.Forms.Button();
            this.btnSaveFam = new System.Windows.Forms.Button();
            this.btnNewFam = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.btnDeleteFam = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorIconos = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajes = new System.Windows.Forms.ToolTip(this.components);
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFamilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwFamilia
            // 
            this.dgwFamilia.AllowUserToAddRows = false;
            this.dgwFamilia.AllowUserToDeleteRows = false;
            this.dgwFamilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwFamilia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwFamilia.BackgroundColor = System.Drawing.Color.White;
            this.dgwFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwFamilia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwFamilia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFamilia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgwFamilia.GridColor = System.Drawing.Color.White;
            this.dgwFamilia.Location = new System.Drawing.Point(22, 73);
            this.dgwFamilia.Name = "dgwFamilia";
            this.dgwFamilia.ReadOnly = true;
            this.dgwFamilia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwFamilia.RowHeadersVisible = false;
            this.dgwFamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFamilia.Size = new System.Drawing.Size(196, 194);
            this.dgwFamilia.TabIndex = 0;
            this.dgwFamilia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFamilia_CellContentClick);
            this.dgwFamilia.DoubleClick += new System.EventHandler(this.dgwFamilia_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // lblFam_Descrip
            // 
            this.lblFam_Descrip.AutoSize = true;
            this.lblFam_Descrip.Location = new System.Drawing.Point(224, 164);
            this.lblFam_Descrip.Name = "lblFam_Descrip";
            this.lblFam_Descrip.Size = new System.Drawing.Size(63, 13);
            this.lblFam_Descrip.TabIndex = 1;
            this.lblFam_Descrip.Text = "Descripcion";
            // 
            // txtFam_Descrip
            // 
            this.txtFam_Descrip.Location = new System.Drawing.Point(290, 161);
            this.txtFam_Descrip.Name = "txtFam_Descrip";
            this.txtFam_Descrip.Size = new System.Drawing.Size(100, 20);
            this.txtFam_Descrip.TabIndex = 2;
            // 
            // txtFam_ID
            // 
            this.txtFam_ID.Location = new System.Drawing.Point(290, 133);
            this.txtFam_ID.Name = "txtFam_ID";
            this.txtFam_ID.Size = new System.Drawing.Size(100, 20);
            this.txtFam_ID.TabIndex = 3;
            this.txtFam_ID.Visible = false;
            // 
            // btnEditFam
            // 
            this.btnEditFam.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnEditFam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditFam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditFam.Image = global::Vistas.Properties.Resources.edit;
            this.btnEditFam.Location = new System.Drawing.Point(319, 73);
            this.btnEditFam.Name = "btnEditFam";
            this.btnEditFam.Size = new System.Drawing.Size(40, 40);
            this.btnEditFam.TabIndex = 6;
            this.ttMensajes.SetToolTip(this.btnEditFam, "Editar");
            this.btnEditFam.UseVisualStyleBackColor = true;
            this.btnEditFam.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnEditFam.Click += new System.EventHandler(this.btnEditFam_Click);
            this.btnEditFam.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnEditFam.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnCancelFam
            // 
            this.btnCancelFam.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnCancelFam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelFam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelFam.Image = global::Vistas.Properties.Resources.cancel;
            this.btnCancelFam.Location = new System.Drawing.Point(365, 73);
            this.btnCancelFam.Name = "btnCancelFam";
            this.btnCancelFam.Size = new System.Drawing.Size(40, 40);
            this.btnCancelFam.TabIndex = 7;
            this.ttMensajes.SetToolTip(this.btnCancelFam, "Cancelar");
            this.btnCancelFam.UseVisualStyleBackColor = true;
            this.btnCancelFam.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnCancelFam.Click += new System.EventHandler(this.btnCancelFam_Click);
            this.btnCancelFam.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnCancelFam.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnSaveFam
            // 
            this.btnSaveFam.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnSaveFam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveFam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveFam.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFam.Image")));
            this.btnSaveFam.Location = new System.Drawing.Point(273, 73);
            this.btnSaveFam.Name = "btnSaveFam";
            this.btnSaveFam.Size = new System.Drawing.Size(40, 40);
            this.btnSaveFam.TabIndex = 5;
            this.ttMensajes.SetToolTip(this.btnSaveFam, "Guardar");
            this.btnSaveFam.UseVisualStyleBackColor = true;
            this.btnSaveFam.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnSaveFam.Click += new System.EventHandler(this.btnSaveFam_Click);
            this.btnSaveFam.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnSaveFam.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // btnNewFam
            // 
            this.btnNewFam.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewFam.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnNewFam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewFam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewFam.Image = global::Vistas.Properties.Resources.nuevo;
            this.btnNewFam.Location = new System.Drawing.Point(227, 73);
            this.btnNewFam.Name = "btnNewFam";
            this.btnNewFam.Size = new System.Drawing.Size(40, 40);
            this.btnNewFam.TabIndex = 4;
            this.ttMensajes.SetToolTip(this.btnNewFam, "Nuevo");
            this.btnNewFam.UseVisualStyleBackColor = false;
            this.btnNewFam.EnabledChanged += new System.EventHandler(this.btnColor_EnabledChanged);
            this.btnNewFam.Click += new System.EventHandler(this.btnNewFam_Click);
            this.btnNewFam.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnNewFam.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(20, 34);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(62, 17);
            this.chkDelete.TabIndex = 8;
            this.chkDelete.Text = "Eliminar";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // btnDeleteFam
            // 
            this.btnDeleteFam.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteFam.BackgroundImage = global::Vistas.Properties.Resources.buttonH;
            this.btnDeleteFam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteFam.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteFam.Image")));
            this.btnDeleteFam.Location = new System.Drawing.Point(176, 11);
            this.btnDeleteFam.Name = "btnDeleteFam";
            this.btnDeleteFam.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteFam.TabIndex = 9;
            this.ttMensajes.SetToolTip(this.btnDeleteFam, "Eliminar");
            this.btnDeleteFam.UseVisualStyleBackColor = false;
            this.btnDeleteFam.Click += new System.EventHandler(this.btnDeleteFam_Click);
            this.btnDeleteFam.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.btnDeleteFam.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(19, 11);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "label1";
            // 
            // errorIconos
            // 
            this.errorIconos.ContainerControl = this;
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkClose.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lnkClose.Location = new System.Drawing.Point(427, 13);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(18, 17);
            this.lnkClose.TabIndex = 11;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "X";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnDeleteFam);
            this.groupBox1.Controls.Add(this.chkDelete);
            this.groupBox1.Controls.Add(this.btnCancelFam);
            this.groupBox1.Controls.Add(this.btnEditFam);
            this.groupBox1.Controls.Add(this.btnSaveFam);
            this.groupBox1.Controls.Add(this.btnNewFam);
            this.groupBox1.Controls.Add(this.txtFam_ID);
            this.groupBox1.Controls.Add(this.txtFam_Descrip);
            this.groupBox1.Controls.Add(this.lblFam_Descrip);
            this.groupBox1.Controls.Add(this.dgwFamilia);
            this.groupBox1.Location = new System.Drawing.Point(24, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 289);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Familia";
            // 
            // FrmFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(475, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnkClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Familia";
            this.Load += new System.EventHandler(this.FrmFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFamilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFamilia;
        private System.Windows.Forms.Label lblFam_Descrip;
        private System.Windows.Forms.TextBox txtFam_Descrip;
        private System.Windows.Forms.TextBox txtFam_ID;
        private System.Windows.Forms.Button btnNewFam;
        private System.Windows.Forms.Button btnSaveFam;
        private System.Windows.Forms.Button btnEditFam;
        private System.Windows.Forms.Button btnCancelFam;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnDeleteFam;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ToolTip ttMensajes;
        private System.Windows.Forms.ErrorProvider errorIconos;
        private System.Windows.Forms.LinkLabel lnkClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}