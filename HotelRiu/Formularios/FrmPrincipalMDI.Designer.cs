namespace HotelRiu.Formularios
{
    partial class FrmPrincipalMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOcupaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHospedajes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHabitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaquetes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetodosDePago = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGaleriaReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorRangoDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReimpresionDeFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAcercaDeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioLogueado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuMantenimientos,
            this.mnuProcesos,
            this.mnuGaleriaReportes,
            this.mnuAcercaDeTool,
            this.mnuCerrarSesionTool});
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 25);
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuEmpleados,
            this.mnuOcupaciones,
            this.toolStripSeparator1,
            this.mnuClientes,
            this.toolStripSeparator2,
            this.mnuHospedajes,
            this.mnuHabitaciones,
            this.mnuPaquetes,
            this.mnuMetodosDePago});
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(148, 25);
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(213, 26);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // mnuEmpleados
            // 
            this.mnuEmpleados.Name = "mnuEmpleados";
            this.mnuEmpleados.Size = new System.Drawing.Size(213, 26);
            this.mnuEmpleados.Text = "Empleados";
            this.mnuEmpleados.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // mnuOcupaciones
            // 
            this.mnuOcupaciones.Name = "mnuOcupaciones";
            this.mnuOcupaciones.Size = new System.Drawing.Size(213, 26);
            this.mnuOcupaciones.Text = "Ocupaciones";
            this.mnuOcupaciones.Click += new System.EventHandler(this.ocupacionesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(213, 26);
            this.mnuClientes.Text = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // mnuHospedajes
            // 
            this.mnuHospedajes.Name = "mnuHospedajes";
            this.mnuHospedajes.Size = new System.Drawing.Size(213, 26);
            this.mnuHospedajes.Text = "Hospedajes";
            this.mnuHospedajes.Click += new System.EventHandler(this.hospedajesToolStripMenuItem_Click);
            // 
            // mnuHabitaciones
            // 
            this.mnuHabitaciones.Name = "mnuHabitaciones";
            this.mnuHabitaciones.Size = new System.Drawing.Size(213, 26);
            this.mnuHabitaciones.Text = "Habitaciones";
            this.mnuHabitaciones.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // mnuPaquetes
            // 
            this.mnuPaquetes.Name = "mnuPaquetes";
            this.mnuPaquetes.Size = new System.Drawing.Size(213, 26);
            this.mnuPaquetes.Text = "Paquetes";
            this.mnuPaquetes.Click += new System.EventHandler(this.paquetesToolStripMenuItem_Click);
            // 
            // mnuMetodosDePago
            // 
            this.mnuMetodosDePago.Enabled = false;
            this.mnuMetodosDePago.Name = "mnuMetodosDePago";
            this.mnuMetodosDePago.Size = new System.Drawing.Size(213, 26);
            this.mnuMetodosDePago.Text = "Metodos de Pago";
            this.mnuMetodosDePago.Visible = false;
            this.mnuMetodosDePago.Click += new System.EventHandler(this.metodosDePagoToolStripMenuItem_Click);
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFacturacion});
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(89, 25);
            this.mnuProcesos.Text = "Procesos";
            // 
            // mnuFacturacion
            // 
            this.mnuFacturacion.Name = "mnuFacturacion";
            this.mnuFacturacion.Size = new System.Drawing.Size(169, 26);
            this.mnuFacturacion.Text = "Facturación";
            this.mnuFacturacion.Click += new System.EventHandler(this.facturaciónToolStripMenuItem_Click);
            // 
            // mnuGaleriaReportes
            // 
            this.mnuGaleriaReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorRangoDeFechasToolStripMenuItem,
            this.ventasPorClienteToolStripMenuItem,
            this.ventasPorUsuarioToolStripMenuItem,
            this.toolStripSeparator3,
            this.listadoDeClienteToolStripMenuItem,
            this.listadoDeUsuariosToolStripMenuItem,
            this.listadoDeEmpleadosToolStripMenuItem,
            this.toolStripSeparator4,
            this.mnuReimpresionDeFactura});
            this.mnuGaleriaReportes.Name = "mnuGaleriaReportes";
            this.mnuGaleriaReportes.Size = new System.Drawing.Size(147, 25);
            this.mnuGaleriaReportes.Text = "Galería Reportes";
            // 
            // ventasPorRangoDeFechasToolStripMenuItem
            // 
            this.ventasPorRangoDeFechasToolStripMenuItem.Enabled = false;
            this.ventasPorRangoDeFechasToolStripMenuItem.Name = "ventasPorRangoDeFechasToolStripMenuItem";
            this.ventasPorRangoDeFechasToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.ventasPorRangoDeFechasToolStripMenuItem.Text = "Ventas por Rango de Fechas";
            this.ventasPorRangoDeFechasToolStripMenuItem.Visible = false;
            // 
            // ventasPorClienteToolStripMenuItem
            // 
            this.ventasPorClienteToolStripMenuItem.Enabled = false;
            this.ventasPorClienteToolStripMenuItem.Name = "ventasPorClienteToolStripMenuItem";
            this.ventasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.ventasPorClienteToolStripMenuItem.Text = "Ventas por Cliente";
            this.ventasPorClienteToolStripMenuItem.Visible = false;
            // 
            // ventasPorUsuarioToolStripMenuItem
            // 
            this.ventasPorUsuarioToolStripMenuItem.Enabled = false;
            this.ventasPorUsuarioToolStripMenuItem.Name = "ventasPorUsuarioToolStripMenuItem";
            this.ventasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.ventasPorUsuarioToolStripMenuItem.Text = "Ventas por Usuario";
            this.ventasPorUsuarioToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(289, 6);
            // 
            // listadoDeClienteToolStripMenuItem
            // 
            this.listadoDeClienteToolStripMenuItem.Enabled = false;
            this.listadoDeClienteToolStripMenuItem.Name = "listadoDeClienteToolStripMenuItem";
            this.listadoDeClienteToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.listadoDeClienteToolStripMenuItem.Text = "Listado de Cliente";
            this.listadoDeClienteToolStripMenuItem.Visible = false;
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Enabled = false;
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Listado de Usuarios";
            this.listadoDeUsuariosToolStripMenuItem.Visible = false;
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Enabled = false;
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "Listado de Empleados";
            this.listadoDeEmpleadosToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(289, 6);
            // 
            // mnuReimpresionDeFactura
            // 
            this.mnuReimpresionDeFactura.Name = "mnuReimpresionDeFactura";
            this.mnuReimpresionDeFactura.Size = new System.Drawing.Size(292, 26);
            this.mnuReimpresionDeFactura.Text = "Reimpresión de Factura";
            this.mnuReimpresionDeFactura.Click += new System.EventHandler(this.reimpresiónDeFacturaToolStripMenuItem_Click);
            // 
            // mnuAcercaDeTool
            // 
            this.mnuAcercaDeTool.Name = "mnuAcercaDeTool";
            this.mnuAcercaDeTool.Size = new System.Drawing.Size(96, 25);
            this.mnuAcercaDeTool.Text = "Acerca de";
            this.mnuAcercaDeTool.Click += new System.EventHandler(this.mnuAcercaDeTool_Click);
            // 
            // mnuCerrarSesionTool
            // 
            this.mnuCerrarSesionTool.Name = "mnuCerrarSesionTool";
            this.mnuCerrarSesionTool.Size = new System.Drawing.Size(122, 25);
            this.mnuCerrarSesionTool.Text = "Cerrar Sesión";
            this.mnuCerrarSesionTool.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 454);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelRiu.Properties.Resources.hospedaje;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuarioLogueado,
            this.lblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(1, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(865, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 19);
            this.toolStripStatusLabel1.Text = "USUARIO:";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(53, 19);
            this.lblUsuarioLogueado.Text = "Nombre";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Padding = new System.Windows.Forms.Padding(2);
            this.lblFechaHora.Size = new System.Drawing.Size(738, 19);
            this.lblFechaHora.Spring = true;
            this.lblFechaHora.Text = "FechaHora";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrFechaHora
            // 
            this.tmrFechaHora.Interval = 1000;
            this.tmrFechaHora.Tick += new System.EventHandler(this.tmrFechaHora_Tick);
            // 
            // FrmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(867, 485);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(883, 524);
            this.Name = "FrmPrincipalMDI";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Pantalla Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipalMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuEmpleados;
        private System.Windows.Forms.ToolStripMenuItem mnuOcupaciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuGaleriaReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuAcercaDeTool;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuHospedajes;
        private System.Windows.Forms.ToolStripMenuItem mnuHabitaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuPaquetes;
        private System.Windows.Forms.ToolStripMenuItem mnuMetodosDePago;
        private System.Windows.Forms.ToolStripMenuItem mnuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem ventasPorRangoDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuReimpresionDeFactura;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesionTool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioLogueado;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.Timer tmrFechaHora;
    }
}