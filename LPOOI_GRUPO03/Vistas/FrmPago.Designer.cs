namespace Vistas
{
    partial class FrmPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOP_Importe = new System.Windows.Forms.TextBox();
            this.txtProv_Id = new System.Windows.Forms.TextBox();
            this.btnSaveOP = new System.Windows.Forms.Button();
            this.btnCancelOP = new System.Windows.Forms.Button();
            this.dtOP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.gbPagos = new System.Windows.Forms.GroupBox();
            this.dgwPagos = new System.Windows.Forms.DataGridView();
            this.lblProv = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkClose = new System.Windows.Forms.LinkLabel();
            this.gbPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden a Pagar";
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Location = new System.Drawing.Point(90, 16);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(169, 21);
            this.cmbOrden.TabIndex = 1;
            this.cmbOrden.SelectedValueChanged += new System.EventHandler(this.cmbOrden_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Importe";
            // 
            // txtOP_Importe
            // 
            this.txtOP_Importe.Location = new System.Drawing.Point(49, 75);
            this.txtOP_Importe.Name = "txtOP_Importe";
            this.txtOP_Importe.ReadOnly = true;
            this.txtOP_Importe.Size = new System.Drawing.Size(100, 20);
            this.txtOP_Importe.TabIndex = 5;
            // 
            // txtProv_Id
            // 
            this.txtProv_Id.Location = new System.Drawing.Point(176, 48);
            this.txtProv_Id.Name = "txtProv_Id";
            this.txtProv_Id.Size = new System.Drawing.Size(100, 20);
            this.txtProv_Id.TabIndex = 6;
            this.txtProv_Id.Visible = false;
            // 
            // btnSaveOP
            // 
            this.btnSaveOP.Location = new System.Drawing.Point(120, 133);
            this.btnSaveOP.Name = "btnSaveOP";
            this.btnSaveOP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOP.TabIndex = 7;
            this.btnSaveOP.Text = "Pagar";
            this.btnSaveOP.UseVisualStyleBackColor = true;
            this.btnSaveOP.Click += new System.EventHandler(this.btnSaveOP_Click);
            // 
            // btnCancelOP
            // 
            this.btnCancelOP.Location = new System.Drawing.Point(201, 133);
            this.btnCancelOP.Name = "btnCancelOP";
            this.btnCancelOP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOP.TabIndex = 8;
            this.btnCancelOP.Text = "Cancelar";
            this.btnCancelOP.UseVisualStyleBackColor = true;
            this.btnCancelOP.Click += new System.EventHandler(this.btnCancelOP_Click);
            // 
            // dtOP_Fecha
            // 
            this.dtOP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOP_Fecha.Location = new System.Drawing.Point(49, 48);
            this.dtOP_Fecha.Name = "dtOP_Fecha";
            this.dtOP_Fecha.Size = new System.Drawing.Size(100, 20);
            this.dtOP_Fecha.TabIndex = 10;
            // 
            // gbPagos
            // 
            this.gbPagos.Controls.Add(this.dtOP_Fecha);
            this.gbPagos.Controls.Add(this.btnCancelOP);
            this.gbPagos.Controls.Add(this.btnSaveOP);
            this.gbPagos.Controls.Add(this.txtProv_Id);
            this.gbPagos.Controls.Add(this.txtOP_Importe);
            this.gbPagos.Controls.Add(this.label3);
            this.gbPagos.Controls.Add(this.label2);
            this.gbPagos.Controls.Add(this.cmbOrden);
            this.gbPagos.Controls.Add(this.label1);
            this.gbPagos.Location = new System.Drawing.Point(403, 72);
            this.gbPagos.Name = "gbPagos";
            this.gbPagos.Size = new System.Drawing.Size(294, 179);
            this.gbPagos.TabIndex = 11;
            this.gbPagos.TabStop = false;
            this.gbPagos.Text = "Pagos";
            // 
            // dgwPagos
            // 
            this.dgwPagos.AllowUserToAddRows = false;
            this.dgwPagos.AllowUserToDeleteRows = false;
            this.dgwPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwPagos.BackgroundColor = System.Drawing.Color.White;
            this.dgwPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgwPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPagos.GridColor = System.Drawing.Color.White;
            this.dgwPagos.Location = new System.Drawing.Point(17, 77);
            this.dgwPagos.MultiSelect = false;
            this.dgwPagos.Name = "dgwPagos";
            this.dgwPagos.ReadOnly = true;
            this.dgwPagos.RowHeadersVisible = false;
            this.dgwPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPagos.Size = new System.Drawing.Size(366, 150);
            this.dgwPagos.TabIndex = 12;
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(12, 23);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(56, 13);
            this.lblProv.TabIndex = 13;
            this.lblProv.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(74, 20);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 14;
            this.cmbProveedor.SelectedValueChanged += new System.EventHandler(this.cmbProveedor_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.lblProv);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hasta";
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.Location = new System.Drawing.Point(438, 33);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(101, 20);
            this.dtFechaHasta.TabIndex = 18;
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.Location = new System.Drawing.Point(293, 33);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(96, 20);
            this.dtFechaDesde.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(545, 32);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 20;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 237);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.dtFechaDesde);
            this.groupBox2.Controls.Add(this.dtFechaHasta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dgwPagos);
            this.groupBox2.Controls.Add(this.gbPagos);
            this.groupBox2.Location = new System.Drawing.Point(21, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 283);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Orden de Pagos";
            // 
            // lnkClose
            // 
            this.lnkClose.AutoSize = true;
            this.lnkClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkClose.LinkColor = System.Drawing.Color.SaddleBrown;
            this.lnkClose.Location = new System.Drawing.Point(717, 9);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.Size = new System.Drawing.Size(18, 17);
            this.lnkClose.TabIndex = 24;
            this.lnkClose.TabStop = true;
            this.lnkClose.Text = "X";
            this.lnkClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClose_LinkClicked);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(760, 357);
            this.Controls.Add(this.lnkClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.gbPagos.ResumeLayout(false);
            this.gbPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOP_Importe;
        private System.Windows.Forms.TextBox txtProv_Id;
        private System.Windows.Forms.Button btnSaveOP;
        private System.Windows.Forms.Button btnCancelOP;
        private System.Windows.Forms.DateTimePicker dtOP_Fecha;
        private System.Windows.Forms.GroupBox gbPagos;
        private System.Windows.Forms.DataGridView dgwPagos;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkClose;
    }
}