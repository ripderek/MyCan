namespace WindowsFormsApplication3
{
    partial class frm_Historia_Clinica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.cmb_Organizar = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dtgv_Pacientes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdentificacionClien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new MetroFramework.Controls.MetroComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // cmb_Organizar
            // 
            this.cmb_Organizar.FormattingEnabled = true;
            this.cmb_Organizar.ItemHeight = 23;
            this.cmb_Organizar.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.cmb_Organizar.Location = new System.Drawing.Point(261, 22);
            this.cmb_Organizar.Name = "cmb_Organizar";
            this.cmb_Organizar.Size = new System.Drawing.Size(199, 29);
            this.cmb_Organizar.TabIndex = 15;
            this.cmb_Organizar.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(72, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "Organizar:";
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dtgv_Pacientes);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(3, 61);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowShift = 10;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1197, 614);
            this.uI_ShadowPanel1.TabIndex = 13;
            // 
            // dtgv_Pacientes
            // 
            this.dtgv_Pacientes.AllowUserToAddRows = false;
            this.dtgv_Pacientes.AllowUserToDeleteRows = false;
            this.dtgv_Pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Pacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgv_Pacientes.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Pacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgv_Pacientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgv_Pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Pacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Pacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombrePaciente,
            this.clmEspecie,
            this.clmRaza,
            this.clmSexo,
            this.clmColor,
            this.clmApellidoClie,
            this.clmIdentificacionClien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Pacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_Pacientes.EnableHeadersVisualStyles = false;
            this.dtgv_Pacientes.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgv_Pacientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv_Pacientes.Location = new System.Drawing.Point(26, 21);
            this.dtgv_Pacientes.MultiSelect = false;
            this.dtgv_Pacientes.Name = "dtgv_Pacientes";
            this.dtgv_Pacientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Pacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_Pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Pacientes.Size = new System.Drawing.Size(1143, 568);
            this.dtgv_Pacientes.TabIndex = 0;
            this.dtgv_Pacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Pacientes_CellDoubleClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID_PACIENTE_";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombrePaciente
            // 
            this.clmNombrePaciente.DataPropertyName = "NOMBRE_PACIENTE_";
            this.clmNombrePaciente.HeaderText = "Nombre Paciente";
            this.clmNombrePaciente.Name = "clmNombrePaciente";
            this.clmNombrePaciente.ReadOnly = true;
            // 
            // clmEspecie
            // 
            this.clmEspecie.DataPropertyName = "ESPECIE_ANIMAL_";
            this.clmEspecie.HeaderText = "Especie";
            this.clmEspecie.Name = "clmEspecie";
            this.clmEspecie.ReadOnly = true;
            // 
            // clmRaza
            // 
            this.clmRaza.DataPropertyName = "RAZA_ANIMAL_";
            this.clmRaza.HeaderText = "Raza";
            this.clmRaza.Name = "clmRaza";
            this.clmRaza.ReadOnly = true;
            // 
            // clmSexo
            // 
            this.clmSexo.DataPropertyName = "SEXO_PACIENTE_";
            this.clmSexo.HeaderText = "Sexo";
            this.clmSexo.Name = "clmSexo";
            this.clmSexo.ReadOnly = true;
            // 
            // clmColor
            // 
            this.clmColor.DataPropertyName = "COLOR_PACIENTE_";
            this.clmColor.HeaderText = "Color";
            this.clmColor.Name = "clmColor";
            this.clmColor.ReadOnly = true;
            // 
            // clmApellidoClie
            // 
            this.clmApellidoClie.DataPropertyName = "APELLIDOS_CLIENTE";
            this.clmApellidoClie.HeaderText = "Apellido Cliente";
            this.clmApellidoClie.Name = "clmApellidoClie";
            this.clmApellidoClie.ReadOnly = true;
            // 
            // clmIdentificacionClien
            // 
            this.clmIdentificacionClien.DataPropertyName = "IDENTIFICACION_CLIENTE_";
            this.clmIdentificacionClien.HeaderText = "Identificacion Cliente";
            this.clmIdentificacionClien.Name = "clmIdentificacionClien";
            this.clmIdentificacionClien.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1166, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(814, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(888, 26);
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
            "Nombre Paciente",
            "Especie",
            "Raza",
            "Sexo",
            "Color",
            "Apellido Cliente",
            "Identificacion Cliente"});
            this.cmb_Tipo.Location = new System.Drawing.Point(587, 23);
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
            this.lbltipo.Location = new System.Drawing.Point(479, 11);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(102, 47);
            this.lbltipo.TabIndex = 50;
            this.lbltipo.Text = "Tipo:";
            // 
            // frm_Historia_Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Organizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Historia_Clinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Historia_Clinica";
            this.Load += new System.EventHandler(this.frm_Historia_Clinica_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private MetroFramework.Controls.MetroComboBox cmb_Organizar;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dtgv_Pacientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentificacionClien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private MetroFramework.Controls.MetroComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbltipo;
    }
}