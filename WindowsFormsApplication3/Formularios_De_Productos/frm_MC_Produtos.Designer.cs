namespace WindowsFormsApplication3
{
    partial class frm_MC_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MC_Produtos));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadporunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piNew = new System.Windows.Forms.PictureBox();
            this.cmb_Organizar = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Label();
            this.btnCategorias = new UIDC.UI_ShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategorias = new UIDC.UI_LabelTransparent();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uI_LabelTransparent1 = new UIDC.UI_LabelTransparent();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uI_LabelTransparent2 = new UIDC.UI_LabelTransparent();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new MetroFramework.Controls.MetroComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.picAgregarProducto = new System.Windows.Forms.PictureBox();
            this.notifica = new UIDC.UI_Notification();
            this.notifica_error = new UIDC.UI_Notification();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.uI_LabelTransparent3 = new UIDC.UI_LabelTransparent();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piNew)).BeginInit();
            this.btnCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uI_ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.uI_ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProducto)).BeginInit();
            this.uI_ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dataProductos);
            this.uI_ShadowPanel1.Controls.Add(this.piNew);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 86);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1197, 497);
            this.uI_ShadowPanel1.TabIndex = 1;
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToAddRows = false;
            this.dataProductos.AllowUserToDeleteRows = false;
            this.dataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmPrecioVenta,
            this.clmStock,
            this.clmCantidadporunidad,
            this.clmCategoria,
            this.clmIDCategoria,
            this.clmEstado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataProductos.EnableHeadersVisualStyles = false;
            this.dataProductos.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataProductos.Location = new System.Drawing.Point(26, 22);
            this.dataProductos.MultiSelect = false;
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductos.Size = new System.Drawing.Size(1146, 449);
            this.dataProductos.TabIndex = 0;
            this.dataProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProductos_CellDoubleClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "Producto_id_";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre_producto_";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmPrecioVenta
            // 
            this.clmPrecioVenta.DataPropertyName = "Precio_venta_";
            this.clmPrecioVenta.HeaderText = "Precio Venta";
            this.clmPrecioVenta.Name = "clmPrecioVenta";
            this.clmPrecioVenta.ReadOnly = true;
            // 
            // clmStock
            // 
            this.clmStock.DataPropertyName = "Stock_";
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            // 
            // clmCantidadporunidad
            // 
            this.clmCantidadporunidad.DataPropertyName = "Cantidad_por_unidad_";
            this.clmCantidadporunidad.HeaderText = "Cantidad por unidad";
            this.clmCantidadporunidad.Name = "clmCantidadporunidad";
            this.clmCantidadporunidad.ReadOnly = true;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Nombre_categoria_";
            this.clmCategoria.HeaderText = "Categoria";
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.ReadOnly = true;
            // 
            // clmIDCategoria
            // 
            this.clmIDCategoria.DataPropertyName = "Categoria_id_";
            this.clmIDCategoria.HeaderText = "ID Cate";
            this.clmIDCategoria.Name = "clmIDCategoria";
            this.clmIDCategoria.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.DataPropertyName = "Estado";
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // piNew
            // 
            this.piNew.BackColor = System.Drawing.Color.Transparent;
            this.piNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piNew.Image = ((System.Drawing.Image)(resources.GetObject("piNew.Image")));
            this.piNew.Location = new System.Drawing.Point(936, 222);
            this.piNew.Name = "piNew";
            this.piNew.Size = new System.Drawing.Size(50, 53);
            this.piNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piNew.TabIndex = 13;
            this.piNew.TabStop = false;
            this.piNew.Click += new System.EventHandler(this.piNew_Click);
            // 
            // cmb_Organizar
            // 
            this.cmb_Organizar.FormattingEnabled = true;
            this.cmb_Organizar.ItemHeight = 23;
            this.cmb_Organizar.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.cmb_Organizar.Location = new System.Drawing.Point(209, 37);
            this.cmb_Organizar.Name = "cmb_Organizar";
            this.cmb_Organizar.Size = new System.Drawing.Size(243, 29);
            this.cmb_Organizar.TabIndex = 5;
            this.cmb_Organizar.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Organizar:";
            // 
            // btncerrar
            // 
            this.btncerrar.AutoSize = true;
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold);
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncerrar.Location = new System.Drawing.Point(1184, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 38);
            this.btncerrar.TabIndex = 12;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.btnCategorias.Controls.Add(this.pictureBox1);
            this.btnCategorias.Controls.Add(this.lblCategorias);
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Location = new System.Drawing.Point(317, 604);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ParentControl = this;
            this.btnCategorias.Radius = 10;
            this.btnCategorias.ShadowColor = System.Drawing.Color.Black;
            this.btnCategorias.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnCategorias.Size = new System.Drawing.Size(283, 64);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.Color.Transparent;
            this.lblCategorias.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategorias.Location = new System.Drawing.Point(78, 11);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(119, 38);
            this.lblCategorias.TabIndex = 6;
            this.lblCategorias.Text = "Ofertas";
            this.lblCategorias.TransparentBackColor = System.Drawing.Color.Transparent;
            this.lblCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.uI_ShadowPanel2.Controls.Add(this.pictureBox2);
            this.uI_ShadowPanel2.Controls.Add(this.uI_LabelTransparent1);
            this.uI_ShadowPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(12, 604);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 10;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(283, 64);
            this.uI_ShadowPanel2.TabIndex = 6;
            this.uI_ShadowPanel2.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // uI_LabelTransparent1
            // 
            this.uI_LabelTransparent1.AutoSize = true;
            this.uI_LabelTransparent1.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent1.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_LabelTransparent1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uI_LabelTransparent1.Location = new System.Drawing.Point(78, 11);
            this.uI_LabelTransparent1.Name = "uI_LabelTransparent1";
            this.uI_LabelTransparent1.Size = new System.Drawing.Size(157, 38);
            this.uI_LabelTransparent1.TabIndex = 6;
            this.uI_LabelTransparent1.Text = "Recepcion";
            this.uI_LabelTransparent1.TransparentBackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent1.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.uI_ShadowPanel3.Controls.Add(this.pictureBox3);
            this.uI_ShadowPanel3.Controls.Add(this.uI_LabelTransparent2);
            this.uI_ShadowPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(623, 604);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.Radius = 10;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(283, 64);
            this.uI_ShadowPanel3.TabIndex = 6;
            this.uI_ShadowPanel3.Click += new System.EventHandler(this.uI_ShadowPanel3_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.uI_ShadowPanel3_Click_1);
            // 
            // uI_LabelTransparent2
            // 
            this.uI_LabelTransparent2.AutoSize = true;
            this.uI_LabelTransparent2.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent2.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_LabelTransparent2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uI_LabelTransparent2.Location = new System.Drawing.Point(78, 11);
            this.uI_LabelTransparent2.Name = "uI_LabelTransparent2";
            this.uI_LabelTransparent2.Size = new System.Drawing.Size(129, 38);
            this.uI_LabelTransparent2.TabIndex = 6;
            this.uI_LabelTransparent2.Text = "Combos";
            this.uI_LabelTransparent2.TransparentBackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent2.Click += new System.EventHandler(this.uI_ShadowPanel3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(876, 37);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(182, 22);
            this.txtBusqueda.TabIndex = 52;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.ItemHeight = 23;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Nombre",
            "Precio Venta",
            "Stock",
            "Cantidad por unidad",
            "Categoria"});
            this.cmb_Tipo.Location = new System.Drawing.Point(574, 34);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(221, 29);
            this.cmb_Tipo.TabIndex = 51;
            this.cmb_Tipo.UseSelectable = true;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(466, 22);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(102, 47);
            this.lbltipo.TabIndex = 50;
            this.lbltipo.Text = "Tipo:";
            // 
            // picAgregarProducto
            // 
            this.picAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.picAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("picAgregarProducto.Image")));
            this.picAgregarProducto.Location = new System.Drawing.Point(1105, 16);
            this.picAgregarProducto.Name = "picAgregarProducto";
            this.picAgregarProducto.Size = new System.Drawing.Size(50, 53);
            this.picAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregarProducto.TabIndex = 13;
            this.picAgregarProducto.TabStop = false;
            this.picAgregarProducto.Click += new System.EventHandler(this.picAgregarProducto_Click);
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
            this.notifica.Text = "Se eliminó el producto";
            this.notifica.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.TitleText = "PRODUCTO ELIMINADO";
            this.notifica.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // notifica_error
            // 
            this.notifica_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifica_error.CloseInterval = 5;
            this.notifica_error.EnabledNoti = false;
            this.notifica_error.Image = ((System.Drawing.Image)(resources.GetObject("notifica_error.Image")));
            this.notifica_error.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica_error.ImageElipse = true;
            this.notifica_error.ImageVisible = true;
            this.notifica_error.SoundEnabled = true;
            this.notifica_error.Text = "No se puede eliminar";
            this.notifica_error.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica_error.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica_error.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica_error.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica_error.TitleText = "Error al eliminar";
            this.notifica_error.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.uI_ShadowPanel4.Controls.Add(this.pictureBox4);
            this.uI_ShadowPanel4.Controls.Add(this.uI_LabelTransparent3);
            this.uI_ShadowPanel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(926, 604);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.Radius = 10;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(283, 64);
            this.uI_ShadowPanel4.TabIndex = 6;
            this.uI_ShadowPanel4.Click += new System.EventHandler(this.uI_ShadowPanel4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.uI_ShadowPanel3_Click_1);
            // 
            // uI_LabelTransparent3
            // 
            this.uI_LabelTransparent3.AutoSize = true;
            this.uI_LabelTransparent3.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent3.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_LabelTransparent3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uI_LabelTransparent3.Location = new System.Drawing.Point(78, 11);
            this.uI_LabelTransparent3.Name = "uI_LabelTransparent3";
            this.uI_LabelTransparent3.Size = new System.Drawing.Size(58, 38);
            this.uI_LabelTransparent3.TabIndex = 6;
            this.uI_LabelTransparent3.Text = "Iva";
            this.uI_LabelTransparent3.TransparentBackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent3.Click += new System.EventHandler(this.uI_ShadowPanel3_Click_1);
            // 
            // frm_MC_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1221, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.picAgregarProducto);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.cmb_Organizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MC_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MC_Produtos";
            this.Load += new System.EventHandler(this.frm_MC_Produtos_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piNew)).EndInit();
            this.btnCategorias.ResumeLayout(false);
            this.btnCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.uI_ShadowPanel3.ResumeLayout(false);
            this.uI_ShadowPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProducto)).EndInit();
            this.uI_ShadowPanel4.ResumeLayout(false);
            this.uI_ShadowPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dataProductos;
        private MetroFramework.Controls.MetroComboBox cmb_Organizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btncerrar;
        private UIDC.UI_ShadowPanel btnCategorias;
        private UIDC.UI_LabelTransparent lblCategorias;
        private System.Windows.Forms.PictureBox piNew;
        private System.Windows.Forms.PictureBox picAgregarProducto;
        private UIDC.UI_Notification notifica;
        private UIDC.UI_Notification notifica_error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UIDC.UI_LabelTransparent uI_LabelTransparent1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UIDC.UI_LabelTransparent uI_LabelTransparent2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadporunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private MetroFramework.Controls.MetroComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbltipo;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private UIDC.UI_LabelTransparent uI_LabelTransparent3;
    }
}