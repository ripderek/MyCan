namespace WindowsFormsApplication3
{
    partial class frmCrearRecetaMedica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearRecetaMedica));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.medicamento_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamento_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosis_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicacion_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDosis = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIndicacion = new System.Windows.Forms.RichTextBox();
            this.btnAñadir = new UIDC.UI_ShadowPanel();
            this.lblBtn = new System.Windows.Forms.Label();
            this.btnFinalizar = new UIDC.UI_ShadowPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel12 = new UIDC.UI_ShadowPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGuardar = new UIDC.UI_ShadowPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMedicamento = new System.Windows.Forms.PictureBox();
            this.btnPaciente = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new System.Windows.Forms.PictureBox();
            this.notifica = new UIDC.UI_Notification();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            this.btnAñadir.SuspendLayout();
            this.btnFinalizar.SuspendLayout();
            this.btnGuardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctor)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(39, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 47);
            this.label4.TabIndex = 35;
            this.label4.Text = "Receta";
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.AutoScroll = true;
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dtg_Productos);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(23, 86);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowShift = 10;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1202, 438);
            this.uI_ShadowPanel1.TabIndex = 36;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamento_id,
            this.medicamento_name,
            this.dosis_m,
            this.indicacion_m});
            this.dtg_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_Productos.EnableHeadersVisualStyles = false;
            this.dtg_Productos.Location = new System.Drawing.Point(45, 16);
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.ReadOnly = true;
            this.dtg_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_Productos.Size = new System.Drawing.Size(1095, 404);
            this.dtg_Productos.TabIndex = 1;
            this.dtg_Productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Productos_CellDoubleClick);
            // 
            // medicamento_id
            // 
            this.medicamento_id.HeaderText = "ID";
            this.medicamento_id.Name = "medicamento_id";
            this.medicamento_id.ReadOnly = true;
            // 
            // medicamento_name
            // 
            this.medicamento_name.HeaderText = "Medicamento";
            this.medicamento_name.Name = "medicamento_name";
            this.medicamento_name.ReadOnly = true;
            // 
            // dosis_m
            // 
            this.dosis_m.HeaderText = "Dosis";
            this.dosis_m.Name = "dosis_m";
            this.dosis_m.ReadOnly = true;
            // 
            // indicacion_m
            // 
            this.indicacion_m.HeaderText = "Indicacion";
            this.indicacion_m.Name = "indicacion_m";
            this.indicacion_m.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(176, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 37;
            this.label6.Text = "Doctor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(675, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "Paciente:";
            // 
            // txtDoctor
            // 
            this.txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDoctor.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctor.Location = new System.Drawing.Point(263, 44);
            this.txtDoctor.MaxLength = 50;
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.ReadOnly = true;
            this.txtDoctor.Size = new System.Drawing.Size(338, 28);
            this.txtDoctor.TabIndex = 39;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(260, 50);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(341, 29);
            this.uI_ShadowPanel4.TabIndex = 38;
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(775, 50);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(341, 29);
            this.uI_ShadowPanel2.TabIndex = 38;
            // 
            // txtPaciente
            // 
            this.txtPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaciente.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(778, 44);
            this.txtPaciente.MaxLength = 50;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(338, 28);
            this.txtPaciente.TabIndex = 39;
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedicamento.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamento.Location = new System.Drawing.Point(180, 538);
            this.txtMedicamento.MaxLength = 50;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.ReadOnly = true;
            this.txtMedicamento.Size = new System.Drawing.Size(338, 28);
            this.txtMedicamento.TabIndex = 43;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(177, 544);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(341, 29);
            this.uI_ShadowPanel3.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(23, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 41;
            this.label2.Text = "Medicamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(23, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dosis:";
            // 
            // txtDosis
            // 
            this.txtDosis.Location = new System.Drawing.Point(177, 594);
            this.txtDosis.MaxLength = 100;
            this.txtDosis.Name = "txtDosis";
            this.txtDosis.Size = new System.Drawing.Size(341, 52);
            this.txtDosis.TabIndex = 45;
            this.txtDosis.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(602, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "Indicacion";
            // 
            // txtIndicacion
            // 
            this.txtIndicacion.Location = new System.Drawing.Point(603, 594);
            this.txtIndicacion.MaxLength = 100;
            this.txtIndicacion.Name = "txtIndicacion";
            this.txtIndicacion.Size = new System.Drawing.Size(341, 52);
            this.txtIndicacion.TabIndex = 45;
            this.txtIndicacion.Text = "";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.btnAñadir.Controls.Add(this.lblBtn);
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAñadir.Location = new System.Drawing.Point(808, 533);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.ParentControl = this;
            this.btnAñadir.Radius = 10;
            this.btnAñadir.ShadowColor = System.Drawing.Color.Black;
            this.btnAñadir.ShadowDepth = 50;
            this.btnAñadir.ShadowShift = 8;
            this.btnAñadir.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnAñadir.Size = new System.Drawing.Size(136, 58);
            this.btnAñadir.TabIndex = 46;
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
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnFinalizar.Controls.Add(this.label11);
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Location = new System.Drawing.Point(1089, 594);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.ParentControl = this;
            this.btnFinalizar.Radius = 10;
            this.btnFinalizar.ShadowColor = System.Drawing.Color.Black;
            this.btnFinalizar.ShadowDepth = 2;
            this.btnFinalizar.ShadowShift = 8;
            this.btnFinalizar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnFinalizar.Size = new System.Drawing.Size(136, 54);
            this.btnFinalizar.TabIndex = 47;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
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
            this.label11.Text = "Finalizar";
            // 
            // uI_ShadowPanel12
            // 
            this.uI_ShadowPanel12.BackColor = System.Drawing.Color.Transparent;
            this.uI_ShadowPanel12.BaseColor = System.Drawing.Color.Coral;
            this.uI_ShadowPanel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel12.Location = new System.Drawing.Point(1199, -2);
            this.uI_ShadowPanel12.Name = "uI_ShadowPanel12";
            this.uI_ShadowPanel12.ParentControl = this;
            this.uI_ShadowPanel12.Radius = 6;
            this.uI_ShadowPanel12.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel12.ShadowDepth = 20;
            this.uI_ShadowPanel12.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel12.Size = new System.Drawing.Size(37, 38);
            this.uI_ShadowPanel12.TabIndex = 48;
            this.uI_ShadowPanel12.Click += new System.EventHandler(this.uI_ShadowPanel12_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.Control;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.lblID.Location = new System.Drawing.Point(231, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 27);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "ID XD";
            this.lblID.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.btnGuardar.Controls.Add(this.label7);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(808, 533);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ParentControl = this;
            this.btnGuardar.Radius = 10;
            this.btnGuardar.ShadowColor = System.Drawing.Color.Black;
            this.btnGuardar.ShadowDepth = 50;
            this.btnGuardar.ShadowShift = 8;
            this.btnGuardar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnGuardar.Size = new System.Drawing.Size(136, 58);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnGuardar_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Guardar";
            // 
            // btnMedicamento
            // 
            this.btnMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicamento.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicamento.Image")));
            this.btnMedicamento.Location = new System.Drawing.Point(520, 533);
            this.btnMedicamento.Name = "btnMedicamento";
            this.btnMedicamento.Size = new System.Drawing.Size(66, 40);
            this.btnMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMedicamento.TabIndex = 44;
            this.btnMedicamento.TabStop = false;
            this.btnMedicamento.Click += new System.EventHandler(this.btnMedicamento_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.Location = new System.Drawing.Point(1122, 39);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(66, 40);
            this.btnPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPaciente.TabIndex = 40;
            this.btnPaciente.TabStop = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctor.Image")));
            this.btnDoctor.Location = new System.Drawing.Point(603, 39);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(66, 40);
            this.btnDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDoctor.TabIndex = 40;
            this.btnDoctor.TabStop = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
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
            this.notifica.Text = "Se registró la receta ";
            this.notifica.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.TitleText = "RECETA REALIZADA";
            this.notifica.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // frmCrearRecetaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 673);
            this.Controls.Add(this.uI_ShadowPanel12);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtIndicacion);
            this.Controls.Add(this.txtDosis);
            this.Controls.Add(this.btnMedicamento);
            this.Controls.Add(this.txtMedicamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearRecetaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearRecetaMedica";
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            this.btnAñadir.ResumeLayout(false);
            this.btnAñadir.PerformLayout();
            this.btnFinalizar.ResumeLayout(false);
            this.btnFinalizar.PerformLayout();
            this.btnGuardar.ResumeLayout(false);
            this.btnGuardar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_Notification notifica;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dtg_Productos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamento_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicacion_m;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtDoctor;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.PictureBox btnPaciente;
        private System.Windows.Forms.PictureBox btnDoctor;
        private System.Windows.Forms.PictureBox btnMedicamento;
        private System.Windows.Forms.TextBox txtMedicamento;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDosis;
        private System.Windows.Forms.RichTextBox txtIndicacion;
        private System.Windows.Forms.Label label5;
        private UIDC.UI_ShadowPanel btnAñadir;
        private System.Windows.Forms.Label lblBtn;
        private UIDC.UI_ShadowPanel btnFinalizar;
        private System.Windows.Forms.Label label11;
        private UIDC.UI_ShadowPanel uI_ShadowPanel12;
        private System.Windows.Forms.Label lblID;
        private UIDC.UI_ShadowPanel btnGuardar;
        private System.Windows.Forms.Label label7;
    }
}