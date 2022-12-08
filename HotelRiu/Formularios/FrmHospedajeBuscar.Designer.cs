namespace HotelRiu.Formularios
{
    partial class FrmHospedajeBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHospedajeBuscar));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvListaHospedajes = new System.Windows.Forms.DataGridView();
            this.CIDHospedaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCant_ninos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCant_adultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDiasHospedaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedajes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por Número Hospedaje (Reserva):";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Lime;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionar.Location = new System.Drawing.Point(403, 204);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(385, 30);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(16, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(381, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(353, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(435, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvListaHospedajes
            // 
            this.dgvListaHospedajes.AllowUserToAddRows = false;
            this.dgvListaHospedajes.AllowUserToDeleteRows = false;
            this.dgvListaHospedajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHospedajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDHospedaje,
            this.CCant_ninos,
            this.CCant_adultos,
            this.CDiasHospedaje,
            this.CFechaEntrada,
            this.CFechaSalida,
            this.CTotal,
            this.CIDPaquete,
            this.CIDHabitacion,
            this.CIDCliente,
            this.CIDEstado});
            this.dgvListaHospedajes.Location = new System.Drawing.Point(16, 64);
            this.dgvListaHospedajes.MultiSelect = false;
            this.dgvListaHospedajes.Name = "dgvListaHospedajes";
            this.dgvListaHospedajes.ReadOnly = true;
            this.dgvListaHospedajes.RowHeadersVisible = false;
            this.dgvListaHospedajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaHospedajes.Size = new System.Drawing.Size(772, 120);
            this.dgvListaHospedajes.TabIndex = 11;
            this.dgvListaHospedajes.VirtualMode = true;
            // 
            // CIDHospedaje
            // 
            this.CIDHospedaje.DataPropertyName = "IDHospedaje";
            this.CIDHospedaje.HeaderText = "#Reserva";
            this.CIDHospedaje.Name = "CIDHospedaje";
            this.CIDHospedaje.ReadOnly = true;
            this.CIDHospedaje.Width = 80;
            // 
            // CCant_ninos
            // 
            this.CCant_ninos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCant_ninos.DataPropertyName = "Cant_ninos";
            this.CCant_ninos.HeaderText = "Cantidad Niños";
            this.CCant_ninos.Name = "CCant_ninos";
            this.CCant_ninos.ReadOnly = true;
            this.CCant_ninos.Visible = false;
            // 
            // CCant_adultos
            // 
            this.CCant_adultos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCant_adultos.DataPropertyName = "Cant_adultos";
            this.CCant_adultos.HeaderText = "Cantidad Adultos";
            this.CCant_adultos.Name = "CCant_adultos";
            this.CCant_adultos.ReadOnly = true;
            this.CCant_adultos.Visible = false;
            // 
            // CDiasHospedaje
            // 
            this.CDiasHospedaje.DataPropertyName = "DiasHospedaje";
            this.CDiasHospedaje.HeaderText = "Días Hospedaje";
            this.CDiasHospedaje.Name = "CDiasHospedaje";
            this.CDiasHospedaje.ReadOnly = true;
            this.CDiasHospedaje.Width = 120;
            // 
            // CFechaEntrada
            // 
            this.CFechaEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFechaEntrada.DataPropertyName = "FechaEntrada";
            this.CFechaEntrada.HeaderText = "Fecha Entrada";
            this.CFechaEntrada.Name = "CFechaEntrada";
            this.CFechaEntrada.ReadOnly = true;
            // 
            // CFechaSalida
            // 
            this.CFechaSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFechaSalida.DataPropertyName = "FechaSalida";
            this.CFechaSalida.HeaderText = "Fecha Salida";
            this.CFechaSalida.Name = "CFechaSalida";
            this.CFechaSalida.ReadOnly = true;
            // 
            // CTotal
            // 
            this.CTotal.DataPropertyName = "Total";
            this.CTotal.HeaderText = "Precio Total";
            this.CTotal.Name = "CTotal";
            this.CTotal.ReadOnly = true;
            this.CTotal.Width = 130;
            // 
            // CIDPaquete
            // 
            this.CIDPaquete.DataPropertyName = "IDPaquete";
            this.CIDPaquete.HeaderText = "Paquete";
            this.CIDPaquete.Name = "CIDPaquete";
            this.CIDPaquete.ReadOnly = true;
            this.CIDPaquete.Visible = false;
            // 
            // CIDHabitacion
            // 
            this.CIDHabitacion.DataPropertyName = "IDHabitacion";
            this.CIDHabitacion.HeaderText = "IDHabitacion";
            this.CIDHabitacion.Name = "CIDHabitacion";
            this.CIDHabitacion.ReadOnly = true;
            this.CIDHabitacion.Visible = false;
            // 
            // CIDCliente
            // 
            this.CIDCliente.DataPropertyName = "IDCliente";
            this.CIDCliente.HeaderText = "IDCliente";
            this.CIDCliente.Name = "CIDCliente";
            this.CIDCliente.ReadOnly = true;
            this.CIDCliente.Visible = false;
            // 
            // CIDEstado
            // 
            this.CIDEstado.DataPropertyName = "IDEstado";
            this.CIDEstado.HeaderText = "IDEstado";
            this.CIDEstado.Name = "CIDEstado";
            this.CIDEstado.ReadOnly = true;
            this.CIDEstado.Visible = false;
            // 
            // FrmHospedajeBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.dgvListaHospedajes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHospedajeBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Hospedaje";
            this.Load += new System.EventHandler(this.FrmHospedajeBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvListaHospedajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDHospedaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCant_ninos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCant_adultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDiasHospedaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDEstado;
    }
}