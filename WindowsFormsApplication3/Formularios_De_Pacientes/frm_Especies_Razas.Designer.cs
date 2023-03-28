namespace WindowsFormsApplication3
{
    partial class frm_Especies_Razas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Especies_Razas));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.btnGuardar = new UIDC.UI_ButtonMaterial();
            this.BtnEliminar = new UIDC.UI_ButtonMaterial();
            this.txtBusqueda = new UIDC.UI_MaterialTextBox();
            this.txtNombre_especie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Especies = new System.Windows.Forms.Panel();
            this.dtgvEspecie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.uI_ButtonMaterial1 = new UIDC.UI_ButtonMaterial();
            this.uI_ButtonMaterial2 = new UIDC.UI_ButtonMaterial();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvRazas = new System.Windows.Forms.DataGridView();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.notifi_agregar_especie = new UIDC.UI_Notification();
            this.panel_Titulo.SuspendLayout();
            this.uI_ShadowPanel1.SuspendLayout();
            this.panel_Especies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEspecie)).BeginInit();
            this.uI_ShadowPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRazas)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblTitulo);
            this.panel_Titulo.Controls.Add(this.btnCerar);
            this.panel_Titulo.Location = new System.Drawing.Point(-1, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(929, 46);
            this.panel_Titulo.TabIndex = 32;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_Titulo.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UIForeColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel_Titulo.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.panel_Titulo.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(13, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(479, 47);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Especies y razas de animales";
            // 
            // btnCerar
            // 
            this.btnCerar.AutoSize = true;
            this.btnCerar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerar.Location = new System.Drawing.Point(881, 0);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 27;
            this.btnCerar.Text = "X";
            this.btnCerar.Click += new System.EventHandler(this.btnCerar_Click);
            this.btnCerar.MouseEnter += new System.EventHandler(this.btnCerar_MouseEnter);
            this.btnCerar.MouseLeave += new System.EventHandler(this.btnCerar_MouseLeave);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.uI_ShadowPanel1.Controls.Add(this.btnGuardar);
            this.uI_ShadowPanel1.Controls.Add(this.BtnEliminar);
            this.uI_ShadowPanel1.Controls.Add(this.txtBusqueda);
            this.uI_ShadowPanel1.Controls.Add(this.txtNombre_especie);
            this.uI_ShadowPanel1.Controls.Add(this.label3);
            this.uI_ShadowPanel1.Controls.Add(this.panel_Especies);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(36, 115);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowShift = 10;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(406, 514);
            this.uI_ShadowPanel1.TabIndex = 33;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.btnGuardar.ElipseColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnGuardar.Location = new System.Drawing.Point(256, 448);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Radio = 10;
            this.btnGuardar.Size = new System.Drawing.Size(106, 41);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.BtnEliminar.ElipseColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            this.BtnEliminar.Location = new System.Drawing.Point(143, 448);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Radio = 10;
            this.BtnEliminar.Size = new System.Drawing.Size(107, 41);
            this.BtnEliminar.TabIndex = 48;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.FocusedColor = "#508ef5";
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Variable Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.IsEnabled = true;
            this.txtBusqueda.Location = new System.Drawing.Point(19, 37);
            this.txtBusqueda.MaxLength = 32767;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(364, 24);
            this.txtBusqueda.TabIndex = 34;
            this.txtBusqueda.Text = "Busqueda";
            this.txtBusqueda.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusqueda.UIFont = new System.Drawing.Font("Segoe UI Variable Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.UIFontColor = "#999999";
            this.txtBusqueda.UIMultiline = false;
            this.txtBusqueda.UIReadOnly = false;
            this.txtBusqueda.UseSystemPasswordChar = false;
            this.txtBusqueda.ValidateMessageText = "MessageBox Error Text ";
            this.txtBusqueda.ValidateMessageTitle = "MessageBox Title Text ";
            this.txtBusqueda.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Null;
            // 
            // txtNombre_especie
            // 
            this.txtNombre_especie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre_especie.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre_especie.Location = new System.Drawing.Point(48, 413);
            this.txtNombre_especie.Name = "txtNombre_especie";
            this.txtNombre_especie.Size = new System.Drawing.Size(314, 28);
            this.txtNombre_especie.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Especie:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel_Especies
            // 
            this.panel_Especies.AutoScroll = true;
            this.panel_Especies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.panel_Especies.Controls.Add(this.dtgvEspecie);
            this.panel_Especies.Location = new System.Drawing.Point(19, 67);
            this.panel_Especies.Name = "panel_Especies";
            this.panel_Especies.Size = new System.Drawing.Size(364, 312);
            this.panel_Especies.TabIndex = 0;
            // 
            // dtgvEspecie
            // 
            this.dtgvEspecie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEspecie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvEspecie.BackgroundColor = System.Drawing.Color.White;
            this.dtgvEspecie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvEspecie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvEspecie.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvEspecie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEspecie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEspecie.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvEspecie.EnableHeadersVisualStyles = false;
            this.dtgvEspecie.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvEspecie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvEspecie.Location = new System.Drawing.Point(-4, 0);
            this.dtgvEspecie.Name = "dtgvEspecie";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEspecie.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvEspecie.Size = new System.Drawing.Size(368, 321);
            this.dtgvEspecie.TabIndex = 34;
            this.dtgvEspecie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEspecie_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Especies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(462, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razas";
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.uI_ShadowPanel2.Controls.Add(this.uI_ButtonMaterial1);
            this.uI_ShadowPanel2.Controls.Add(this.uI_ButtonMaterial2);
            this.uI_ShadowPanel2.Controls.Add(this.txtRaza);
            this.uI_ShadowPanel2.Controls.Add(this.label4);
            this.uI_ShadowPanel2.Controls.Add(this.panel1);
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(468, 115);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 10;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowShift = 10;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(406, 514);
            this.uI_ShadowPanel2.TabIndex = 33;
            // 
            // uI_ButtonMaterial1
            // 
            this.uI_ButtonMaterial1.BackColor = System.Drawing.Color.White;
            this.uI_ButtonMaterial1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ButtonMaterial1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.uI_ButtonMaterial1.ElipseColor = System.Drawing.Color.Black;
            this.uI_ButtonMaterial1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uI_ButtonMaterial1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_ButtonMaterial1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.uI_ButtonMaterial1.Location = new System.Drawing.Point(250, 448);
            this.uI_ButtonMaterial1.Name = "uI_ButtonMaterial1";
            this.uI_ButtonMaterial1.Radio = 10;
            this.uI_ButtonMaterial1.Size = new System.Drawing.Size(112, 41);
            this.uI_ButtonMaterial1.TabIndex = 47;
            this.uI_ButtonMaterial1.Text = "Guardar";
            this.uI_ButtonMaterial1.UseVisualStyleBackColor = false;
            this.uI_ButtonMaterial1.Click += new System.EventHandler(this.uI_ButtonMaterial1_Click);
            // 
            // uI_ButtonMaterial2
            // 
            this.uI_ButtonMaterial2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uI_ButtonMaterial2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ButtonMaterial2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uI_ButtonMaterial2.ElipseColor = System.Drawing.Color.Black;
            this.uI_ButtonMaterial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uI_ButtonMaterial2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_ButtonMaterial2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            this.uI_ButtonMaterial2.Location = new System.Drawing.Point(131, 448);
            this.uI_ButtonMaterial2.Name = "uI_ButtonMaterial2";
            this.uI_ButtonMaterial2.Radio = 10;
            this.uI_ButtonMaterial2.Size = new System.Drawing.Size(113, 41);
            this.uI_ButtonMaterial2.TabIndex = 48;
            this.uI_ButtonMaterial2.Text = "Eliminar";
            this.uI_ButtonMaterial2.UseVisualStyleBackColor = false;
            this.uI_ButtonMaterial2.Visible = false;
            // 
            // txtRaza
            // 
            this.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRaza.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(48, 413);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(314, 28);
            this.txtRaza.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Raza:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.dtgvRazas);
            this.panel1.Location = new System.Drawing.Point(20, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 357);
            this.panel1.TabIndex = 0;
            // 
            // dtgvRazas
            // 
            this.dtgvRazas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRazas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgvRazas.BackgroundColor = System.Drawing.Color.White;
            this.dtgvRazas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRazas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgvRazas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvRazas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRazas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvRazas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRazas.EnableHeadersVisualStyles = false;
            this.dtgvRazas.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvRazas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvRazas.Location = new System.Drawing.Point(-4, 0);
            this.dtgvRazas.Name = "dtgvRazas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRazas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvRazas.Size = new System.Drawing.Size(368, 366);
            this.dtgvRazas.TabIndex = 34;
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this.panel_Titulo;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this.panel_Titulo;
            // 
            // notifi_agregar_especie
            // 
            this.notifi_agregar_especie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifi_agregar_especie.CloseInterval = 5;
            this.notifi_agregar_especie.EnabledNoti = false;
            this.notifi_agregar_especie.Image = ((System.Drawing.Image)(resources.GetObject("notifi_agregar_especie.Image")));
            this.notifi_agregar_especie.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar_especie.ImageElipse = true;
            this.notifi_agregar_especie.ImageVisible = true;
            this.notifi_agregar_especie.SoundEnabled = true;
            this.notifi_agregar_especie.Text = "Nueva Especie";
            this.notifi_agregar_especie.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar_especie.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifi_agregar_especie.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar_especie.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar_especie.TitleText = "Nuevo registro";
            this.notifi_agregar_especie.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // frm_Especies_Razas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Especies_Razas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Especies_Razas";
            this.Load += new System.EventHandler(this.frm_Especies_Razas_Load);
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.panel_Especies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEspecie)).EndInit();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRazas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_GradientPanel panel_Titulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label btnCerar;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Especies;
        private System.Windows.Forms.TextBox txtNombre_especie;
        private System.Windows.Forms.Label label3;
        private UIDC.UI_MaterialTextBox txtBusqueda;
        private UIDC.UI_ButtonMaterial btnGuardar;
        private UIDC.UI_ButtonMaterial BtnEliminar;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ButtonMaterial uI_ButtonMaterial1;
        private UIDC.UI_ButtonMaterial uI_ButtonMaterial2;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvRazas;
        private System.Windows.Forms.DataGridView dtgvEspecie;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Notification notifi_agregar_especie;
    }
}