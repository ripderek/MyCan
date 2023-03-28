namespace WindowsFormsApplication3
{
    partial class frm_MC_Paciente_Agregar_Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MC_Paciente_Agregar_Modificar));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.lblCrear = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnGuardar = new UIDC.UI_ButtonMaterial();
            this.BtnEliminar = new UIDC.UI_ButtonMaterial();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEspecie = new MetroFramework.Controls.MetroComboBox();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRaza = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSexo = new MetroFramework.Controls.MetroComboBox();
            this.cmbColor = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_fecha_nac = new UIDC.UI_CustomDateTimePicker();
            this.btnFoto = new System.Windows.Forms.PictureBox();
            this.pic_Foto = new UIDC.UI_PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.notifi_agregar = new UIDC.UI_Notification();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.txtCedulaDueno = new System.Windows.Forms.TextBox();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this.panel_Titulo;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this.panel_Titulo;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Controls.Add(this.lblModificar);
            this.panel_Titulo.Controls.Add(this.btnCerar);
            this.panel_Titulo.Location = new System.Drawing.Point(-1, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(1025, 46);
            this.panel_Titulo.TabIndex = 31;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_Titulo.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UIForeColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel_Titulo.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.panel_Titulo.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCrear.Location = new System.Drawing.Point(15, 0);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(122, 47);
            this.lblCrear.TabIndex = 4;
            this.lblCrear.Text = "Crear:";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblModificar.Location = new System.Drawing.Point(26, 1);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(191, 47);
            this.lblModificar.TabIndex = 4;
            this.lblModificar.Text = "Modificar:";
            this.lblModificar.Visible = false;
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
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblDireccion.Location = new System.Drawing.Point(39, 429);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(188, 28);
            this.lblDireccion.TabIndex = 48;
            this.lblDireccion.Text = "Fecha Nacimiento:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.btnGuardar.ElipseColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(428, 538);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Radio = 10;
            this.btnGuardar.Size = new System.Drawing.Size(143, 41);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.BtnEliminar.ElipseColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(279, 538);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Radio = 10;
            this.BtnEliminar.Size = new System.Drawing.Size(143, 41);
            this.BtnEliminar.TabIndex = 46;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(108, 215);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(461, 28);
            this.txtNombre.TabIndex = 42;
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.ItemHeight = 23;
            this.cmbEspecie.Location = new System.Drawing.Point(109, 303);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(205, 29);
            this.cmbEspecie.TabIndex = 44;
            this.cmbEspecie.UseSelectable = true;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(109, 221);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel2.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(39, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(39, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "Especie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(39, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Pertenece a:";
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.ItemHeight = 23;
            this.cmbRaza.Location = new System.Drawing.Point(338, 303);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(231, 29);
            this.cmbRaza.TabIndex = 44;
            this.cmbRaza.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(333, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Raza:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.ItemHeight = 23;
            this.cmbSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cmbSexo.Location = new System.Drawing.Point(109, 381);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(205, 29);
            this.cmbSexo.TabIndex = 44;
            this.cmbSexo.UseSelectable = true;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.ItemHeight = 23;
            this.cmbColor.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Verde",
            "Cafe",
            "Amarillo",
            "Gris",
            "Marrón",
            ""});
            this.cmbColor.Location = new System.Drawing.Point(338, 381);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(233, 29);
            this.cmbColor.TabIndex = 44;
            this.cmbColor.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label6.Location = new System.Drawing.Point(333, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Color:";
            // 
            // date_fecha_nac
            // 
            this.date_fecha_nac.BackColor = System.Drawing.Color.Transparent;
            this.date_fecha_nac.CollapseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.date_fecha_nac.CustomFormat = null;
            this.date_fecha_nac.Font = new System.Drawing.Font("Segoe UI Variable Small", 21F);
            this.date_fecha_nac.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_fecha_nac.HeightBase = 30;
            this.date_fecha_nac.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.date_fecha_nac.LineSize = 2;
            this.date_fecha_nac.Location = new System.Drawing.Point(109, 471);
            this.date_fecha_nac.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_fecha_nac.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_fecha_nac.Name = "date_fecha_nac";
            this.date_fecha_nac.Radius = true;
            this.date_fecha_nac.Size = new System.Drawing.Size(462, 35);
            this.date_fecha_nac.SolidColor = System.Drawing.SystemColors.Control;
            this.date_fecha_nac.TabIndex = 50;
            this.date_fecha_nac.Text = "lunes, 7 de febrero de 2022";
            this.date_fecha_nac.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.date_fecha_nac.Value = new System.DateTime(2022, 2, 7, 21, 23, 22, 650);
            // 
            // btnFoto
            // 
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.Location = new System.Drawing.Point(799, 412);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 62);
            this.btnFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFoto.TabIndex = 52;
            this.btnFoto.TabStop = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pic_Foto
            // 
            this.pic_Foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.pic_Foto.Image = ((System.Drawing.Image)(resources.GetObject("pic_Foto.Image")));
            this.pic_Foto.Location = new System.Drawing.Point(622, 135);
            this.pic_Foto.Name = "pic_Foto";
            this.pic_Foto.Size = new System.Drawing.Size(252, 271);
            this.pic_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Foto.TabIndex = 51;
            this.pic_Foto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(392, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(320, 141);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel1.TabIndex = 37;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreDueño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDueño.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDueño.Location = new System.Drawing.Point(323, 135);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.ReadOnly = true;
            this.txtNombreDueño.Size = new System.Drawing.Size(246, 28);
            this.txtNombreDueño.TabIndex = 42;
            // 
            // notifi_agregar
            // 
            this.notifi_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifi_agregar.CloseInterval = 5;
            this.notifi_agregar.EnabledNoti = false;
            this.notifi_agregar.Image = ((System.Drawing.Image)(resources.GetObject("notifi_agregar.Image")));
            this.notifi_agregar.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar.ImageElipse = true;
            this.notifi_agregar.ImageVisible = true;
            this.notifi_agregar.SoundEnabled = true;
            this.notifi_agregar.Text = "Notification text (Place text)";
            this.notifi_agregar.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifi_agregar.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar.TitleText = "Paciente ";
            this.notifi_agregar.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(65, 141);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel3.TabIndex = 37;
            // 
            // txtCedulaDueno
            // 
            this.txtCedulaDueno.BackColor = System.Drawing.SystemColors.Window;
            this.txtCedulaDueno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaDueno.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaDueno.Location = new System.Drawing.Point(68, 135);
            this.txtCedulaDueno.Name = "txtCedulaDueno";
            this.txtCedulaDueno.Size = new System.Drawing.Size(246, 28);
            this.txtCedulaDueno.TabIndex = 42;
            this.txtCedulaDueno.TextChanged += new System.EventHandler(this.txtCedulaDueno_TextChanged);
            // 
            // frm_MC_Paciente_Agregar_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_Foto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.date_fecha_nac);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.txtCedulaDueno);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.cmbEspecie);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MC_Paciente_Agregar_Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MC_Paciente_Agregar_Modificar";
            this.Load += new System.EventHandler(this.frm_MC_Paciente_Agregar_Modificar_Load);
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_GradientPanel panel_Titulo;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label btnCerar;
        private System.Windows.Forms.Label lblDireccion;
        private UIDC.UI_ButtonMaterial btnGuardar;
        private UIDC.UI_ButtonMaterial BtnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private MetroFramework.Controls.MetroComboBox cmbEspecie;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbRaza;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox cmbSexo;
        private MetroFramework.Controls.MetroComboBox cmbColor;
        private System.Windows.Forms.Label label6;
        private UIDC.UI_CustomDateTimePicker date_fecha_nac;
        private System.Windows.Forms.PictureBox btnFoto;
        private UIDC.UI_PictureBox pic_Foto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private UIDC.UI_Notification notifi_agregar;
        private System.Windows.Forms.TextBox txtCedulaDueno;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
    }
}