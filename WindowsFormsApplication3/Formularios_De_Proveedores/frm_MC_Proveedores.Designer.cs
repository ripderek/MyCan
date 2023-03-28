namespace WindowsFormsApplication3
{
    partial class frm_MC_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MC_Proveedores));
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_Organizar = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.piNew = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new MetroFramework.Controls.MetroComboBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.clmNombreCompania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dataGridView1);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 77);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowShift = 10;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1197, 614);
            this.uI_ShadowPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombreCompania,
            this.clmNombre,
            this.clmApellido,
            this.clmIdentificacion,
            this.clmDireccion,
            this.clmCelular,
            this.clmNSucursal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(26, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 568);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmb_Organizar
            // 
            this.cmb_Organizar.FormattingEnabled = true;
            this.cmb_Organizar.ItemHeight = 23;
            this.cmb_Organizar.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.cmb_Organizar.Location = new System.Drawing.Point(270, 38);
            this.cmb_Organizar.Name = "cmb_Organizar";
            this.cmb_Organizar.Size = new System.Drawing.Size(199, 29);
            this.cmb_Organizar.TabIndex = 7;
            this.cmb_Organizar.UseSelectable = true;
            this.cmb_Organizar.SelectedIndexChanged += new System.EventHandler(this.cmb_Organizar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(81, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Organizar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1186, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // piNew
            // 
            this.piNew.BackColor = System.Drawing.Color.Transparent;
            this.piNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piNew.Image = ((System.Drawing.Image)(resources.GetObject("piNew.Image")));
            this.piNew.Location = new System.Drawing.Point(1083, 18);
            this.piNew.Name = "piNew";
            this.piNew.Size = new System.Drawing.Size(50, 53);
            this.piNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piNew.TabIndex = 11;
            this.piNew.TabStop = false;
            this.piNew.Click += new System.EventHandler(this.uI_ShadowPanel3_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(50, 27);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(34, 44);
            this.btnAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAyuda.TabIndex = 16;
            this.btnAyuda.TabStop = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(884, 39);
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
            "Nombre Compañia",
            "Nombre",
            "Apellido",
            "Identificacion",
            "Direccion",
            "Celular",
            "Numero Sucursal"});
            this.cmb_Tipo.Location = new System.Drawing.Point(583, 36);
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
            this.lbltipo.Location = new System.Drawing.Point(475, 24);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(102, 47);
            this.lbltipo.TabIndex = 50;
            this.lbltipo.Text = "Tipo:";
            // 
            // clmNombreCompania
            // 
            this.clmNombreCompania.DataPropertyName = "Nombre_Compania";
            this.clmNombreCompania.HeaderText = "Nombre Compañia";
            this.clmNombreCompania.Name = "clmNombreCompania";
            this.clmNombreCompania.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre_Persona";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmApellido
            // 
            this.clmApellido.DataPropertyName = "Apellido_Persona";
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            // 
            // clmIdentificacion
            // 
            this.clmIdentificacion.DataPropertyName = "Identi";
            this.clmIdentificacion.HeaderText = "Identificacion";
            this.clmIdentificacion.Name = "clmIdentificacion";
            this.clmIdentificacion.ReadOnly = true;
            // 
            // clmDireccion
            // 
            this.clmDireccion.DataPropertyName = "Celular_Persona";
            this.clmDireccion.HeaderText = "Direccion";
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.ReadOnly = true;
            // 
            // clmCelular
            // 
            this.clmCelular.DataPropertyName = "N_Sucursal";
            this.clmCelular.HeaderText = "Celular";
            this.clmCelular.Name = "clmCelular";
            this.clmCelular.ReadOnly = true;
            // 
            // clmNSucursal
            // 
            this.clmNSucursal.DataPropertyName = "Direccion_";
            this.clmNSucursal.HeaderText = "Numero Sucursal";
            this.clmNSucursal.Name = "clmNSucursal";
            this.clmNSucursal.ReadOnly = true;
            // 
            // frm_MC_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1221, 700);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.piNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Organizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MC_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MC_Proveedores";
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox cmb_Organizar;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox piNew;
        private System.Windows.Forms.PictureBox btnAyuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private MetroFramework.Controls.MetroComboBox cmb_Tipo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreCompania;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNSucursal;
    }
}