namespace WindowsFormsApplication3
{
    partial class frm_Accion_Historia_Clinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accion_Historia_Clinica));
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.lblCrear = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.btn_Ver_Historial = new UIDC.UI_ShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.panel_Titulo.SuspendLayout();
            this.btn_Ver_Historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btnRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Controls.Add(this.btnCerar);
            this.panel_Titulo.Location = new System.Drawing.Point(-11, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(544, 41);
            this.panel_Titulo.TabIndex = 32;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_Titulo.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
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
            this.lblCrear.Location = new System.Drawing.Point(22, -5);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(184, 47);
            this.lblCrear.TabIndex = 4;
            this.lblCrear.Text = "Opciones:";
            // 
            // btnCerar
            // 
            this.btnCerar.AutoSize = true;
            this.btnCerar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerar.Location = new System.Drawing.Point(504, -2);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 27;
            this.btnCerar.Text = "X";
            this.btnCerar.Click += new System.EventHandler(this.btnCerar_Click);
            // 
            // btn_Ver_Historial
            // 
            this.btn_Ver_Historial.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.btn_Ver_Historial.Controls.Add(this.pictureBox2);
            this.btn_Ver_Historial.Controls.Add(this.label2);
            this.btn_Ver_Historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ver_Historial.Location = new System.Drawing.Point(281, 69);
            this.btn_Ver_Historial.Name = "btn_Ver_Historial";
            this.btn_Ver_Historial.ParentControl = this;
            this.btn_Ver_Historial.Radius = 10;
            this.btn_Ver_Historial.ShadowColor = System.Drawing.Color.Black;
            this.btn_Ver_Historial.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btn_Ver_Historial.Size = new System.Drawing.Size(246, 74);
            this.btn_Ver_Historial.TabIndex = 34;
            this.btn_Ver_Historial.Click += new System.EventHandler(this.btn_Ver_Historial_Click);
            this.btn_Ver_Historial.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Ver_Historial_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(182, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.19F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ver Historial:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.btnRegistrar.Controls.Add(this.label1);
            this.btnRegistrar.Controls.Add(this.pictureBox1);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(4, 69);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.ParentControl = this;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.ShadowColor = System.Drawing.Color.Black;
            this.btnRegistrar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnRegistrar.Size = new System.Drawing.Size(246, 74);
            this.btnRegistrar.TabIndex = 35;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registrar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // frm_Accion_Historia_Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 178);
            this.Controls.Add(this.btn_Ver_Historial);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Accion_Historia_Clinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Accion_Historia_Clinica";
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            this.btn_Ver_Historial.ResumeLayout(false);
            this.btn_Ver_Historial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btnRegistrar.ResumeLayout(false);
            this.btnRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_GradientPanel panel_Titulo;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label btnCerar;
        private UIDC.UI_ShadowPanel btn_Ver_Historial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UIDC.UI_ShadowPanel btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UIDC.UI_Elipse uI_Elipse1;
    }
}