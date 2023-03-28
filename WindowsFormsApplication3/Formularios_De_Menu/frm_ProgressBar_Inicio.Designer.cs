namespace WindowsFormsApplication3
{
    partial class frm_ProgressBar_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProgressBar_Inicio));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pg_procesamiento = new UIDC.UI_ProgressBarHatchStyle();
            this.panel_superior = new UIDC.UI_GradientPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCerar = new System.Windows.Forms.Label();
            this.panel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pg_procesamiento
            // 
            this.pg_procesamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(245)))));
            this.pg_procesamiento.BackgroundGradient = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.pg_procesamiento.BackgroundImageLayout = null;
            this.pg_procesamiento.BackgroundProgress = System.Drawing.Color.White;
            this.pg_procesamiento.CentralGradient = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pg_procesamiento.CentralGradientProgress = System.Drawing.Color.White;
            this.pg_procesamiento.CentralGradientProgress2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pg_procesamiento.DisplayValue = UIDC.UI_ProgressBarHatchStyle.Display.None;
            this.pg_procesamiento.GradientBackgroundProgress = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(145)))));
            this.pg_procesamiento.HatchStyle = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            this.pg_procesamiento.HatchStyleColor = System.Drawing.Color.Black;
            this.pg_procesamiento.HatchStyleTransparent = 70;
            this.pg_procesamiento.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(100)))), ((int)(((byte)(144)))));
            this.pg_procesamiento.Location = new System.Drawing.Point(37, 114);
            this.pg_procesamiento.Maximum = 100;
            this.pg_procesamiento.Minimum = 0;
            this.pg_procesamiento.Name = "pg_procesamiento";
            this.pg_procesamiento.ShadowDisplacement = 1.3D;
            this.pg_procesamiento.ShadowIntencity = 100;
            this.pg_procesamiento.ShadowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pg_procesamiento.Size = new System.Drawing.Size(236, 10);
            this.pg_procesamiento.TabIndex = 0;
            this.pg_procesamiento.Text = "uI_ProgressBarHatchStyle1";
            this.pg_procesamiento.TextAlign = UIDC.UI_ProgressBarHatchStyle.Text_Align.Center;
            this.pg_procesamiento.Value = 0;
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.White;
            this.panel_superior.Controls.Add(this.pg_procesamiento);
            this.panel_superior.Controls.Add(this.pictureBox4);
            this.panel_superior.Controls.Add(this.pictureBox2);
            this.panel_superior.Controls.Add(this.pictureBox3);
            this.panel_superior.Controls.Add(this.btnCerar);
            this.panel_superior.Location = new System.Drawing.Point(-5, -2);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(324, 155);
            this.panel_superior.TabIndex = 32;
            this.panel_superior.UIBackColor = System.Drawing.Color.Empty;
            this.panel_superior.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_superior.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_superior.UIForeColor = System.Drawing.Color.Empty;
            this.panel_superior.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel_superior.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.panel_superior.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_superior.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(27, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1011, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1076, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnCerar
            // 
            this.btnCerar.AutoSize = true;
            this.btnCerar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerar.Location = new System.Drawing.Point(1207, 11);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 27;
            this.btnCerar.Text = "X";
            // 
            // frm_ProgressBar_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(313, 154);
            this.Controls.Add(this.panel_superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ProgressBar_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ProgressBar_Inicio";
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Timer timer1;
        private UIDC.UI_ProgressBarHatchStyle pg_procesamiento;
        private UIDC.UI_GradientPanel panel_superior;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label btnCerar;
        private System.Windows.Forms.PictureBox pictureBox4;


    }
}