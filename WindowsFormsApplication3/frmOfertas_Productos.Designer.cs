namespace WindowsFormsApplication3
{
    partial class frmOfertas_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfertas_Productos));
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Ofertas = new System.Windows.Forms.DataGridView();
            this.panel_citas_programadas = new UIDC.UI_ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.datetime_Inicio = new MetroFramework.Controls.MetroDateTime();
            this.datetime_Fin = new MetroFramework.Controls.MetroDateTime();
            this.btnRegistrar = new UIDC.UI_ShadowPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_productos = new System.Windows.Forms.Panel();
            this.dtproductos = new System.Windows.Forms.DataGridView();
            this.notifica = new UIDC.UI_Notification();
            this.notifica_error = new UIDC.UI_Notification();
            this.txtNombreVEREDITAR = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ofertas)).BeginInit();
            this.panel_citas_programadas.SuspendLayout();
            this.btnRegistrar.SuspendLayout();
            this.panel_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtproductos)).BeginInit();
            this.uI_ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uI_TitleBanner1
            // 
            this.uI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateOFF;
            this.uI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff;
            this.uI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close;
            this.uI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uI_TitleBanner1.FlatAppearance.BorderSize = 0;
            this.uI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uI_TitleBanner1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.uI_TitleBanner1.ForeColor = System.Drawing.Color.White;
            this.uI_TitleBanner1.Location = new System.Drawing.Point(0, 0);
            this.uI_TitleBanner1.MoveActive = true;
            this.uI_TitleBanner1.Name = "uI_TitleBanner1";
            this.uI_TitleBanner1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uI_TitleBanner1.ParentControl = this;
            this.uI_TitleBanner1.Size = new System.Drawing.Size(891, 30);
            this.uI_TitleBanner1.TabIndex = 4;
            this.uI_TitleBanner1.Text = "OFERTAS";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(58, 514);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(442, 28);
            this.txtProducto.TabIndex = 35;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(55, 520);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(450, 29);
            this.uI_ShadowPanel3.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(32, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Producto:";
            // 
            // dtg_Ofertas
            // 
            this.dtg_Ofertas.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtg_Ofertas.AllowUserToAddRows = false;
            this.dtg_Ofertas.AllowUserToDeleteRows = false;
            this.dtg_Ofertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Ofertas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_Ofertas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_Ofertas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Ofertas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_Ofertas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Ofertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_Ofertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Ofertas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_Ofertas.EnableHeadersVisualStyles = false;
            this.dtg_Ofertas.Location = new System.Drawing.Point(25, 19);
            this.dtg_Ofertas.Name = "dtg_Ofertas";
            this.dtg_Ofertas.ReadOnly = true;
            this.dtg_Ofertas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Ofertas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_Ofertas.Size = new System.Drawing.Size(810, 303);
            this.dtg_Ofertas.TabIndex = 0;
            this.dtg_Ofertas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Ofertas_CellDoubleClick);
            this.dtg_Ofertas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Ofertas_CellMouseClick);
            this.dtg_Ofertas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtg_Ofertas_MouseDown);
            // 
            // panel_citas_programadas
            // 
            this.panel_citas_programadas.BaseColor = System.Drawing.SystemColors.Window;
            this.panel_citas_programadas.Controls.Add(this.dtg_Ofertas);
            this.panel_citas_programadas.Location = new System.Drawing.Point(12, 78);
            this.panel_citas_programadas.Name = "panel_citas_programadas";
            this.panel_citas_programadas.ParentControl = this;
            this.panel_citas_programadas.Radius = 10;
            this.panel_citas_programadas.ShadowColor = System.Drawing.Color.Black;
            this.panel_citas_programadas.ShadowShift = 10;
            this.panel_citas_programadas.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.panel_citas_programadas.Size = new System.Drawing.Size(865, 344);
            this.panel_citas_programadas.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 47);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ofertas Actuales:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 47);
            this.label1.TabIndex = 37;
            this.label1.Text = "Oferta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(516, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descuento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(707, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(32, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(376, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Fecha Fin:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(539, 514);
            this.txtDescuento.MaxLength = 3;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(139, 28);
            this.txtDescuento.TabIndex = 62;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescipcion_TextChanged);
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(536, 520);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(147, 29);
            this.uI_ShadowPanel4.TabIndex = 61;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(730, 520);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(147, 29);
            this.uI_ShadowPanel1.TabIndex = 61;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(733, 514);
            this.txtCantidad.MaxLength = 3;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 28);
            this.txtCantidad.TabIndex = 62;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtDescipcion_TextChanged);
            // 
            // datetime_Inicio
            // 
            this.datetime_Inicio.Location = new System.Drawing.Point(58, 608);
            this.datetime_Inicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetime_Inicio.Name = "datetime_Inicio";
            this.datetime_Inicio.Size = new System.Drawing.Size(322, 29);
            this.datetime_Inicio.TabIndex = 63;
            // 
            // datetime_Fin
            // 
            this.datetime_Fin.Location = new System.Drawing.Point(397, 608);
            this.datetime_Fin.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetime_Fin.Name = "datetime_Fin";
            this.datetime_Fin.Size = new System.Drawing.Size(322, 29);
            this.datetime_Fin.TabIndex = 63;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnRegistrar.Controls.Add(this.label8);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(736, 592);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.ParentControl = this;
            this.btnRegistrar.Radius = 7;
            this.btnRegistrar.ShadowColor = System.Drawing.Color.Black;
            this.btnRegistrar.ShadowDepth = 50;
            this.btnRegistrar.ShadowShift = 8;
            this.btnRegistrar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnRegistrar.Size = new System.Drawing.Size(136, 54);
            this.btnRegistrar.TabIndex = 69;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Crear";
            // 
            // panel_productos
            // 
            this.panel_productos.AutoScroll = true;
            this.panel_productos.Controls.Add(this.dtproductos);
            this.panel_productos.Location = new System.Drawing.Point(57, 544);
            this.panel_productos.Name = "panel_productos";
            this.panel_productos.Size = new System.Drawing.Size(441, 83);
            this.panel_productos.TabIndex = 70;
            this.panel_productos.Visible = false;
            // 
            // dtproductos
            // 
            this.dtproductos.AllowUserToAddRows = false;
            this.dtproductos.AllowUserToDeleteRows = false;
            this.dtproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtproductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtproductos.BackgroundColor = System.Drawing.Color.Snow;
            this.dtproductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtproductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtproductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtproductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtproductos.ColumnHeadersHeight = 90;
            this.dtproductos.ColumnHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtproductos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtproductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtproductos.EnableHeadersVisualStyles = false;
            this.dtproductos.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtproductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtproductos.Location = new System.Drawing.Point(0, 0);
            this.dtproductos.Name = "dtproductos";
            this.dtproductos.ReadOnly = true;
            this.dtproductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtproductos.RowHeadersWidth = 20;
            this.dtproductos.Size = new System.Drawing.Size(441, 83);
            this.dtproductos.TabIndex = 35;
            this.dtproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtproductos_CellContentClick);
            this.dtproductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtproductos_CellDoubleClick);
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
            this.notifica.Text = "Se registró una oferta";
            this.notifica.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.TitleText = "NUEVA OFERTA";
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
            this.notifica_error.Text = "Error al Registrar";
            this.notifica_error.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica_error.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica_error.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica_error.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica_error.TitleText = "ERROR";
            this.notifica_error.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // txtNombreVEREDITAR
            // 
            this.txtNombreVEREDITAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreVEREDITAR.Enabled = false;
            this.txtNombreVEREDITAR.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVEREDITAR.Location = new System.Drawing.Point(58, 515);
            this.txtNombreVEREDITAR.Name = "txtNombreVEREDITAR";
            this.txtNombreVEREDITAR.Size = new System.Drawing.Size(442, 28);
            this.txtNombreVEREDITAR.TabIndex = 35;
            this.txtNombreVEREDITAR.Visible = false;
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.uI_ShadowPanel2.Controls.Add(this.label9);
            this.uI_ShadowPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(736, 593);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 7;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowShift = 8;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(136, 54);
            this.uI_ShadowPanel2.TabIndex = 69;
            this.uI_ShadowPanel2.Visible = false;
            this.uI_ShadowPanel2.Click += new System.EventHandler(this.uI_ShadowPanel2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Guardar";
            // 
            // frmOfertas_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 677);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel_productos);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.datetime_Fin);
            this.Controls.Add(this.datetime_Inicio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel_citas_programadas);
            this.Controls.Add(this.txtNombreVEREDITAR);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOfertas_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OFERTAS";
            this.Load += new System.EventHandler(this.frmOfertas_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ofertas)).EndInit();
            this.panel_citas_programadas.ResumeLayout(false);
            this.btnRegistrar.ResumeLayout(false);
            this.btnRegistrar.PerformLayout();
            this.panel_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtproductos)).EndInit();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.TextBox txtProducto;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.Label label3;
        private UIDC.UI_ShadowPanel panel_citas_programadas;
        private System.Windows.Forms.DataGridView dtg_Ofertas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescuento;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.TextBox txtCantidad;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private MetroFramework.Controls.MetroDateTime datetime_Fin;
        private MetroFramework.Controls.MetroDateTime datetime_Inicio;
        private UIDC.UI_ShadowPanel btnRegistrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_productos;
        private System.Windows.Forms.DataGridView dtproductos;
        private UIDC.UI_Notification notifica;
        private UIDC.UI_Notification notifica_error;
        private System.Windows.Forms.TextBox txtNombreVEREDITAR;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label9;
    }
}