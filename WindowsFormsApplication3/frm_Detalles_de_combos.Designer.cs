namespace WindowsFormsApplication3
{
    partial class frm_Detalles_de_combos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.panel_citas_programadas = new UIDC.UI_ShadowPanel();
            this.dtg_DetalleCombo = new System.Windows.Forms.DataGridView();
            this.cmbCombos = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadUnitariaPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_citas_programadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DetalleCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_TitleBanner1
            // 
            this.uI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateOFF;
            this.uI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff;
            this.uI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close;
            this.uI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uI_TitleBanner1.FlatAppearance.BorderSize = 0;
            this.uI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uI_TitleBanner1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.uI_TitleBanner1.ForeColor = System.Drawing.Color.White;
            this.uI_TitleBanner1.Location = new System.Drawing.Point(0, 0);
            this.uI_TitleBanner1.MoveActive = true;
            this.uI_TitleBanner1.Name = "uI_TitleBanner1";
            this.uI_TitleBanner1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uI_TitleBanner1.ParentControl = this;
            this.uI_TitleBanner1.Size = new System.Drawing.Size(1221, 30);
            this.uI_TitleBanner1.TabIndex = 4;
            this.uI_TitleBanner1.Text = "DETALLE DE COMBOS";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // panel_citas_programadas
            // 
            this.panel_citas_programadas.BaseColor = System.Drawing.SystemColors.Window;
            this.panel_citas_programadas.Controls.Add(this.dtg_DetalleCombo);
            this.panel_citas_programadas.Location = new System.Drawing.Point(15, 83);
            this.panel_citas_programadas.Name = "panel_citas_programadas";
            this.panel_citas_programadas.ParentControl = this;
            this.panel_citas_programadas.Radius = 10;
            this.panel_citas_programadas.ShadowColor = System.Drawing.Color.Black;
            this.panel_citas_programadas.ShadowShift = 10;
            this.panel_citas_programadas.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.panel_citas_programadas.Size = new System.Drawing.Size(1183, 449);
            this.panel_citas_programadas.TabIndex = 5;
            // 
            // dtg_DetalleCombo
            // 
            this.dtg_DetalleCombo.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtg_DetalleCombo.AllowUserToAddRows = false;
            this.dtg_DetalleCombo.AllowUserToDeleteRows = false;
            this.dtg_DetalleCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_DetalleCombo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_DetalleCombo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_DetalleCombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_DetalleCombo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_DetalleCombo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_DetalleCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_DetalleCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DetalleCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNombreCombo,
            this.clmNombreProducto,
            this.clmCantidadUnitariaPro,
            this.clmCantidadProducto});
            this.dtg_DetalleCombo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_DetalleCombo.EnableHeadersVisualStyles = false;
            this.dtg_DetalleCombo.Location = new System.Drawing.Point(22, 20);
            this.dtg_DetalleCombo.Name = "dtg_DetalleCombo";
            this.dtg_DetalleCombo.ReadOnly = true;
            this.dtg_DetalleCombo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_DetalleCombo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_DetalleCombo.Size = new System.Drawing.Size(1139, 411);
            this.dtg_DetalleCombo.TabIndex = 0;
            // 
            // cmbCombos
            // 
            this.cmbCombos.FormattingEnabled = true;
            this.cmbCombos.ItemHeight = 23;
            this.cmbCombos.Location = new System.Drawing.Point(542, 44);
            this.cmbCombos.Name = "cmbCombos";
            this.cmbCombos.Size = new System.Drawing.Size(232, 29);
            this.cmbCombos.TabIndex = 68;
            this.cmbCombos.UseSelectable = true;
            this.cmbCombos.SelectionChangeCommitted += new System.EventHandler(this.cmbCombos_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(439, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 28);
            this.label9.TabIndex = 69;
            this.label9.Text = "Combos:";
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "IDcombo";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // clmNombreCombo
            // 
            this.clmNombreCombo.DataPropertyName = "Nombrecombo";
            this.clmNombreCombo.HeaderText = "Nombre del Combo";
            this.clmNombreCombo.Name = "clmNombreCombo";
            this.clmNombreCombo.ReadOnly = true;
            // 
            // clmNombreProducto
            // 
            this.clmNombreProducto.DataPropertyName = "Nombreproducto";
            this.clmNombreProducto.HeaderText = "Nombre Producto";
            this.clmNombreProducto.Name = "clmNombreProducto";
            this.clmNombreProducto.ReadOnly = true;
            // 
            // clmCantidadUnitariaPro
            // 
            this.clmCantidadUnitariaPro.DataPropertyName = "Cantidaduniro";
            this.clmCantidadUnitariaPro.HeaderText = "Cantidad Unitaria";
            this.clmCantidadUnitariaPro.Name = "clmCantidadUnitariaPro";
            this.clmCantidadUnitariaPro.ReadOnly = true;
            // 
            // clmCantidadProducto
            // 
            this.clmCantidadProducto.DataPropertyName = "Cantidadproducto";
            this.clmCantidadProducto.HeaderText = "Cantidad Producto";
            this.clmCantidadProducto.Name = "clmCantidadProducto";
            this.clmCantidadProducto.ReadOnly = true;
            // 
            // frm_Detalles_de_combos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 544);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCombos);
            this.Controls.Add(this.panel_citas_programadas);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Detalles_de_combos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE DE COMBOS";
            this.Load += new System.EventHandler(this.frm_Detalles_de_combos_Load);
            this.panel_citas_programadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DetalleCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_ShadowPanel panel_citas_programadas;
        private System.Windows.Forms.DataGridView dtg_DetalleCombo;
        private MetroFramework.Controls.MetroComboBox cmbCombos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadUnitariaPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadProducto;
    }
}