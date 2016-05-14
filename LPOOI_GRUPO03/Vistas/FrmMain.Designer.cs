namespace Vistas
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tltMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSell = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackgroundImage = global::Vistas.Properties.Resources.headH;
            this.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBottom.Controls.Add(this.lblClock);
            this.pnlBottom.Controls.Add(this.lblDate);
            this.pnlBottom.Controls.Add(this.lblUserLogin);
            this.pnlBottom.Controls.Add(this.btnMin);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 434);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 40);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Ivory;
            this.lblClock.Location = new System.Drawing.Point(3, 10);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(98, 20);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "22:02:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Ivory;
            this.lblDate.Location = new System.Drawing.Point(608, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(115, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "28/10/2014";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.Ivory;
            this.lblUserLogin.Location = new System.Drawing.Point(223, 6);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(265, 28);
            this.lblUserLogin.TabIndex = 2;
            this.lblUserLogin.Text = "Bienvenido:";
            this.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.Ivory;
            this.btnMin.Location = new System.Drawing.Point(729, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 36);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Ivory;
            this.btnClose.Location = new System.Drawing.Point(764, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.FrmMain_Load);
            // 
            // msMenu
            // 
            this.msMenu.AutoSize = false;
            this.msMenu.BackColor = System.Drawing.Color.Transparent;
            this.msMenu.BackgroundImage = global::Vistas.Properties.Resources.headH;
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStock,
            this.tsmBuy,
            this.tsmProduct,
            this.tsmSell,
            this.tsmUser,
            this.tsmLogOut});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.ShowItemToolTips = true;
            this.msMenu.Size = new System.Drawing.Size(800, 94);
            this.msMenu.TabIndex = 3;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmStock
            // 
            this.tsmStock.AutoSize = false;
            this.tsmStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tsmStock.ForeColor = System.Drawing.Color.Ivory;
            this.tsmStock.Image = global::Vistas.Properties.Resources.stock1;
            this.tsmStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmStock.Name = "tsmStock";
            this.tsmStock.Size = new System.Drawing.Size(120, 90);
            this.tsmStock.Text = "Stock y Articulos";
            this.tsmStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmStock.Visible = false;
            this.tsmStock.Click += new System.EventHandler(this.tsmStock_Click);
            this.tsmStock.MouseEnter += new System.EventHandler(this.ChangeImage_MouseEnter);
            this.tsmStock.MouseLeave += new System.EventHandler(this.ChangeImage_MouseLeave);
            // 
            // tsmBuy
            // 
            this.tsmBuy.AutoSize = false;
            this.tsmBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tsmBuy.ForeColor = System.Drawing.Color.Ivory;
            this.tsmBuy.Image = global::Vistas.Properties.Resources.buy1;
            this.tsmBuy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmBuy.Name = "tsmBuy";
            this.tsmBuy.Size = new System.Drawing.Size(90, 90);
            this.tsmBuy.Text = "Compras";
            this.tsmBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmBuy.Visible = false;
            this.tsmBuy.Click += new System.EventHandler(this.tsmCompras_Click);
            this.tsmBuy.MouseEnter += new System.EventHandler(this.ChangeImage_MouseEnter);
            this.tsmBuy.MouseLeave += new System.EventHandler(this.ChangeImage_MouseLeave);
            // 
            // tsmProduct
            // 
            this.tsmProduct.AutoSize = false;
            this.tsmProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tsmProduct.ForeColor = System.Drawing.Color.Ivory;
            this.tsmProduct.Image = global::Vistas.Properties.Resources.product1;
            this.tsmProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmProduct.Name = "tsmProduct";
            this.tsmProduct.Size = new System.Drawing.Size(90, 90);
            this.tsmProduct.Text = "Produccion";
            this.tsmProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmProduct.Visible = false;
            this.tsmProduct.MouseEnter += new System.EventHandler(this.ChangeImage_MouseEnter);
            this.tsmProduct.MouseLeave += new System.EventHandler(this.ChangeImage_MouseLeave);
            // 
            // tsmSell
            // 
            this.tsmSell.AutoSize = false;
            this.tsmSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tsmSell.ForeColor = System.Drawing.Color.Ivory;
            this.tsmSell.Image = global::Vistas.Properties.Resources.sell1;
            this.tsmSell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSell.Name = "tsmSell";
            this.tsmSell.Size = new System.Drawing.Size(90, 90);
            this.tsmSell.Text = "Ventas";
            this.tsmSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmSell.Visible = false;
            this.tsmSell.MouseEnter += new System.EventHandler(this.ChangeImage_MouseEnter);
            this.tsmSell.MouseLeave += new System.EventHandler(this.ChangeImage_MouseLeave);
            // 
            // tsmUser
            // 
            this.tsmUser.AutoSize = false;
            this.tsmUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tsmUser.ForeColor = System.Drawing.Color.Ivory;
            this.tsmUser.Image = global::Vistas.Properties.Resources.user1;
            this.tsmUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(90, 90);
            this.tsmUser.Text = "Usuarios";
            this.tsmUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmUser.Visible = false;
            this.tsmUser.Click += new System.EventHandler(this.tsmUsuarios_Click);
            this.tsmUser.MouseEnter += new System.EventHandler(this.ChangeImage_MouseEnter);
            this.tsmUser.MouseLeave += new System.EventHandler(this.ChangeImage_MouseLeave);
            // 
            // tsmLogOut
            // 
            this.tsmLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmLogOut.Image = global::Vistas.Properties.Resources.logout1;
            this.tsmLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmLogOut.Name = "tsmLogOut";
            this.tsmLogOut.Size = new System.Drawing.Size(57, 90);
            this.tsmLogOut.Text = " ";
            this.tsmLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.tsmLogOut.ToolTipText = "Cerrar Sesion";
            this.tsmLogOut.Click += new System.EventHandler(this.tsmLogOut_Click);
            this.tsmLogOut.MouseEnter += new System.EventHandler(this.ChangeImage_MouseEnter);
            this.tsmLogOut.MouseLeave += new System.EventHandler(this.ChangeImage_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Vistas.Properties.Resources.cupcake;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.msMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlBottom.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tltMensaje;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmStock;
        private System.Windows.Forms.ToolStripMenuItem tsmBuy;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmSell;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripMenuItem tsmLogOut;

    }
}