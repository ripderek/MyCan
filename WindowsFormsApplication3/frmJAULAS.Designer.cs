namespace WindowsFormsApplication3
{
    partial class frmJAULAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJAULAS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.btnNuevaJaula = new UIDC.UI_ShadowPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uI_LabelTransparent2 = new UIDC.UI_LabelTransparent();
            this.btnRecintos = new UIDC.UI_ShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uI_LabelTransparent1 = new UIDC.UI_LabelTransparent();
            this.btnRegiones = new UIDC.UI_ShadowPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategorias = new UIDC.UI_LabelTransparent();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadporunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piNew = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel12 = new UIDC.UI_ShadowPanel();
            this.btnNuevaJaula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.btnRecintos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnRegiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piNew)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // btnNuevaJaula
            // 
            this.btnNuevaJaula.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.btnNuevaJaula.Controls.Add(this.pictureBox3);
            this.btnNuevaJaula.Controls.Add(this.uI_LabelTransparent2);
            this.btnNuevaJaula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaJaula.Location = new System.Drawing.Point(623, 577);
            this.btnNuevaJaula.Name = "btnNuevaJaula";
            this.btnNuevaJaula.ParentControl = this;
            this.btnNuevaJaula.Radius = 10;
            this.btnNuevaJaula.ShadowColor = System.Drawing.Color.Black;
            this.btnNuevaJaula.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnNuevaJaula.Size = new System.Drawing.Size(283, 64);
            this.btnNuevaJaula.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // uI_LabelTransparent2
            // 
            this.uI_LabelTransparent2.AutoSize = true;
            this.uI_LabelTransparent2.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent2.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_LabelTransparent2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uI_LabelTransparent2.Location = new System.Drawing.Point(78, 11);
            this.uI_LabelTransparent2.Name = "uI_LabelTransparent2";
            this.uI_LabelTransparent2.Size = new System.Drawing.Size(185, 38);
            this.uI_LabelTransparent2.TabIndex = 6;
            this.uI_LabelTransparent2.Text = "Nueva Jaula";
            this.uI_LabelTransparent2.TransparentBackColor = System.Drawing.Color.Transparent;
            // 
            // btnRecintos
            // 
            this.btnRecintos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.btnRecintos.Controls.Add(this.pictureBox2);
            this.btnRecintos.Controls.Add(this.uI_LabelTransparent1);
            this.btnRecintos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecintos.Location = new System.Drawing.Point(12, 577);
            this.btnRecintos.Name = "btnRecintos";
            this.btnRecintos.ParentControl = this;
            this.btnRecintos.Radius = 10;
            this.btnRecintos.ShadowColor = System.Drawing.Color.Black;
            this.btnRecintos.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnRecintos.Size = new System.Drawing.Size(283, 64);
            this.btnRecintos.TabIndex = 9;
            this.btnRecintos.Click += new System.EventHandler(this.btnRecintos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // uI_LabelTransparent1
            // 
            this.uI_LabelTransparent1.AutoSize = true;
            this.uI_LabelTransparent1.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelTransparent1.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_LabelTransparent1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uI_LabelTransparent1.Location = new System.Drawing.Point(78, 11);
            this.uI_LabelTransparent1.Name = "uI_LabelTransparent1";
            this.uI_LabelTransparent1.Size = new System.Drawing.Size(133, 38);
            this.uI_LabelTransparent1.TabIndex = 6;
            this.uI_LabelTransparent1.Text = "Recintos";
            this.uI_LabelTransparent1.TransparentBackColor = System.Drawing.Color.Transparent;
            // 
            // btnRegiones
            // 
            this.btnRegiones.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
            this.btnRegiones.Controls.Add(this.pictureBox1);
            this.btnRegiones.Controls.Add(this.lblCategorias);
            this.btnRegiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegiones.Location = new System.Drawing.Point(317, 577);
            this.btnRegiones.Name = "btnRegiones";
            this.btnRegiones.ParentControl = this;
            this.btnRegiones.Radius = 10;
            this.btnRegiones.ShadowColor = System.Drawing.Color.Black;
            this.btnRegiones.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnRegiones.Size = new System.Drawing.Size(283, 64);
            this.btnRegiones.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.BackColor = System.Drawing.Color.Transparent;
            this.lblCategorias.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategorias.Location = new System.Drawing.Point(78, 11);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(142, 38);
            this.lblCategorias.TabIndex = 6;
            this.lblCategorias.Text = "Regiones";
            this.lblCategorias.TransparentBackColor = System.Drawing.Color.Transparent;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dataProductos);
            this.uI_ShadowPanel1.Controls.Add(this.piNew);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 59);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 20;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1197, 497);
            this.uI_ShadowPanel1.TabIndex = 7;
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToAddRows = false;
            this.dataProductos.AllowUserToDeleteRows = false;
            this.dataProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombre,
            this.clmPrecioVenta,
            this.clmStock,
            this.clmCantidadporunidad,
            this.clmCategoria,
            this.clmIDCategoria,
            this.clmEstado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataProductos.EnableHeadersVisualStyles = false;
            this.dataProductos.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataProductos.Location = new System.Drawing.Point(26, 22);
            this.dataProductos.MultiSelect = false;
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProductos.Size = new System.Drawing.Size(1146, 449);
            this.dataProductos.TabIndex = 0;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "Producto_id_";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.DataPropertyName = "Nombre_producto_";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmPrecioVenta
            // 
            this.clmPrecioVenta.DataPropertyName = "Precio_venta_";
            this.clmPrecioVenta.HeaderText = "Precio Venta";
            this.clmPrecioVenta.Name = "clmPrecioVenta";
            this.clmPrecioVenta.ReadOnly = true;
            // 
            // clmStock
            // 
            this.clmStock.DataPropertyName = "Stock_";
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            // 
            // clmCantidadporunidad
            // 
            this.clmCantidadporunidad.DataPropertyName = "Cantidad_por_unidad_";
            this.clmCantidadporunidad.HeaderText = "Cantidad por unidad";
            this.clmCantidadporunidad.Name = "clmCantidadporunidad";
            this.clmCantidadporunidad.ReadOnly = true;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Nombre_categoria_";
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
            this.clmEstado.DataPropertyName = "Estado";
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // piNew
            // 
            this.piNew.BackColor = System.Drawing.Color.Transparent;
            this.piNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piNew.Image = ((System.Drawing.Image)(resources.GetObject("piNew.Image")));
            this.piNew.Location = new System.Drawing.Point(936, 222);
            this.piNew.Name = "piNew";
            this.piNew.Size = new System.Drawing.Size(50, 53);
            this.piNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piNew.TabIndex = 13;
            this.piNew.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 47);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jaulas:";
            // 
            // uI_ShadowPanel12
            // 
            this.uI_ShadowPanel12.BackColor = System.Drawing.Color.Transparent;
            this.uI_ShadowPanel12.BaseColor = System.Drawing.Color.Coral;
            this.uI_ShadowPanel12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel12.Location = new System.Drawing.Point(1183, 1);
            this.uI_ShadowPanel12.Name = "uI_ShadowPanel12";
            this.uI_ShadowPanel12.ParentControl = this;
            this.uI_ShadowPanel12.Radius = 6;
            this.uI_ShadowPanel12.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel12.ShadowDepth = 20;
            this.uI_ShadowPanel12.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel12.Size = new System.Drawing.Size(37, 38);
            this.uI_ShadowPanel12.TabIndex = 31;
            this.uI_ShadowPanel12.Click += new System.EventHandler(this.uI_ShadowPanel12_Click);
            // 
            // frmJAULAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1221, 700);
            this.Controls.Add(this.uI_ShadowPanel12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNuevaJaula);
            this.Controls.Add(this.btnRecintos);
            this.Controls.Add(this.btnRegiones);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJAULAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJAULAS";
            this.btnNuevaJaula.ResumeLayout(false);
            this.btnNuevaJaula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.btnRecintos.ResumeLayout(false);
            this.btnRecintos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnRegiones.ResumeLayout(false);
            this.btnRegiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_ShadowPanel btnNuevaJaula;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UIDC.UI_LabelTransparent uI_LabelTransparent2;
        private UIDC.UI_ShadowPanel btnRecintos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UIDC.UI_LabelTransparent uI_LabelTransparent1;
        private UIDC.UI_ShadowPanel btnRegiones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UIDC.UI_LabelTransparent lblCategorias;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dataProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadporunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.PictureBox piNew;
        private System.Windows.Forms.Label label4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel12;
    }
}