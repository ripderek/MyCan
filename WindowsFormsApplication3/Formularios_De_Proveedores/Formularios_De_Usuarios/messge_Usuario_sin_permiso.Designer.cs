namespace WindowsFormsApplication3
{
    partial class messge_Usuario_sin_permiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messge_Usuario_sin_permiso));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uI_PictureBox1 = new UIDC.UI_PictureBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uI_PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.uI_ShadowPanel1.Controls.Add(this.label3);
            this.uI_ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(66, 116);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(149, 55);
            this.uI_ShadowPanel1.TabIndex = 3;
            this.uI_ShadowPanel1.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ok";
            this.label3.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario sin permiso";
            // 
            // uI_PictureBox1
            // 
            this.uI_PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("uI_PictureBox1.Image")));
            this.uI_PictureBox1.Location = new System.Drawing.Point(202, 3);
            this.uI_PictureBox1.Name = "uI_PictureBox1";
            this.uI_PictureBox1.Size = new System.Drawing.Size(374, 237);
            this.uI_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uI_PictureBox1.TabIndex = 5;
            this.uI_PictureBox1.TabStop = false;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContador.Location = new System.Drawing.Point(115, 187);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(47, 32);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "Ok";
            this.lblContador.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // messge_Usuario_sin_permiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(11)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(535, 252);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uI_PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messge_Usuario_sin_permiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "messge_Usuario_sin_permiso";
            this.Load += new System.EventHandler(this.messge_Usuario_sin_permiso_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uI_PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private UIDC.UI_PictureBox uI_PictureBox1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer timer1;
    }
}