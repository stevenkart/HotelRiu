namespace HotelRiu.Formularios
{
    partial class FrmHospedajesGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHospedajesGestion));
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.cboxHabitacion = new System.Windows.Forms.ComboBox();
            this.txtCantNinos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDHospedaje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantAdultos = new System.Windows.Forms.TextBox();
            this.txtDiasHospedaje = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.cboxPaquete = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtIDHabitacionTemporal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chCancelados = new System.Windows.Forms.CheckBox();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedajes)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 211);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(800, 406);
            this.panel5.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76581F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23419F));
            this.tableLayoutPanel3.Controls.Add(this.dgvListaHospedajes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 382F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(776, 382);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.dgvListaHospedajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaHospedajes.Location = new System.Drawing.Point(3, 3);
            this.dgvListaHospedajes.MultiSelect = false;
            this.dgvListaHospedajes.Name = "dgvListaHospedajes";
            this.dgvListaHospedajes.ReadOnly = true;
            this.dgvListaHospedajes.RowHeadersVisible = false;
            this.dgvListaHospedajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaHospedajes.Size = new System.Drawing.Size(380, 376);
            this.dgvListaHospedajes.TabIndex = 6;
            this.dgvListaHospedajes.VirtualMode = true;
            this.dgvListaHospedajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // CIDHospedaje
            // 
            this.CIDHospedaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDHospedaje.DataPropertyName = "IDHospedaje";
            this.CIDHospedaje.HeaderText = "#Reserva";
            this.CIDHospedaje.Name = "CIDHospedaje";
            this.CIDHospedaje.ReadOnly = true;
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
            this.CDiasHospedaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDiasHospedaje.DataPropertyName = "DiasHospedaje";
            this.CDiasHospedaje.HeaderText = "Días Hospedaje";
            this.CDiasHospedaje.Name = "CDiasHospedaje";
            this.CDiasHospedaje.ReadOnly = true;
            // 
            // CFechaEntrada
            // 
            this.CFechaEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CFechaEntrada.DataPropertyName = "FechaEntrada";
            this.CFechaEntrada.HeaderText = "Fecha Entrada";
            this.CFechaEntrada.Name = "CFechaEntrada";
            this.CFechaEntrada.ReadOnly = true;
            // 
            // CFechaSalida
            // 
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
            this.CTotal.Width = 138;
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.69533F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.30467F));
            this.tableLayoutPanel4.Controls.Add(this.cboxCliente, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.cboxHabitacion, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.txtCantNinos, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtIDHospedaje, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.txtCantAdultos, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtDiasHospedaje, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.dateEntrada, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.dateSalida, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.cboxPaquete, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.txtEstado, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.txtTotal, 1, 10);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(389, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 11;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 376);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // cboxCliente
            // 
            this.cboxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxCliente.DropDownHeight = 48;
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.IntegralHeight = false;
            this.cboxCliente.Location = new System.Drawing.Point(124, 311);
            this.cboxCliente.MaxDropDownItems = 4;
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(257, 24);
            this.cboxCliente.TabIndex = 9;
            // 
            // cboxHabitacion
            // 
            this.cboxHabitacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxHabitacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxHabitacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxHabitacion.DropDownHeight = 48;
            this.cboxHabitacion.FormattingEnabled = true;
            this.cboxHabitacion.IntegralHeight = false;
            this.cboxHabitacion.Location = new System.Drawing.Point(124, 275);
            this.cboxHabitacion.MaxDropDownItems = 4;
            this.cboxHabitacion.Name = "cboxHabitacion";
            this.cboxHabitacion.Size = new System.Drawing.Size(257, 24);
            this.cboxHabitacion.TabIndex = 8;
            this.cboxHabitacion.Leave += new System.EventHandler(this.cboxHabitacion_Leave_1);
            // 
            // txtCantNinos
            // 
            this.txtCantNinos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantNinos.Location = new System.Drawing.Point(124, 40);
            this.txtCantNinos.Name = "txtCantNinos";
            this.txtCantNinos.Size = new System.Drawing.Size(257, 22);
            this.txtCantNinos.TabIndex = 1;
            this.txtCantNinos.Text = "0";
            this.txtCantNinos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número Reserva";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad Niños";
            // 
            // txtIDHospedaje
            // 
            this.txtIDHospedaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDHospedaje.Location = new System.Drawing.Point(124, 6);
            this.txtIDHospedaje.Name = "txtIDHospedaje";
            this.txtIDHospedaje.ReadOnly = true;
            this.txtIDHospedaje.Size = new System.Drawing.Size(257, 22);
            this.txtIDHospedaje.TabIndex = 0;
            this.txtIDHospedaje.Text = " - -";
            this.txtIDHospedaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad Adultos";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Días Hospedajes";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha Entrada";
            // 
            // txtCantAdultos
            // 
            this.txtCantAdultos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantAdultos.Location = new System.Drawing.Point(124, 74);
            this.txtCantAdultos.Name = "txtCantAdultos";
            this.txtCantAdultos.Size = new System.Drawing.Size(257, 22);
            this.txtCantAdultos.TabIndex = 2;
            this.txtCantAdultos.Text = "0";
            this.txtCantAdultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantAdultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantAdultos_KeyPress);
            // 
            // txtDiasHospedaje
            // 
            this.txtDiasHospedaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiasHospedaje.Location = new System.Drawing.Point(124, 108);
            this.txtDiasHospedaje.Name = "txtDiasHospedaje";
            this.txtDiasHospedaje.ReadOnly = true;
            this.txtDiasHospedaje.Size = new System.Drawing.Size(257, 22);
            this.txtDiasHospedaje.TabIndex = 3;
            this.txtDiasHospedaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiasHospedaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasHospedaje_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fecha Salida";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Paquete";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Habitación";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Cliente";
            // 
            // dateEntrada
            // 
            this.dateEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEntrada.Location = new System.Drawing.Point(124, 139);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(257, 22);
            this.dateEntrada.TabIndex = 4;
            this.dateEntrada.Leave += new System.EventHandler(this.dateEntrada_Leave);
            // 
            // dateSalida
            // 
            this.dateSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateSalida.Location = new System.Drawing.Point(124, 173);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(257, 22);
            this.dateSalida.TabIndex = 5;
            this.dateSalida.Leave += new System.EventHandler(this.dateSalida_Leave);
            // 
            // cboxPaquete
            // 
            this.cboxPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxPaquete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxPaquete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxPaquete.BackColor = System.Drawing.SystemColors.Window;
            this.cboxPaquete.DropDownHeight = 48;
            this.cboxPaquete.FormattingEnabled = true;
            this.cboxPaquete.IntegralHeight = false;
            this.cboxPaquete.ItemHeight = 16;
            this.cboxPaquete.Location = new System.Drawing.Point(124, 243);
            this.cboxPaquete.MaxDropDownItems = 4;
            this.cboxPaquete.Name = "cboxPaquete";
            this.cboxPaquete.Size = new System.Drawing.Size(257, 24);
            this.cboxPaquete.TabIndex = 3;
            this.cboxPaquete.Leave += new System.EventHandler(this.cboxPaquete_Leave);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "Estado";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Location = new System.Drawing.Point(124, 210);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(257, 22);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.Text = "Pendiente";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(124, 347);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(257, 22);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(800, 126);
            this.panel3.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(384, 100);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.15711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.88529F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBuscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar :";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.Location = new System.Drawing.Point(63, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(129, 22);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelRiu.Properties.Resources.hospedaje;
            this.pictureBox1.Location = new System.Drawing.Point(198, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datos de los Hospedajes";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tableLayoutPanel5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 617);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(800, 94);
            this.panel6.TabIndex = 22;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnAgregar, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnModificar, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnEliminar, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnLimpiar, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnCancelar, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnFacturar, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtIDHabitacionTemporal, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(778, 72);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(3, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Reservar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(158, 39);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(313, 39);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(468, 39);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(623, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Opciones";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFacturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Location = new System.Drawing.Point(623, 3);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(152, 30);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtIDHabitacionTemporal
            // 
            this.txtIDHabitacionTemporal.Location = new System.Drawing.Point(468, 3);
            this.txtIDHabitacionTemporal.Name = "txtIDHabitacionTemporal";
            this.txtIDHabitacionTemporal.Size = new System.Drawing.Size(100, 26);
            this.txtIDHabitacionTemporal.TabIndex = 6;
            this.txtIDHabitacionTemporal.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Hospedajes";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Listado de Hospedajes  -->";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.chCancelados);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 172);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(800, 39);
            this.panel4.TabIndex = 24;
            // 
            // chCancelados
            // 
            this.chCancelados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chCancelados.AutoSize = true;
            this.chCancelados.Checked = true;
            this.chCancelados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chCancelados.Location = new System.Drawing.Point(350, 7);
            this.chCancelados.Name = "chCancelados";
            this.chCancelados.Size = new System.Drawing.Size(132, 24);
            this.chCancelados.TabIndex = 2;
            this.chCancelados.Text = "Cancelados?";
            this.chCancelados.UseVisualStyleBackColor = true;
            this.chCancelados.CheckedChanged += new System.EventHandler(this.chCancelados_CheckedChanged);
            // 
            // FrmHospedajesGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHospedajesGestion";
            this.Text = "Hospedajes Gestion";
            this.Load += new System.EventHandler(this.FrmHospedajesGestion_Load);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospedajes)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtCantNinos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDHospedaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantAdultos;
        private System.Windows.Forms.TextBox txtDiasHospedaje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.DateTimePicker dateSalida;
        private System.Windows.Forms.ComboBox cboxCliente;
        private System.Windows.Forms.ComboBox cboxHabitacion;
        private System.Windows.Forms.ComboBox cboxPaquete;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnFacturar;
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
        private System.Windows.Forms.TextBox txtIDHabitacionTemporal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chCancelados;
    }
}