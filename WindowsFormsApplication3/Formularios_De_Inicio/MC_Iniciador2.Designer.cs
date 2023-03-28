namespace WindowsFormsApplication3
{
    partial class MC_Iniciador2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC_Iniciador2));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel6 = new UIDC.UI_ShadowPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIdentifiacion = new MetroFramework.Controls.MetroComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel5 = new UIDC.UI_ShadowPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel_Empleado = new System.Windows.Forms.Panel();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.lblOficina = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.uI_ShadowPanel7 = new UIDC.UI_ShadowPanel();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.cmbArea = new MetroFramework.Controls.MetroComboBox();
            this.picFoto = new UIDC.UI_PictureBox();
            this.btnFoto = new System.Windows.Forms.PictureBox();
            this.uI_ShadowPanel6.SuspendLayout();
            this.panel_Empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoto)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los datos del Gerente-Propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(78, 162);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel1.TabIndex = 4;
            this.uI_ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(51, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificacion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(51, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celular:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(292, 345);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(244, 29);
            this.uI_ShadowPanel2.TabIndex = 4;
            this.uI_ShadowPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel2_Paint);
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(74, 441);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel3.TabIndex = 4;
            this.uI_ShadowPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel3_Paint);
            // 
            // uI_ShadowPanel6
            // 
            this.uI_ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.uI_ShadowPanel6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.uI_ShadowPanel6.Controls.Add(this.label7);
            this.uI_ShadowPanel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel6.Location = new System.Drawing.Point(1039, 577);
            this.uI_ShadowPanel6.Name = "uI_ShadowPanel6";
            this.uI_ShadowPanel6.ParentControl = this;
            this.uI_ShadowPanel6.Radius = 2;
            this.uI_ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel6.ShadowDepth = 50;
            this.uI_ShadowPanel6.ShadowShift = 8;
            this.uI_ShadowPanel6.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel6.Size = new System.Drawing.Size(165, 54);
            this.uI_ShadowPanel6.TabIndex = 6;
            this.uI_ShadowPanel6.Click += new System.EventHandler(this.uI_ShadowPanel6_Click);
            this.uI_ShadowPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel6_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Continuar";
            this.label7.Click += new System.EventHandler(this.uI_ShadowPanel6_Click);
            // 
            // cmbIdentifiacion
            // 
            this.cmbIdentifiacion.FormattingEnabled = true;
            this.cmbIdentifiacion.ItemHeight = 23;
            this.cmbIdentifiacion.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte",
            "Ruc"});
            this.cmbIdentifiacion.Location = new System.Drawing.Point(78, 340);
            this.cmbIdentifiacion.Name = "cmbIdentifiacion";
            this.cmbIdentifiacion.Size = new System.Drawing.Size(208, 29);
            this.cmbIdentifiacion.TabIndex = 2;
            this.cmbIdentifiacion.TabStop = false;
            this.cmbIdentifiacion.UseSelectable = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(78, 156);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(461, 28);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(75, 435);
            this.txtCelular.MaxLength = 10;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(461, 28);
            this.txtCelular.TabIndex = 9;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(294, 339);
            this.txtIdentificacion.MaxLength = 13;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(242, 28);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(53, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellidos:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(75, 258);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel4.TabIndex = 4;
            this.uI_ShadowPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel1_Paint);
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(75, 252);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(461, 28);
            this.txtApellidos.TabIndex = 9;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // uI_ShadowPanel5
            // 
            this.uI_ShadowPanel5.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.uI_ShadowPanel5.Location = new System.Drawing.Point(73, 549);
            this.uI_ShadowPanel5.Name = "uI_ShadowPanel5";
            this.uI_ShadowPanel5.ParentControl = this;
            this.uI_ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel5.ShadowDepth = 50;
            this.uI_ShadowPanel5.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel5.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel5.TabIndex = 4;
            this.uI_ShadowPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.uI_ShadowPanel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label6.Location = new System.Drawing.Point(50, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Direccion:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(74, 543);
            this.txtDireccion.MaxLength = 10;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(461, 28);
            this.txtDireccion.TabIndex = 9;
            // 
            // panel_Empleado
            // 
            this.panel_Empleado.Controls.Add(this.txtOficina);
            this.panel_Empleado.Controls.Add(this.lblOficina);
            this.panel_Empleado.Controls.Add(this.lblArea);
            this.panel_Empleado.Controls.Add(this.lblTipo);
            this.panel_Empleado.Controls.Add(this.uI_ShadowPanel7);
            this.panel_Empleado.Controls.Add(this.cmbArea);
            this.panel_Empleado.Controls.Add(this.cmbTipo);
            this.panel_Empleado.Location = new System.Drawing.Point(594, 129);
            this.panel_Empleado.Name = "panel_Empleado";
            this.panel_Empleado.Size = new System.Drawing.Size(312, 377);
            this.panel_Empleado.TabIndex = 20;
            // 
            // txtOficina
            // 
            this.txtOficina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOficina.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficina.Location = new System.Drawing.Point(11, 205);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(245, 28);
            this.txtOficina.TabIndex = 9;
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
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblArea.Location = new System.Drawing.Point(6, 82);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(56, 28);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
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
            // 
            // uI_ShadowPanel7
            // 
            this.uI_ShadowPanel7.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel7.Location = new System.Drawing.Point(8, 211);
            this.uI_ShadowPanel7.Name = "uI_ShadowPanel7";
            this.uI_ShadowPanel7.ParentControl = this;
            this.uI_ShadowPanel7.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel7.ShadowDepth = 50;
            this.uI_ShadowPanel7.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel7.Size = new System.Drawing.Size(248, 29);
            this.uI_ShadowPanel7.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Items.AddRange(new object[] {
            "Propietario",
            "Gerente",
            "Gerente-Propietario",
            "Enfermo",
            "Auxiliar",
            "Doctor",
            "Secretario"});
            this.cmbTipo.Location = new System.Drawing.Point(11, 36);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(208, 29);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.TabStop = false;
            this.cmbTipo.UseSelectable = true;
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
            this.cmbArea.Location = new System.Drawing.Point(11, 110);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(208, 29);
            this.cmbArea.TabIndex = 2;
            this.cmbArea.TabStop = false;
            this.cmbArea.UseSelectable = true;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.Transparent;
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(941, 145);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(252, 271);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 21;
            this.picFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.Location = new System.Drawing.Point(1118, 422);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 62);
            this.btnFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFoto.TabIndex = 22;
            this.btnFoto.TabStop = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // MC_Iniciador2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1236, 680);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.panel_Empleado);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbIdentifiacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uI_ShadowPanel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MC_Iniciador2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC_Iniciador2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MC_Iniciador2_FormClosed);
            this.Load += new System.EventHandler(this.MC_Iniciador2_Load);
            this.uI_ShadowPanel6.ResumeLayout(false);
            this.uI_ShadowPanel6.PerformLayout();
            this.panel_Empleado.ResumeLayout(false);
            this.panel_Empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_DragForm uI_DragForm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cmbIdentifiacion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtApellidos;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private UIDC.UI_ShadowPanel uI_ShadowPanel5;
        private System.Windows.Forms.Panel panel_Empleado;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblTipo;
        private UIDC.UI_ShadowPanel uI_ShadowPanel7;
        private MetroFramework.Controls.MetroComboBox cmbArea;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private UIDC.UI_PictureBox picFoto;
        private System.Windows.Forms.PictureBox btnFoto;
    }
}