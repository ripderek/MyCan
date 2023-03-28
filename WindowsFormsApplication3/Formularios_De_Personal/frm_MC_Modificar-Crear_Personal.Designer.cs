namespace WindowsFormsApplication3
{
    partial class frm_MC_Modificar_Crear_Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MC_Modificar_Crear_Personal));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.lblCrear = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIdentifiacion = new MetroFramework.Controls.MetroComboBox();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.BtnGuardar = new UIDC.UI_ButtonMaterial();
            this.BtnEliminar = new UIDC.UI_ButtonMaterial();
            this.btn_Modificar = new UIDC.UI_ButtonMaterial();
            this.panelVista = new System.Windows.Forms.Panel();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.panel_Empleado = new System.Windows.Forms.Panel();
            this.cmbArea = new MetroFramework.Controls.MetroComboBox();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.uI_ShadowPanel5 = new UIDC.UI_ShadowPanel();
            this.cmbEstado = new MetroFramework.Controls.MetroComboBox();
            this.pic_Foto = new UIDC.UI_PictureBox();
            this.btnVista = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.PictureBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.uI_ShadowPanel6 = new UIDC.UI_ShadowPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAgregar = new UIDC.UI_ButtonMaterial();
            this.notifi_agregar = new UIDC.UI_Notification();
            this.panel_Empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(36, 24);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(122, 47);
            this.lblCrear.TabIndex = 3;
            this.lblCrear.Text = "Crear:";
            this.lblCrear.Visible = false;
            this.lblCrear.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(36, 24);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(191, 47);
            this.lblModificar.TabIndex = 3;
            this.lblModificar.Text = "Modificar:";
            this.lblModificar.Visible = false;
            this.lblModificar.Click += new System.EventHandler(this.label4_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.AutoSize = true;
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(1184, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(40, 43);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(122, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(461, 28);
            this.txtNombre.TabIndex = 9;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(121, 166);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(52, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(122, 248);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(52, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Identificacion:";
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(328, 330);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(255, 29);
            this.uI_ShadowPanel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(52, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero Celular:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbIdentifiacion
            // 
            this.cmbIdentifiacion.FormattingEnabled = true;
            this.cmbIdentifiacion.ItemHeight = 23;
            this.cmbIdentifiacion.Items.AddRange(new object[] {
            "Cedula",
            "Ruc",
            "Pasaporte"});
            this.cmbIdentifiacion.Location = new System.Drawing.Point(122, 330);
            this.cmbIdentifiacion.Name = "cmbIdentifiacion";
            this.cmbIdentifiacion.Size = new System.Drawing.Size(184, 29);
            this.cmbIdentifiacion.TabIndex = 10;
            this.cmbIdentifiacion.UseSelectable = true;
            this.cmbIdentifiacion.SelectionChangeCommitted += new System.EventHandler(this.cmbIdentifiacion_SelectionChangeCommitted);
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(122, 412);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel4.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(121, 242);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(461, 28);
            this.txtApellidos.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(121, 406);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(461, 28);
            this.txtCelular.TabIndex = 9;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(328, 324);
            this.txtIdentificacion.MaxLength = 13;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(256, 28);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonal.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonal.Location = new System.Drawing.Point(36, 24);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(169, 47);
            this.lblPersonal.TabIndex = 3;
            this.lblPersonal.Text = "Personal:";
            this.lblPersonal.Visible = false;
            this.lblPersonal.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.BtnGuardar.ElipseColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(427, 565);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Radio = 10;
            this.BtnGuardar.Size = new System.Drawing.Size(143, 41);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
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
            this.BtnEliminar.Location = new System.Drawing.Point(268, 565);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Radio = 10;
            this.BtnEliminar.Size = new System.Drawing.Size(143, 41);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btn_Modificar.ElipseColor = System.Drawing.Color.Black;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Location = new System.Drawing.Point(101, 565);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Radio = 10;
            this.btn_Modificar.Size = new System.Drawing.Size(143, 41);
            this.btn_Modificar.TabIndex = 16;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Visible = false;
            // 
            // panelVista
            // 
            this.panelVista.Location = new System.Drawing.Point(-1, 0);
            this.panelVista.Name = "panelVista";
            this.panelVista.Size = new System.Drawing.Size(76, 37);
            this.panelVista.TabIndex = 17;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuscar.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F);
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(122, 81);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(420, 36);
            this.cmbBuscar.TabIndex = 18;
            // 
            // panel_Empleado
            // 
            this.panel_Empleado.Controls.Add(this.cmbArea);
            this.panel_Empleado.Controls.Add(this.cmbTipo);
            this.panel_Empleado.Controls.Add(this.txtOficina);
            this.panel_Empleado.Controls.Add(this.lblestado);
            this.panel_Empleado.Controls.Add(this.lblOficina);
            this.panel_Empleado.Controls.Add(this.lblArea);
            this.panel_Empleado.Controls.Add(this.lblTipo);
            this.panel_Empleado.Controls.Add(this.uI_ShadowPanel5);
            this.panel_Empleado.Controls.Add(this.cmbEstado);
            this.panel_Empleado.Location = new System.Drawing.Point(614, 126);
            this.panel_Empleado.Name = "panel_Empleado";
            this.panel_Empleado.Size = new System.Drawing.Size(312, 377);
            this.panel_Empleado.TabIndex = 19;
            this.panel_Empleado.Visible = false;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.ItemHeight = 23;
            this.cmbArea.Items.AddRange(new object[] {
            "Medicina",
            "Operaciones",
            "Caja",
            "Administrativa",
            "Operador"});
            this.cmbArea.Location = new System.Drawing.Point(26, 114);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(208, 29);
            this.cmbArea.TabIndex = 11;
            this.cmbArea.TabStop = false;
            this.cmbArea.UseSelectable = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Items.AddRange(new object[] {
            "Propietario",
            "Gerente",
            "Gerente-Propietario",
            "Enfermero",
            "Auxiliar",
            "Doctor",
            "Secretario"});
            this.cmbTipo.Location = new System.Drawing.Point(26, 40);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(208, 29);
            this.cmbTipo.TabIndex = 12;
            this.cmbTipo.TabStop = false;
            this.cmbTipo.UseSelectable = true;
            // 
            // txtOficina
            // 
            this.txtOficina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOficina.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficina.Location = new System.Drawing.Point(26, 205);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(208, 28);
            this.txtOficina.TabIndex = 9;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblestado.Location = new System.Drawing.Point(6, 246);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(82, 28);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Estado:";
            this.lblestado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblOficina.Location = new System.Drawing.Point(3, 164);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(83, 28);
            this.lblOficina.TabIndex = 4;
            this.lblOficina.Text = "Oficina:";
            this.lblOficina.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblArea.Location = new System.Drawing.Point(3, 82);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(56, 28);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            this.lblArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblTipo.Location = new System.Drawing.Point(3, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(59, 28);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Click += new System.EventHandler(this.label1_Click);
            // 
            // uI_ShadowPanel5
            // 
            this.uI_ShadowPanel5.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel5.Location = new System.Drawing.Point(26, 211);
            this.uI_ShadowPanel5.Name = "uI_ShadowPanel5";
            this.uI_ShadowPanel5.ParentControl = this;
            this.uI_ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel5.ShadowDepth = 50;
            this.uI_ShadowPanel5.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel5.Size = new System.Drawing.Size(208, 29);
            this.uI_ShadowPanel5.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 23;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(26, 286);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(184, 29);
            this.cmbEstado.TabIndex = 10;
            this.cmbEstado.UseSelectable = true;
            // 
            // pic_Foto
            // 
            this.pic_Foto.BackColor = System.Drawing.Color.Transparent;
            this.pic_Foto.Image = ((System.Drawing.Image)(resources.GetObject("pic_Foto.Image")));
            this.pic_Foto.Location = new System.Drawing.Point(941, 95);
            this.pic_Foto.Name = "pic_Foto";
            this.pic_Foto.Size = new System.Drawing.Size(252, 271);
            this.pic_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Foto.TabIndex = 11;
            this.pic_Foto.TabStop = false;
            this.pic_Foto.Click += new System.EventHandler(this.pic_Foto_Click);
            // 
            // btnVista
            // 
            this.btnVista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVista.Image = ((System.Drawing.Image)(resources.GetObject("btnVista.Image")));
            this.btnVista.Location = new System.Drawing.Point(1113, 9);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(56, 43);
            this.btnVista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVista.TabIndex = 13;
            this.btnVista.TabStop = false;
            this.btnVista.Visible = false;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.Location = new System.Drawing.Point(1118, 372);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 62);
            this.btnFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFoto.TabIndex = 13;
            this.btnFoto.TabStop = false;
            this.btnFoto.Visible = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(519, 73);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 50);
            this.btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.TabStop = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(121, 504);
            this.txtDireccion.MaxLength = 10;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(461, 28);
            this.txtDireccion.TabIndex = 22;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblDireccion.Location = new System.Drawing.Point(52, 456);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(106, 28);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Direccion:";
            // 
            // uI_ShadowPanel6
            // 
            this.uI_ShadowPanel6.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.uI_ShadowPanel6.Location = new System.Drawing.Point(120, 510);
            this.uI_ShadowPanel6.Name = "uI_ShadowPanel6";
            this.uI_ShadowPanel6.ParentControl = this;
            this.uI_ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel6.ShadowDepth = 50;
            this.uI_ShadowPanel6.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel6.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel6.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(387, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(169, 47);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Personal:";
            this.lblID.Visible = false;
            this.lblID.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.btnAgregar.ElipseColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(427, 565);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Radio = 10;
            this.btnAgregar.Size = new System.Drawing.Size(143, 41);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.notifi_agregar.TitleText = "Personal Agregado";
            this.notifi_agregar.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // frm_MC_Modificar_Crear_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1236, 680);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.uI_ShadowPanel6);
            this.Controls.Add(this.panel_Empleado);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.panelVista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.pic_Foto);
            this.Controls.Add(this.cmbIdentifiacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPersonal);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.btnVista);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnbuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MC_Modificar_Crear_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MC_Modificar_Crear_Personal";
            this.Load += new System.EventHandler(this.frm_MC_Modificar_Crear_Personal_Load);
            this.panel_Empleado.ResumeLayout(false);
            this.panel_Empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cmbIdentifiacion;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private UIDC.UI_PictureBox pic_Foto;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.PictureBox btnbuscar;
        private System.Windows.Forms.Label lblPersonal;
        private UIDC.UI_ButtonMaterial BtnGuardar;
        private UIDC.UI_ButtonMaterial BtnEliminar;
        private UIDC.UI_ButtonMaterial btn_Modificar;
        private System.Windows.Forms.PictureBox btnFoto;
        private System.Windows.Forms.PictureBox btnVista;
        private System.Windows.Forms.Panel panelVista;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Panel panel_Empleado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label lblArea;
        private UIDC.UI_ShadowPanel uI_ShadowPanel5;
        private System.Windows.Forms.Label lblestado;
        private MetroFramework.Controls.MetroComboBox cmbEstado;
        private MetroFramework.Controls.MetroComboBox cmbArea;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private UIDC.UI_ShadowPanel uI_ShadowPanel6;
        private System.Windows.Forms.Label lblID;
        private UIDC.UI_ButtonMaterial btnAgregar;
        private UIDC.UI_Notification notifi_agregar;
    }
}