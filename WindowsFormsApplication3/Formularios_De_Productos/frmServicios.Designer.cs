namespace WindowsFormsApplication3
{
    partial class frmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.dtgvServicio = new System.Windows.Forms.DataGridView();
            this.cmb_Organizar = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifica = new UIDC.UI_Notification();
            this.picAgregarProducto = new System.Windows.Forms.PictureBox();
            this.notifica_error = new UIDC.UI_Notification();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.cmb_Tipo = new MetroFramework.Controls.MetroComboBox();
            this.uI_ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProducto)).BeginInit();
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
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.AutoScroll = true;
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Controls.Add(this.dtgvServicio);
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(9, 72);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 20;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowShift = 10;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(1232, 572);
            this.uI_ShadowPanel2.TabIndex = 31;
            // 
            // dtgvServicio
            // 
            this.dtgvServicio.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtgvServicio.AllowUserToAddRows = false;
            this.dtgvServicio.AllowUserToDeleteRows = false;
            this.dtgvServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvServicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvServicio.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgvServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmPrecioVenta,
            this.clmDescripcion,
            this.clmCategoria,
            this.clmIDCategoria,
            this.clmEstado});
            this.dtgvServicio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgvServicio.EnableHeadersVisualStyles = false;
            this.dtgvServicio.Location = new System.Drawing.Point(35, 26);
            this.dtgvServicio.MultiSelect = false;
            this.dtgvServicio.Name = "dtgvServicio";
            this.dtgvServicio.ReadOnly = true;
            this.dtgvServicio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvServicio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvServicio.Size = new System.Drawing.Size(1149, 526);
            this.dtgvServicio.TabIndex = 1;
            this.dtgvServicio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvServicio_CellDoubleClick);
            // 
            // cmb_Organizar
            // 
            this.cmb_Organizar.FormattingEnabled = true;
            this.cmb_Organizar.ItemHeight = 23;
            this.cmb_Organizar.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.cmb_Organizar.Location = new System.Drawing.Point(222, 37);
            this.cmb_Organizar.Name = "cmb_Organizar";
            this.cmb_Organizar.Size = new System.Drawing.Size(243, 29);
            this.cmb_Organizar.TabIndex = 46;
            this.cmb_Organizar.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 47);
            this.label4.TabIndex = 45;
            this.label4.Text = "Organizar:";
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
            this.notifica.Text = "Se ha eliminado";
            this.notifica.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.TitleText = "SERVICIO ELIMINADO";
            this.notifica.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // picAgregarProducto
            // 
            this.picAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.picAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("picAgregarProducto.Image")));
            this.picAgregarProducto.Location = new System.Drawing.Point(1133, 16);
            this.picAgregarProducto.Name = "picAgregarProducto";
            this.picAgregarProducto.Size = new System.Drawing.Size(50, 53);
            this.picAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregarProducto.TabIndex = 50;
            this.picAgregarProducto.TabStop = false;
            this.picAgregarProducto.Click += new System.EventHandler(this.picAgregarProducto_Click);
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
            this.notifica_error.TitleText = "ERROR AL ELIMINAR";
            this.notifica_error.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "Servicio_id";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Servicio_";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmPrecioVenta
            // 
            this.clmPrecioVenta.DataPropertyName = "Precio_Venta_";
            this.clmPrecioVenta.HeaderText = "Precio Venta";
            this.clmPrecioVenta.Name = "clmPrecioVenta";
            this.clmPrecioVenta.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.DataPropertyName = "Descripcion_Servicio_";
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Categoria_";
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
            this.clmEstado.DataPropertyName = "Estado_";
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(821, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(895, 37);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(182, 22);
            this.txtBusqueda.TabIndex = 53;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(486, 22);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(102, 47);
            this.lbltipo.TabIndex = 51;
            this.lbltipo.Text = "Tipo:";
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.ItemHeight = 23;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Nombre",
            "Precio Venta",
            "Descripcion",
            "Categoria"});
            this.cmb_Tipo.Location = new System.Drawing.Point(585, 37);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(221, 29);
            this.cmb_Tipo.TabIndex = 55;
            this.cmb_Tipo.UseSelectable = true;
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 673);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.picAgregarProducto);
            this.Controls.Add(this.cmb_Organizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            this.uI_ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.DataGridView dtgvServicio;
        private UIDC.UI_Notification notifica;
        private MetroFramework.Controls.MetroComboBox cmb_Organizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picAgregarProducto;
        private UIDC.UI_Notification notifica_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lbltipo;
        private MetroFramework.Controls.MetroComboBox cmb_Tipo;
    }
}