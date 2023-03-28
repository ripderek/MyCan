namespace WindowsFormsApplication3
{
    partial class frmFacturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnFacturar = new UIDC.UI_ShadowPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_lispro = new System.Windows.Forms.Panel();
            this.listaProductos = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new UIDC.UI_ShadowPanel();
            this.lblBtn = new System.Windows.Forms.Label();
            this.btnGuardar = new UIDC.UI_ShadowPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel8 = new UIDC.UI_ShadowPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferta_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_oculto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.toggle_cliente = new UIDC.UI_MaterialToggle();
            this.label10 = new System.Windows.Forms.Label();
            this.notifica = new UIDC.UI_Notification();
            this.panel_Cliente = new System.Windows.Forms.Panel();
            this.dtgvCliente = new System.Windows.Forms.DataGridView();
            this.uI_ShadowPanel6 = new UIDC.UI_ShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuentoGe = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.panel_Iva = new System.Windows.Forms.Panel();
            this.dtIva = new System.Windows.Forms.DataGridView();
            this.btnFacturar.SuspendLayout();
            this.panel_lispro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).BeginInit();
            this.btnAñadir.SuspendLayout();
            this.btnGuardar.SuspendLayout();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            this.panel_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).BeginInit();
            this.uI_ShadowPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Iva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtIva)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(48, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 47);
            this.label4.TabIndex = 31;
            this.label4.Text = "Factura";
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnFacturar.Controls.Add(this.label11);
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.Location = new System.Drawing.Point(1102, 6);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.ParentControl = this;
            this.btnFacturar.Radius = 10;
            this.btnFacturar.ShadowColor = System.Drawing.Color.Black;
            this.btnFacturar.ShadowDepth = 2;
            this.btnFacturar.ShadowShift = 8;
            this.btnFacturar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnFacturar.Size = new System.Drawing.Size(136, 54);
            this.btnFacturar.TabIndex = 35;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Facturar";
            this.label11.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // panel_lispro
            // 
            this.panel_lispro.AutoScroll = true;
            this.panel_lispro.Controls.Add(this.listaProductos);
            this.panel_lispro.Location = new System.Drawing.Point(190, 506);
            this.panel_lispro.Name = "panel_lispro";
            this.panel_lispro.Size = new System.Drawing.Size(406, 83);
            this.panel_lispro.TabIndex = 38;
            this.panel_lispro.Visible = false;
            // 
            // listaProductos
            // 
            this.listaProductos.AllowUserToAddRows = false;
            this.listaProductos.AllowUserToDeleteRows = false;
            this.listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.listaProductos.BackgroundColor = System.Drawing.Color.Snow;
            this.listaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listaProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.listaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaProductos.ColumnHeadersHeight = 90;
            this.listaProductos.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.listaProductos.EnableHeadersVisualStyles = false;
            this.listaProductos.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.listaProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listaProductos.Location = new System.Drawing.Point(0, 0);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.ReadOnly = true;
            this.listaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listaProductos.RowHeadersWidth = 20;
            this.listaProductos.Size = new System.Drawing.Size(406, 83);
            this.listaProductos.TabIndex = 35;
            this.listaProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaProductos_CellDoubleClick);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.btnAñadir.Controls.Add(this.lblBtn);
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAñadir.Location = new System.Drawing.Point(598, 535);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.ParentControl = this;
            this.btnAñadir.Radius = 10;
            this.btnAñadir.ShadowColor = System.Drawing.Color.Black;
            this.btnAñadir.ShadowDepth = 50;
            this.btnAñadir.ShadowShift = 8;
            this.btnAñadir.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnAñadir.Size = new System.Drawing.Size(136, 58);
            this.btnAñadir.TabIndex = 29;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblBtn
            // 
            this.lblBtn.AutoSize = true;
            this.lblBtn.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtn.ForeColor = System.Drawing.Color.Black;
            this.lblBtn.Location = new System.Drawing.Point(32, 15);
            this.lblBtn.Name = "lblBtn";
            this.lblBtn.Size = new System.Drawing.Size(75, 28);
            this.lblBtn.TabIndex = 0;
            this.lblBtn.Text = "Añadir";
            this.lblBtn.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.btnGuardar.Controls.Add(this.label12);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(598, 534);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ParentControl = this;
            this.btnGuardar.Radius = 10;
            this.btnGuardar.ShadowColor = System.Drawing.Color.Black;
            this.btnGuardar.ShadowDepth = 50;
            this.btnGuardar.ShadowShift = 8;
            this.btnGuardar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnGuardar.Size = new System.Drawing.Size(136, 58);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Guardar";
            this.label12.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(193, 475);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(403, 28);
            this.txtProducto.TabIndex = 16;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(51, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Producto:";
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(190, 482);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(411, 29);
            this.uI_ShadowPanel2.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(196, 545);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(152, 28);
            this.txtCantidad.TabIndex = 19;
            // 
            // uI_ShadowPanel8
            // 
            this.uI_ShadowPanel8.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel8.Location = new System.Drawing.Point(193, 551);
            this.uI_ShadowPanel8.Name = "uI_ShadowPanel8";
            this.uI_ShadowPanel8.ParentControl = this;
            this.uI_ShadowPanel8.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel8.ShadowDepth = 50;
            this.uI_ShadowPanel8.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel8.Size = new System.Drawing.Size(160, 29);
            this.uI_ShadowPanel8.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(51, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad:";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(346, 22);
            this.txtCliente.MaxLength = 50;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(338, 28);
            this.txtCliente.TabIndex = 19;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(343, 28);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(341, 29);
            this.uI_ShadowPanel4.TabIndex = 18;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.AutoScroll = true;
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dtg_Productos);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 56);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowShift = 10;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1229, 402);
            this.uI_ShadowPanel1.TabIndex = 33;
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtg_Productos.AllowUserToAddRows = false;
            this.dtg_Productos.AllowUserToDeleteRows = false;
            this.dtg_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_Productos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.oferta_producto,
            this.product_price,
            this.quantity,
            this.producto_total,
            this.precio_oculto});
            this.dtg_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_Productos.EnableHeadersVisualStyles = false;
            this.dtg_Productos.Location = new System.Drawing.Point(44, 17);
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.ReadOnly = true;
            this.dtg_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_Productos.Size = new System.Drawing.Size(1138, 367);
            this.dtg_Productos.TabIndex = 1;
            this.dtg_Productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Productos_CellDoubleClick);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "ID";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Producto";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // oferta_producto
            // 
            this.oferta_producto.HeaderText = "Oferta";
            this.oferta_producto.Name = "oferta_producto";
            this.oferta_producto.ReadOnly = true;
            // 
            // product_price
            // 
            this.product_price.HeaderText = "Precio";
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // producto_total
            // 
            this.producto_total.HeaderText = "Total";
            this.producto_total.Name = "producto_total";
            this.producto_total.ReadOnly = true;
            // 
            // precio_oculto
            // 
            this.precio_oculto.HeaderText = "oculto";
            this.precio_oculto.Name = "precio_oculto";
            this.precio_oculto.ReadOnly = true;
            this.precio_oculto.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(255, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cliente:";
            // 
            // toggle_cliente
            // 
            this.toggle_cliente.AutoSize = true;
            this.toggle_cliente.EllipseBorderColor = "#3b73d1";
            this.toggle_cliente.EllipseColor = "#508ef5";
            this.toggle_cliente.Location = new System.Drawing.Point(883, 29);
            this.toggle_cliente.Name = "toggle_cliente";
            this.toggle_cliente.Size = new System.Drawing.Size(47, 19);
            this.toggle_cliente.TabIndex = 38;
            this.toggle_cliente.Text = "uI_MaterialToggle1";
            this.toggle_cliente.UseVisualStyleBackColor = true;
            this.toggle_cliente.CheckedChanged += new System.EventHandler(this.toggle_cliente_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(711, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 27);
            this.label10.TabIndex = 17;
            this.label10.Text = "Consumidor Final";
            // 
            // notifica
            // 
            this.notifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifica.CloseInterval = 5;
            this.notifica.EnabledNoti = false;
            this.notifica.Image = ((System.Drawing.Image)(resources.GetObject("notifica.Image")));
            this.notifica.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.ImageElipse = true;
            this.notifica.ImageVisible = true;
            this.notifica.SoundEnabled = true;
            this.notifica.Text = "Se registró la venta";
            this.notifica.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.TitleText = "FACTURA REALIZADA";
            this.notifica.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // panel_Cliente
            // 
            this.panel_Cliente.AutoScroll = true;
            this.panel_Cliente.Controls.Add(this.dtgvCliente);
            this.panel_Cliente.Location = new System.Drawing.Point(327, 46);
            this.panel_Cliente.Name = "panel_Cliente";
            this.panel_Cliente.Size = new System.Drawing.Size(341, 83);
            this.panel_Cliente.TabIndex = 39;
            this.panel_Cliente.Visible = false;
            // 
            // dtgvCliente
            // 
            this.dtgvCliente.AllowUserToAddRows = false;
            this.dtgvCliente.AllowUserToDeleteRows = false;
            this.dtgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvCliente.BackgroundColor = System.Drawing.Color.Snow;
            this.dtgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvCliente.ColumnHeadersHeight = 90;
            this.dtgvCliente.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvCliente.EnableHeadersVisualStyles = false;
            this.dtgvCliente.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvCliente.Location = new System.Drawing.Point(0, 0);
            this.dtgvCliente.Name = "dtgvCliente";
            this.dtgvCliente.ReadOnly = true;
            this.dtgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvCliente.RowHeadersWidth = 20;
            this.dtgvCliente.Size = new System.Drawing.Size(338, 83);
            this.dtgvCliente.TabIndex = 35;
            this.dtgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCliente_CellDoubleClick);
            // 
            // uI_ShadowPanel6
            // 
            this.uI_ShadowPanel6.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel6.Controls.Add(this.pictureBox1);
            this.uI_ShadowPanel6.Controls.Add(this.label8);
            this.uI_ShadowPanel6.Controls.Add(this.label9);
            this.uI_ShadowPanel6.Controls.Add(this.label2);
            this.uI_ShadowPanel6.Controls.Add(this.label3);
            this.uI_ShadowPanel6.Controls.Add(this.txtTotalTotal);
            this.uI_ShadowPanel6.Controls.Add(this.txtTotal);
            this.uI_ShadowPanel6.Controls.Add(this.txtDescuentoGe);
            this.uI_ShadowPanel6.Controls.Add(this.txtSubtotal);
            this.uI_ShadowPanel6.Location = new System.Drawing.Point(740, 446);
            this.uI_ShadowPanel6.Name = "uI_ShadowPanel6";
            this.uI_ShadowPanel6.ParentControl = this;
            this.uI_ShadowPanel6.Radius = 15;
            this.uI_ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel6.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel6.Size = new System.Drawing.Size(498, 174);
            this.uI_ShadowPanel6.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(38, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 27);
            this.label8.TabIndex = 17;
            this.label8.Text = "Iva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(38, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Subtotal";
            // 
            // txtTotalTotal
            // 
            this.txtTotalTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalTotal.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTotal.Location = new System.Drawing.Point(170, 118);
            this.txtTotalTotal.MaxLength = 50;
            this.txtTotalTotal.Name = "txtTotalTotal";
            this.txtTotalTotal.ReadOnly = true;
            this.txtTotalTotal.Size = new System.Drawing.Size(239, 28);
            this.txtTotalTotal.TabIndex = 19;
            this.txtTotalTotal.Text = "0,00";
            this.txtTotalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(170, 82);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(239, 28);
            this.txtTotal.TabIndex = 19;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtDescuentoGe
            // 
            this.txtDescuentoGe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescuentoGe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuentoGe.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoGe.Location = new System.Drawing.Point(170, 49);
            this.txtDescuentoGe.MaxLength = 3;
            this.txtDescuentoGe.Name = "txtDescuentoGe";
            this.txtDescuentoGe.Size = new System.Drawing.Size(239, 28);
            this.txtDescuentoGe.TabIndex = 19;
            this.txtDescuentoGe.Text = "0";
            this.txtDescuentoGe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(170, 18);
            this.txtSubtotal.MaxLength = 50;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(239, 28);
            this.txtSubtotal.TabIndex = 19;
            this.txtSubtotal.Text = "0,00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel_Iva
            // 
            this.panel_Iva.AutoScroll = true;
            this.panel_Iva.Controls.Add(this.dtIva);
            this.panel_Iva.Location = new System.Drawing.Point(912, 559);
            this.panel_Iva.Name = "panel_Iva";
            this.panel_Iva.Size = new System.Drawing.Size(239, 83);
            this.panel_Iva.TabIndex = 41;
            this.panel_Iva.Visible = false;
            // 
            // dtIva
            // 
            this.dtIva.AllowUserToAddRows = false;
            this.dtIva.AllowUserToDeleteRows = false;
            this.dtIva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtIva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtIva.BackgroundColor = System.Drawing.Color.Snow;
            this.dtIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtIva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtIva.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtIva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtIva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtIva.ColumnHeadersHeight = 90;
            this.dtIva.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtIva.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtIva.EnableHeadersVisualStyles = false;
            this.dtIva.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtIva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtIva.Location = new System.Drawing.Point(0, 0);
            this.dtIva.Name = "dtIva";
            this.dtIva.ReadOnly = true;
            this.dtIva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtIva.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtIva.RowHeadersWidth = 20;
            this.dtIva.Size = new System.Drawing.Size(239, 83);
            this.dtIva.TabIndex = 35;
            this.dtIva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtIva_CellDoubleClick);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 673);
            this.Controls.Add(this.panel_Iva);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel_lispro);
            this.Controls.Add(this.uI_ShadowPanel8);
            this.Controls.Add(this.panel_Cliente);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggle_cliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.btnFacturar.ResumeLayout(false);
            this.btnFacturar.PerformLayout();
            this.panel_lispro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaProductos)).EndInit();
            this.btnAñadir.ResumeLayout(false);
            this.btnAñadir.PerformLayout();
            this.btnGuardar.ResumeLayout(false);
            this.btnGuardar.PerformLayout();
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            this.panel_Cliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).EndInit();
            this.uI_ShadowPanel6.ResumeLayout(false);
            this.uI_ShadowPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Iva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtIva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_ShadowPanel btnFacturar;
        private System.Windows.Forms.Label label11;
        private UIDC.UI_ShadowPanel btnAñadir;
        private System.Windows.Forms.Label lblBtn;
        private UIDC.UI_ShadowPanel btnGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.TextBox txtCantidad;
        private UIDC.UI_ShadowPanel uI_ShadowPanel8;
        private System.Windows.Forms.TextBox txtCliente;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.Label label7;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dtg_Productos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_lispro;
        private System.Windows.Forms.DataGridView listaProductos;
        private UIDC.UI_MaterialToggle toggle_cliente;
        private System.Windows.Forms.Label label10;
        private UIDC.UI_Notification notifica;
        private System.Windows.Forms.Panel panel_Cliente;
        private System.Windows.Forms.DataGridView dtgvCliente;
        private UIDC.UI_ShadowPanel uI_ShadowPanel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuentoGe;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Panel panel_Iva;
        private System.Windows.Forms.DataGridView dtIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn oferta_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_oculto;
    }
}