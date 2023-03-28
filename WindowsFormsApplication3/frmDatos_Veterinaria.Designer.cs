namespace WindowsFormsApplication3
{
    partial class frmDatos_Veterinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos_Veterinaria));
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.lblCrear = new System.Windows.Forms.Label();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNum_Sucursal = new System.Windows.Forms.Label();
            this.txtDireccion_Vete = new System.Windows.Forms.TextBox();
            this.lblRuc_Vete = new System.Windows.Forms.Label();
            this.lblCelular_Vete = new System.Windows.Forms.Label();
            this.txtNombres_Vete = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(845, 48);
            this.panel_Titulo.TabIndex = 32;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_Titulo.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UIForeColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel_Titulo.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.panel_Titulo.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCrear.Location = new System.Drawing.Point(12, 1);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(399, 47);
            this.lblCrear.TabIndex = 4;
            this.lblCrear.Text = "Datos De La Veterinaria";
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label11.Location = new System.Drawing.Point(63, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 28);
            this.label11.TabIndex = 47;
            this.label11.Text = "Numero Sucursal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label10.Location = new System.Drawing.Point(63, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 46;
            this.label10.Text = "Celular:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label9.Location = new System.Drawing.Point(63, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 28);
            this.label9.TabIndex = 45;
            this.label9.Text = "RUC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label8.Location = new System.Drawing.Point(63, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 28);
            this.label8.TabIndex = 44;
            this.label8.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(63, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre:";
            // 
            // lblNum_Sucursal
            // 
            this.lblNum_Sucursal.AutoSize = true;
            this.lblNum_Sucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblNum_Sucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNum_Sucursal.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F);
            this.lblNum_Sucursal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNum_Sucursal.Location = new System.Drawing.Point(362, 317);
            this.lblNum_Sucursal.Name = "lblNum_Sucursal";
            this.lblNum_Sucursal.Size = new System.Drawing.Size(146, 28);
            this.lblNum_Sucursal.TabIndex = 52;
            this.lblNum_Sucursal.Text = "Num_Sucursal";
            // 
            // txtDireccion_Vete
            // 
            this.txtDireccion_Vete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtDireccion_Vete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion_Vete.Font = new System.Drawing.Font("Segoe UI Variable Small", 18F, System.Drawing.FontStyle.Bold);
            this.txtDireccion_Vete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDireccion_Vete.Location = new System.Drawing.Point(367, 169);
            this.txtDireccion_Vete.Name = "txtDireccion_Vete";
            this.txtDireccion_Vete.ReadOnly = true;
            this.txtDireccion_Vete.Size = new System.Drawing.Size(226, 32);
            this.txtDireccion_Vete.TabIndex = 48;
            this.txtDireccion_Vete.Text = "Direccion_Vete";
            // 
            // lblRuc_Vete
            // 
            this.lblRuc_Vete.AutoSize = true;
            this.lblRuc_Vete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblRuc_Vete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRuc_Vete.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F);
            this.lblRuc_Vete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRuc_Vete.Location = new System.Drawing.Point(362, 218);
            this.lblRuc_Vete.Name = "lblRuc_Vete";
            this.lblRuc_Vete.Size = new System.Drawing.Size(98, 28);
            this.lblRuc_Vete.TabIndex = 50;
            this.lblRuc_Vete.Text = "Ruc_Vete";
            // 
            // lblCelular_Vete
            // 
            this.lblCelular_Vete.AutoSize = true;
            this.lblCelular_Vete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblCelular_Vete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCelular_Vete.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F);
            this.lblCelular_Vete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCelular_Vete.Location = new System.Drawing.Point(362, 266);
            this.lblCelular_Vete.Name = "lblCelular_Vete";
            this.lblCelular_Vete.Size = new System.Drawing.Size(128, 28);
            this.lblCelular_Vete.TabIndex = 51;
            this.lblCelular_Vete.Text = "Celular_Vete";
            // 
            // txtNombres_Vete
            // 
            this.txtNombres_Vete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtNombres_Vete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres_Vete.Font = new System.Drawing.Font("Segoe UI Variable Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres_Vete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombres_Vete.Location = new System.Drawing.Point(367, 118);
            this.txtNombres_Vete.Name = "txtNombres_Vete";
            this.txtNombres_Vete.ReadOnly = true;
            this.txtNombres_Vete.Size = new System.Drawing.Size(216, 32);
            this.txtNombres_Vete.TabIndex = 49;
            this.txtNombres_Vete.Text = "Nombres_Vete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatos_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(783, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNum_Sucursal);
            this.Controls.Add(this.txtDireccion_Vete);
            this.Controls.Add(this.lblRuc_Vete);
            this.Controls.Add(this.lblCelular_Vete);
            this.Controls.Add(this.txtNombres_Vete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatos_Veterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatos_Veterinaria";
            this.Load += new System.EventHandler(this.frmDatos_Veterinaria_Load);
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_GradientPanel panel_Titulo;
        private System.Windows.Forms.Label lblCrear;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNum_Sucursal;
        private System.Windows.Forms.TextBox txtDireccion_Vete;
        private System.Windows.Forms.Label lblRuc_Vete;
        private System.Windows.Forms.Label lblCelular_Vete;
        private System.Windows.Forms.TextBox txtNombres_Vete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}