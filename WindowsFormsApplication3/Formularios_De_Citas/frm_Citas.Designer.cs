namespace WindowsFormsApplication3
{
    partial class frm_Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Citas));
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dtgv_Citas = new System.Windows.Forms.DataGridView();
            this.lblCitas_Listado_Completo = new System.Windows.Forms.Label();
            this.btnListado_Citas = new UIDC.UI_ButtonMaterial();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btnAyuda = new System.Windows.Forms.PictureBox();
            this.btn_Nueva_Cita = new System.Windows.Forms.PictureBox();
            this.clmFechaDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoraLle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoraDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEmpleAtender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoEmpleAten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEmpleAgen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoEmpleAgen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new MetroFramework.Controls.MetroComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Citas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Nueva_Cita)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = null;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = null;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1185, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(147, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 47);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha: ";
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dtgv_Citas);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(11, 83);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowShift = 10;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1197, 576);
            this.uI_ShadowPanel1.TabIndex = 17;
            // 
            // dtgv_Citas
            // 
            this.dtgv_Citas.AllowUserToAddRows = false;
            this.dtgv_Citas.AllowUserToDeleteRows = false;
            this.dtgv_Citas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Citas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgv_Citas.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Citas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Citas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgv_Citas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_Citas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Citas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Citas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFechaDes,
            this.clmHoraLle,
            this.clmEstado,
            this.clmHoraDes,
            this.clmDuracion,
            this.clmNombreCli,
            this.clmApellidoCli,
            this.clmNombreEmpleAtender,
            this.clmApellidoEmpleAten,
            this.clmNombreEmpleAgen,
            this.clmApellidoEmpleAgen,
            this.clmID,
            this.clmDetalla});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Citas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_Citas.EnableHeadersVisualStyles = false;
            this.dtgv_Citas.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgv_Citas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv_Citas.Location = new System.Drawing.Point(26, 21);
            this.dtgv_Citas.MultiSelect = false;
            this.dtgv_Citas.Name = "dtgv_Citas";
            this.dtgv_Citas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Citas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_Citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Citas.Size = new System.Drawing.Size(1143, 522);
            this.dtgv_Citas.TabIndex = 0;
            this.dtgv_Citas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Citas_CellDoubleClick);
            // 
            // lblCitas_Listado_Completo
            // 
            this.lblCitas_Listado_Completo.AutoSize = true;
            this.lblCitas_Listado_Completo.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 20F, System.Drawing.FontStyle.Bold);
            this.lblCitas_Listado_Completo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.lblCitas_Listado_Completo.Location = new System.Drawing.Point(866, 657);
            this.lblCitas_Listado_Completo.Name = "lblCitas_Listado_Completo";
            this.lblCitas_Listado_Completo.Size = new System.Drawing.Size(231, 36);
            this.lblCitas_Listado_Completo.TabIndex = 26;
            this.lblCitas_Listado_Completo.Text = "Listado Completo";
            // 
            // btnListado_Citas
            // 
            this.btnListado_Citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnListado_Citas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListado_Citas.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.btnListado_Citas.ElipseColor = System.Drawing.Color.Black;
            this.btnListado_Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado_Citas.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado_Citas.ForeColor = System.Drawing.Color.White;
            this.btnListado_Citas.Location = new System.Drawing.Point(1094, 662);
            this.btnListado_Citas.Name = "btnListado_Citas";
            this.btnListado_Citas.Radio = 10;
            this.btnListado_Citas.Size = new System.Drawing.Size(79, 30);
            this.btnListado_Citas.TabIndex = 27;
            this.btnListado_Citas.Text = "Ir";
            this.btnListado_Citas.UseVisualStyleBackColor = false;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(283, 48);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(223, 29);
            this.metroDateTime1.TabIndex = 28;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroDateTime1.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(107, 36);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(34, 44);
            this.btnAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAyuda.TabIndex = 25;
            this.btnAyuda.TabStop = false;
            // 
            // btn_Nueva_Cita
            // 
            this.btn_Nueva_Cita.BackColor = System.Drawing.Color.Transparent;
            this.btn_Nueva_Cita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nueva_Cita.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nueva_Cita.Image")));
            this.btn_Nueva_Cita.Location = new System.Drawing.Point(1094, 27);
            this.btn_Nueva_Cita.Name = "btn_Nueva_Cita";
            this.btn_Nueva_Cita.Size = new System.Drawing.Size(50, 53);
            this.btn_Nueva_Cita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Nueva_Cita.TabIndex = 23;
            this.btn_Nueva_Cita.TabStop = false;
            this.btn_Nueva_Cita.Click += new System.EventHandler(this.btn_Nueva_Cita_Click);
            // 
            // clmFechaDes
            // 
            this.clmFechaDes.DataPropertyName = "Fecha_Destinada1";
            this.clmFechaDes.HeaderText = "Fecha Destinada";
            this.clmFechaDes.Name = "clmFechaDes";
            this.clmFechaDes.ReadOnly = true;
            // 
            // clmHoraLle
            // 
            this.clmHoraLle.DataPropertyName = "Hora_Llegada1";
            this.clmHoraLle.HeaderText = "Hora Llegada";
            this.clmHoraLle.Name = "clmHoraLle";
            this.clmHoraLle.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.DataPropertyName = "Estado_Cita1";
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // clmHoraDes
            // 
            this.clmHoraDes.DataPropertyName = "Hora_destina1";
            this.clmHoraDes.HeaderText = "Hora Destinada";
            this.clmHoraDes.Name = "clmHoraDes";
            this.clmHoraDes.ReadOnly = true;
            // 
            // clmDuracion
            // 
            this.clmDuracion.DataPropertyName = "Tiempo_Duracion_Min1";
            this.clmDuracion.HeaderText = "Duracion";
            this.clmDuracion.Name = "clmDuracion";
            this.clmDuracion.ReadOnly = true;
            // 
            // clmNombreCli
            // 
            this.clmNombreCli.DataPropertyName = "NombreCliente1";
            this.clmNombreCli.HeaderText = "Nombre Cliente";
            this.clmNombreCli.Name = "clmNombreCli";
            this.clmNombreCli.ReadOnly = true;
            // 
            // clmApellidoCli
            // 
            this.clmApellidoCli.DataPropertyName = "ApellidoCliente1";
            this.clmApellidoCli.HeaderText = "Apellido Cliente";
            this.clmApellidoCli.Name = "clmApellidoCli";
            this.clmApellidoCli.ReadOnly = true;
            // 
            // clmNombreEmpleAtender
            // 
            this.clmNombreEmpleAtender.DataPropertyName = "Nombre_Empleado_Atender1";
            this.clmNombreEmpleAtender.HeaderText = "Nombre Atendedor";
            this.clmNombreEmpleAtender.Name = "clmNombreEmpleAtender";
            this.clmNombreEmpleAtender.ReadOnly = true;
            // 
            // clmApellidoEmpleAten
            // 
            this.clmApellidoEmpleAten.DataPropertyName = "Apellidos_EmpleadO_Atender1";
            this.clmApellidoEmpleAten.HeaderText = "Apellido Atendedor";
            this.clmApellidoEmpleAten.Name = "clmApellidoEmpleAten";
            this.clmApellidoEmpleAten.ReadOnly = true;
            // 
            // clmNombreEmpleAgen
            // 
            this.clmNombreEmpleAgen.DataPropertyName = "Nombre_Empleados_Agenda1";
            this.clmNombreEmpleAgen.HeaderText = "Nombre Agendador";
            this.clmNombreEmpleAgen.Name = "clmNombreEmpleAgen";
            this.clmNombreEmpleAgen.ReadOnly = true;
            // 
            // clmApellidoEmpleAgen
            // 
            this.clmApellidoEmpleAgen.DataPropertyName = "Apellidos_Empleados_Agenda1";
            this.clmApellidoEmpleAgen.HeaderText = "Apellido Agendador";
            this.clmApellidoEmpleAgen.Name = "clmApellidoEmpleAgen";
            this.clmApellidoEmpleAgen.ReadOnly = true;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "Cita_ID1";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmDetalla
            // 
            this.clmDetalla.DataPropertyName = "Detalle_Cita_ID1";
            this.clmDetalla.HeaderText = "Detalle";
            this.clmDetalla.Name = "clmDetalla";
            this.clmDetalla.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(821, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(898, 54);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(175, 22);
            this.txtBusqueda.TabIndex = 52;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.ItemHeight = 23;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Estado",
            "Nombre Cliente",
            "Apellido Cliente",
            "Nombre Atendedor",
            "Apellido Atendedor",
            "Nombre Agendador",
            "Apellido Agendador"});
            this.cmb_Tipo.Location = new System.Drawing.Point(620, 51);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(195, 29);
            this.cmb_Tipo.TabIndex = 51;
            this.cmb_Tipo.UseSelectable = true;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(512, 31);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(102, 47);
            this.lbltipo.TabIndex = 50;
            this.lbltipo.Text = "Tipo:";
            // 
            // frm_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.btnListado_Citas);
            this.Controls.Add(this.lblCitas_Listado_Completo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btn_Nueva_Cita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Citas";
            this.Load += new System.EventHandler(this.frm_Citas_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Citas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Nueva_Cita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.PictureBox btnAyuda;
        private System.Windows.Forms.PictureBox btn_Nueva_Cita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dtgv_Citas;
        private System.Windows.Forms.Label lblCitas_Listado_Completo;
        private UIDC.UI_ButtonMaterial btnListado_Citas;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoraLle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoraDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEmpleAtender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoEmpleAten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEmpleAgen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoEmpleAgen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetalla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private MetroFramework.Controls.MetroComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbltipo;
    }
}