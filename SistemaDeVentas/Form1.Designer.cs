namespace SistemaDeVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LbLNtotal = new System.Windows.Forms.Label();
            this.LbLTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LBLTH = new System.Windows.Forms.Label();
            this.LBLHora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PmetodoDepago = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.LBLmpago = new System.Windows.Forms.Label();
            this.Lblcantidad = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PClientes = new System.Windows.Forms.ComboBox();
            this.LBLCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Dcantidad = new System.Windows.Forms.Label();
            this.LblCantidadStock = new System.Windows.Forms.Label();
            this.Dprecio = new System.Windows.Forms.Label();
            this.LBLprecio = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnEliminarlista = new System.Windows.Forms.Button();
            this.DataTableLista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEnlistar = new System.Windows.Forms.Button();
            this.Pproductos = new System.Windows.Forms.ComboBox();
            this.lblT = new System.Windows.Forms.Label();
            this.LBLFecha = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.LBLCajero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbLNtotal
            // 
            this.LbLNtotal.AutoSize = true;
            this.LbLNtotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbLNtotal.Location = new System.Drawing.Point(68, 277);
            this.LbLNtotal.Name = "LbLNtotal";
            this.LbLNtotal.Size = new System.Drawing.Size(50, 23);
            this.LbLNtotal.TabIndex = 10;
            this.LbLNtotal.Text = "Total:";
            // 
            // LbLTotal
            // 
            this.LbLTotal.AutoSize = true;
            this.LbLTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbLTotal.Location = new System.Drawing.Point(3, 270);
            this.LbLTotal.Name = "LbLTotal";
            this.LbLTotal.Size = new System.Drawing.Size(68, 31);
            this.LbLTotal.TabIndex = 9;
            this.LbLTotal.Text = "Total:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LBLTH);
            this.panel4.Controls.Add(this.LBLHora);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 703);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1387, 101);
            this.panel4.TabIndex = 4;
            // 
            // LBLTH
            // 
            this.LBLTH.AutoSize = true;
            this.LBLTH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLTH.Location = new System.Drawing.Point(576, 45);
            this.LBLTH.Name = "LBLTH";
            this.LBLTH.Size = new System.Drawing.Size(76, 31);
            this.LBLTH.TabIndex = 6;
            this.LBLTH.Text = "label2";
            // 
            // LBLHora
            // 
            this.LBLHora.AutoSize = true;
            this.LBLHora.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLHora.Location = new System.Drawing.Point(484, 34);
            this.LBLHora.Name = "LBLHora";
            this.LBLHora.Size = new System.Drawing.Size(97, 45);
            this.LBLHora.TabIndex = 5;
            this.LBLHora.Text = "Hora:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1387, 323);
            this.panel3.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1387, 323);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 317);
            this.panel6.TabIndex = 0;
            // 
            // PmetodoDepago
            // 
            this.PmetodoDepago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.PmetodoDepago.FormattingEnabled = true;
            this.PmetodoDepago.Location = new System.Drawing.Point(13, 112);
            this.PmetodoDepago.Name = "PmetodoDepago";
            this.PmetodoDepago.Size = new System.Drawing.Size(323, 28);
            this.PmetodoDepago.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.Location = new System.Drawing.Point(12, 10);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(254, 31);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Seleccione un producto";
            // 
            // LBLmpago
            // 
            this.LBLmpago.AutoSize = true;
            this.LBLmpago.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLmpago.Location = new System.Drawing.Point(13, 78);
            this.LBLmpago.Name = "LBLmpago";
            this.LBLmpago.Size = new System.Drawing.Size(323, 31);
            this.LBLmpago.TabIndex = 4;
            this.LBLmpago.Text = "Seleccione el metodo de pago";
            // 
            // Lblcantidad
            // 
            this.Lblcantidad.AutoSize = true;
            this.Lblcantidad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lblcantidad.Location = new System.Drawing.Point(359, 14);
            this.Lblcantidad.Name = "Lblcantidad";
            this.Lblcantidad.Size = new System.Drawing.Size(112, 31);
            this.Lblcantidad.TabIndex = 5;
            this.Lblcantidad.Text = "Cantidad:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(441, 177);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(94, 52);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Registrar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.BtnGuardar.MouseLeave += new System.EventHandler(this.BtnGuardar_MouseLeave);
            this.BtnGuardar.MouseHover += new System.EventHandler(this.BtnGuardar_MouseHover);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCancelar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTNCancelar.ForeColor = System.Drawing.Color.White;
            this.BTNCancelar.Location = new System.Drawing.Point(513, 102);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(94, 52);
            this.BTNCancelar.TabIndex = 7;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = false;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            this.BTNCancelar.MouseLeave += new System.EventHandler(this.BTNCancelar_MouseLeave);
            this.BTNCancelar.MouseHover += new System.EventHandler(this.BTNCancelar_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(359, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 27);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // PClientes
            // 
            this.PClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PClientes.FormattingEnabled = true;
            this.PClientes.Location = new System.Drawing.Point(13, 177);
            this.PClientes.Name = "PClientes";
            this.PClientes.Size = new System.Drawing.Size(323, 28);
            this.PClientes.TabIndex = 10;
            // 
            // LBLCliente
            // 
            this.LBLCliente.AutoSize = true;
            this.LBLCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLCliente.Location = new System.Drawing.Point(13, 143);
            this.LBLCliente.Name = "LBLCliente";
            this.LBLCliente.Size = new System.Drawing.Size(220, 31);
            this.LBLCliente.TabIndex = 11;
            this.LBLCliente.Text = "Seleccione el cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Dcantidad);
            this.panel2.Controls.Add(this.LblCantidadStock);
            this.panel2.Controls.Add(this.Dprecio);
            this.panel2.Controls.Add(this.LBLprecio);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.BtnEnlistar);
            this.panel2.Controls.Add(this.Pproductos);
            this.panel2.Controls.Add(this.LBLCliente);
            this.panel2.Controls.Add(this.PClientes);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.BTNCancelar);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.Lblcantidad);
            this.panel2.Controls.Add(this.LBLmpago);
            this.panel2.Controls.Add(this.lblProducto);
            this.panel2.Controls.Add(this.PmetodoDepago);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1387, 309);
            this.panel2.TabIndex = 2;
            // 
            // Dcantidad
            // 
            this.Dcantidad.AutoSize = true;
            this.Dcantidad.Location = new System.Drawing.Point(183, 268);
            this.Dcantidad.Name = "Dcantidad";
            this.Dcantidad.Size = new System.Drawing.Size(50, 20);
            this.Dcantidad.TabIndex = 21;
            this.Dcantidad.Text = "label2";
            // 
            // LblCantidadStock
            // 
            this.LblCantidadStock.AutoSize = true;
            this.LblCantidadStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantidadStock.Location = new System.Drawing.Point(13, 261);
            this.LblCantidadStock.Name = "LblCantidadStock";
            this.LblCantidadStock.Size = new System.Drawing.Size(172, 28);
            this.LblCantidadStock.TabIndex = 20;
            this.LblCantidadStock.Text = "Cantidad en stock:";
            // 
            // Dprecio
            // 
            this.Dprecio.AutoSize = true;
            this.Dprecio.Location = new System.Drawing.Point(89, 230);
            this.Dprecio.Name = "Dprecio";
            this.Dprecio.Size = new System.Drawing.Size(50, 20);
            this.Dprecio.TabIndex = 19;
            this.Dprecio.Text = "label2";
            // 
            // LBLprecio
            // 
            this.LBLprecio.AutoSize = true;
            this.LBLprecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLprecio.Location = new System.Drawing.Point(13, 223);
            this.LBLprecio.Name = "LBLprecio";
            this.LBLprecio.Size = new System.Drawing.Size(70, 28);
            this.LBLprecio.TabIndex = 18;
            this.LBLprecio.Text = "Precio:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnEliminarlista);
            this.panel5.Controls.Add(this.DataTableLista);
            this.panel5.Controls.Add(this.LbLNtotal);
            this.panel5.Controls.Add(this.LbLTotal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(641, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(746, 309);
            this.panel5.TabIndex = 17;
            // 
            // BtnEliminarlista
            // 
            this.BtnEliminarlista.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminarlista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminarlista.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarlista.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarlista.Location = new System.Drawing.Point(440, 271);
            this.BtnEliminarlista.Name = "BtnEliminarlista";
            this.BtnEliminarlista.Size = new System.Drawing.Size(206, 32);
            this.BtnEliminarlista.TabIndex = 5;
            this.BtnEliminarlista.Text = "Eliminar de la lista";
            this.BtnEliminarlista.UseVisualStyleBackColor = false;
            this.BtnEliminarlista.Click += new System.EventHandler(this.BtnEliminarlista_Click);
            // 
            // DataTableLista
            // 
            this.DataTableLista.AllowUserToAddRows = false;
            this.DataTableLista.AllowUserToDeleteRows = false;
            this.DataTableLista.AllowUserToOrderColumns = true;
            this.DataTableLista.BackgroundColor = System.Drawing.Color.White;
            this.DataTableLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Cantidad,
            this.Tipo,
            this.Precio,
            this.Total});
            this.DataTableLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataTableLista.Location = new System.Drawing.Point(0, 0);
            this.DataTableLista.MultiSelect = false;
            this.DataTableLista.Name = "DataTableLista";
            this.DataTableLista.ReadOnly = true;
            this.DataTableLista.RowHeadersWidth = 51;
            this.DataTableLista.RowTemplate.Height = 29;
            this.DataTableLista.Size = new System.Drawing.Size(746, 267);
            this.DataTableLista.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // BtnEnlistar
            // 
            this.BtnEnlistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnEnlistar.FlatAppearance.BorderSize = 0;
            this.BtnEnlistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEnlistar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEnlistar.ForeColor = System.Drawing.Color.White;
            this.BtnEnlistar.Location = new System.Drawing.Point(377, 102);
            this.BtnEnlistar.Name = "BtnEnlistar";
            this.BtnEnlistar.Size = new System.Drawing.Size(94, 52);
            this.BtnEnlistar.TabIndex = 16;
            this.BtnEnlistar.Text = "Enlistar";
            this.BtnEnlistar.UseVisualStyleBackColor = false;
            this.BtnEnlistar.Click += new System.EventHandler(this.BtnEnlistar_Click);
            // 
            // Pproductos
            // 
            this.Pproductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.Pproductos.FormattingEnabled = true;
            this.Pproductos.Location = new System.Drawing.Point(13, 47);
            this.Pproductos.Name = "Pproductos";
            this.Pproductos.Size = new System.Drawing.Size(323, 28);
            this.Pproductos.TabIndex = 15;
            this.Pproductos.SelectedIndexChanged += new System.EventHandler(this.Pproductos_SelectedIndexChanged_1);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblT.Location = new System.Drawing.Point(279, 9);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(327, 53);
            this.lblT.TabIndex = 0;
            this.lblT.Text = "Registro de venta";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLFecha
            // 
            this.LBLFecha.AutoSize = true;
            this.LBLFecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLFecha.Location = new System.Drawing.Point(1226, 9);
            this.LBLFecha.Name = "LBLFecha";
            this.LBLFecha.Size = new System.Drawing.Size(59, 25);
            this.LBLFecha.TabIndex = 1;
            this.LBLFecha.Text = "label1";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblF.Location = new System.Drawing.Point(1169, 9);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(61, 25);
            this.lblF.TabIndex = 2;
            this.lblF.Text = "Fecha:";
            // 
            // LBLCajero
            // 
            this.LBLCajero.AutoSize = true;
            this.LBLCajero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLCajero.Location = new System.Drawing.Point(12, 34);
            this.LBLCajero.Name = "LBLCajero";
            this.LBLCajero.Size = new System.Drawing.Size(46, 17);
            this.LBLCajero.TabIndex = 3;
            this.LBLCajero.Text = "Cajero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persona en caja:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LBLCajero);
            this.panel1.Controls.Add(this.lblF);
            this.panel1.Controls.Add(this.LBLFecha);
            this.panel1.Controls.Add(this.lblT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 68);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 804);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel4;
        private Label LbLNtotal;
        private Label LbLTotal;
        private Panel panel3;
        private ComboBox PmetodoDepago;
        private Label lblProducto;
        private Label LBLmpago;
        private Label Lblcantidad;
        private Button BtnGuardar;
        private Button BTNCancelar;
        private TextBox textBox1;
        private ComboBox PClientes;
        private Label LBLCliente;
        private Panel panel2;
        private Label lblT;
        private Label LBLFecha;
        private Label lblF;
        private Label LBLCajero;
        private Label label1;
        private Panel panel1;
        private ComboBox Pproductos;
        private Button BtnEnlistar;
        private Label Dcantidad;
        private Label LblCantidadStock;
        private Label Dprecio;
        private Label LBLprecio;
        private DataGridView DataTableLista;
        private Panel panel5;
        private Button BtnEliminarlista;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Label LBLTH;
        private Label LBLHora;
        private System.Windows.Forms.Timer timer1;
    }
}