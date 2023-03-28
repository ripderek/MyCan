namespace WindowsFormsApplication3
{
    partial class frm_Listar_Paciente_Receta
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
            this.panel_opciones = new System.Windows.Forms.Panel();
            this.uI_ButtonMaterial1 = new UIDC.UI_ButtonMaterial();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_empleados = new System.Windows.Forms.Panel();
            this.dtg_Empleados = new System.Windows.Forms.DataGridView();
            this.panel_opciones.SuspendLayout();
            this.panel_empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_opciones
            // 
            this.panel_opciones.Controls.Add(this.uI_ButtonMaterial1);
            this.panel_opciones.Controls.Add(this.txtMedicamento);
            this.panel_opciones.Controls.Add(this.uI_ShadowPanel3);
            this.panel_opciones.Controls.Add(this.label2);
            this.panel_opciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_opciones.Location = new System.Drawing.Point(0, 398);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Size = new System.Drawing.Size(792, 75);
            this.panel_opciones.TabIndex = 1;
            // 
            // uI_ButtonMaterial1
            // 
            this.uI_ButtonMaterial1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.uI_ButtonMaterial1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ButtonMaterial1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uI_ButtonMaterial1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.uI_ButtonMaterial1.ElipseColor = System.Drawing.Color.Black;
            this.uI_ButtonMaterial1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uI_ButtonMaterial1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F);
            this.uI_ButtonMaterial1.ForeColor = System.Drawing.Color.Black;
            this.uI_ButtonMaterial1.Location = new System.Drawing.Point(621, 18);
            this.uI_ButtonMaterial1.Name = "uI_ButtonMaterial1";
            this.uI_ButtonMaterial1.Radio = 10;
            this.uI_ButtonMaterial1.Size = new System.Drawing.Size(143, 41);
            this.uI_ButtonMaterial1.TabIndex = 0;
            this.uI_ButtonMaterial1.Text = "Añadir";
            this.uI_ButtonMaterial1.UseVisualStyleBackColor = false;
            this.uI_ButtonMaterial1.Click += new System.EventHandler(this.uI_ButtonMaterial1_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedicamento.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamento.Location = new System.Drawing.Point(102, 20);
            this.txtMedicamento.MaxLength = 50;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.ReadOnly = true;
            this.txtMedicamento.Size = new System.Drawing.Size(338, 28);
            this.txtMedicamento.TabIndex = 46;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(99, 26);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(341, 29);
            this.uI_ShadowPanel3.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "Paciente:";
            // 
            // panel_empleados
            // 
            this.panel_empleados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_empleados.Controls.Add(this.dtg_Empleados);
            this.panel_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_empleados.Location = new System.Drawing.Point(0, 0);
            this.panel_empleados.Name = "panel_empleados";
            this.panel_empleados.Size = new System.Drawing.Size(792, 398);
            this.panel_empleados.TabIndex = 2;
            // 
            // dtg_Empleados
            // 
            this.dtg_Empleados.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.dtg_Empleados.AllowUserToAddRows = false;
            this.dtg_Empleados.AllowUserToDeleteRows = false;
            this.dtg_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_Empleados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtg_Empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_Empleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtg_Empleados.EnableHeadersVisualStyles = false;
            this.dtg_Empleados.Location = new System.Drawing.Point(0, 0);
            this.dtg_Empleados.Name = "dtg_Empleados";
            this.dtg_Empleados.ReadOnly = true;
            this.dtg_Empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_Empleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtg_Empleados.Size = new System.Drawing.Size(792, 398);
            this.dtg_Empleados.TabIndex = 2;
            this.dtg_Empleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Empleados_CellDoubleClick);
            // 
            // frm_Listar_Paciente_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.panel_empleados);
            this.Controls.Add(this.panel_opciones);
            this.Name = "frm_Listar_Paciente_Receta";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frm_Listar_Paciente_Receta_Load);
            this.panel_opciones.ResumeLayout(false);
            this.panel_opciones.PerformLayout();
            this.panel_empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_opciones;
        private UIDC.UI_ButtonMaterial uI_ButtonMaterial1;
        private System.Windows.Forms.TextBox txtMedicamento;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_empleados;
        private System.Windows.Forms.DataGridView dtg_Empleados;

    }
}