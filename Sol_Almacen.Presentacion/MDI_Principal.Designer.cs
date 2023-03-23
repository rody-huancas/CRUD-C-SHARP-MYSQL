namespace Sol_Almacen.Presentacion
{
    partial class MDI_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dATOSMAESTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Medida = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Lb_Hora = new System.Windows.Forms.Label();
            this.Lb_Fecha = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATOSMAESTROToolStripMenuItem,
            this.Menu_Salir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1150, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // dATOSMAESTROToolStripMenuItem
            // 
            this.dATOSMAESTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Articulos,
            this.toolStripSeparator1,
            this.Menu_Categorias,
            this.Menu_Medida});
            this.dATOSMAESTROToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dATOSMAESTROToolStripMenuItem.Image")));
            this.dATOSMAESTROToolStripMenuItem.Name = "dATOSMAESTROToolStripMenuItem";
            this.dATOSMAESTROToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.dATOSMAESTROToolStripMenuItem.Text = "DATOS MAESTRO";
            // 
            // Menu_Articulos
            // 
            this.Menu_Articulos.Name = "Menu_Articulos";
            this.Menu_Articulos.Size = new System.Drawing.Size(218, 26);
            this.Menu_Articulos.Text = "Artículos";
            this.Menu_Articulos.Click += new System.EventHandler(this.Menu_Articulos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // Menu_Categorias
            // 
            this.Menu_Categorias.Name = "Menu_Categorias";
            this.Menu_Categorias.Size = new System.Drawing.Size(218, 26);
            this.Menu_Categorias.Text = "Categorías";
            this.Menu_Categorias.Click += new System.EventHandler(this.Menu_Categorias_Click);
            // 
            // Menu_Medida
            // 
            this.Menu_Medida.Name = "Menu_Medida";
            this.Menu_Medida.Size = new System.Drawing.Size(218, 26);
            this.Menu_Medida.Text = "Unidad De Medida";
            this.Menu_Medida.Click += new System.EventHandler(this.Menu_Medida_Click);
            // 
            // Menu_Salir
            // 
            this.Menu_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Salir.Image")));
            this.Menu_Salir.Name = "Menu_Salir";
            this.Menu_Salir.Size = new System.Drawing.Size(81, 26);
            this.Menu_Salir.Text = "SALIR";
            this.Menu_Salir.Click += new System.EventHandler(this.Menu_Salir_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1150, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 620);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1150, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Lb_Hora
            // 
            this.Lb_Hora.AutoSize = true;
            this.Lb_Hora.BackColor = System.Drawing.Color.White;
            this.Lb_Hora.Font = new System.Drawing.Font("Bahnschrift", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Hora.ForeColor = System.Drawing.Color.Black;
            this.Lb_Hora.Location = new System.Drawing.Point(105, 154);
            this.Lb_Hora.Name = "Lb_Hora";
            this.Lb_Hora.Size = new System.Drawing.Size(0, 200);
            this.Lb_Hora.TabIndex = 4;
            this.Lb_Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Fecha
            // 
            this.Lb_Fecha.AutoSize = true;
            this.Lb_Fecha.BackColor = System.Drawing.Color.White;
            this.Lb_Fecha.Font = new System.Drawing.Font("Bahnschrift", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fecha.ForeColor = System.Drawing.Color.Black;
            this.Lb_Fecha.Location = new System.Drawing.Point(266, 365);
            this.Lb_Fecha.Name = "Lb_Fecha";
            this.Lb_Fecha.Size = new System.Drawing.Size(0, 140);
            this.Lb_Fecha.TabIndex = 5;
            this.Lb_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // MDI_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 646);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.Lb_Fecha);
            this.Controls.Add(this.Lb_Hora);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI_Principal";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.MDI_Principal_Load);
            this.Resize += new System.EventHandler(this.MDI_Principal_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem dATOSMAESTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Articulos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Categorias;
        private System.Windows.Forms.ToolStripMenuItem Menu_Medida;
        private System.Windows.Forms.ToolStripMenuItem Menu_Salir;
        private System.Windows.Forms.Label Lb_Hora;
        private System.Windows.Forms.Label Lb_Fecha;
        private System.Windows.Forms.Timer timerHora;
    }
}



