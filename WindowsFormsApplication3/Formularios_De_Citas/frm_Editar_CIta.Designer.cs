namespace WindowsFormsApplication3
{
    partial class frm_Editar_CIta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editar_CIta));
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.lblCrear = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.btnCita_Terminada = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCita_Pospuesta = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Cita_Nunca_LLegó = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_opcion = new UIDC.UI_ShadowPanel();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.notifi_no_llego = new UIDC.UI_Notification();
            this.panel_Titulo.SuspendLayout();
            this.btnCita_Terminada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnCita_Pospuesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.btn_Cita_Nunca_LLegó.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Controls.Add(this.btnCerar);
            this.panel_Titulo.Location = new System.Drawing.Point(0, -1);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(842, 41);
            this.panel_Titulo.TabIndex = 31;
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
            this.btnCerar.Location = new System.Drawing.Point(793, -2);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 27;
            this.btnCerar.Text = "X";
            this.btnCerar.Click += new System.EventHandler(this.btnCerar_Click);
            // 
            // btnCita_Terminada
            // 
            this.btnCita_Terminada.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.btnCita_Terminada.Controls.Add(this.label1);
            this.btnCita_Terminada.Controls.Add(this.pictureBox1);
            this.btnCita_Terminada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCita_Terminada.Location = new System.Drawing.Point(12, 55);
            this.btnCita_Terminada.Name = "btnCita_Terminada";
            this.btnCita_Terminada.ParentControl = this;
            this.btnCita_Terminada.Radius = 10;
            this.btnCita_Terminada.ShadowColor = System.Drawing.Color.Black;
            this.btnCita_Terminada.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnCita_Terminada.Size = new System.Drawing.Size(246, 74);
            this.btnCita_Terminada.TabIndex = 32;
            this.btnCita_Terminada.Click += new System.EventHandler(this.btnCita_Terminada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Terminada:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCita_Pospuesta
            // 
            this.btnCita_Pospuesta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.btnCita_Pospuesta.Controls.Add(this.label2);
            this.btnCita_Pospuesta.Controls.Add(this.pictureBox2);
            this.btnCita_Pospuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCita_Pospuesta.Location = new System.Drawing.Point(289, 55);
            this.btnCita_Pospuesta.Name = "btnCita_Pospuesta";
            this.btnCita_Pospuesta.ParentControl = this;
            this.btnCita_Pospuesta.Radius = 10;
            this.btnCita_Pospuesta.ShadowColor = System.Drawing.Color.Black;
            this.btnCita_Pospuesta.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnCita_Pospuesta.Size = new System.Drawing.Size(246, 74);
            this.btnCita_Pospuesta.TabIndex = 32;
            this.btnCita_Pospuesta.Click += new System.EventHandler(this.btnCita_Pospuesta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.19F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pospuesta:";
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
            // btn_Cita_Nunca_LLegó
            // 
            this.btn_Cita_Nunca_LLegó.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.btn_Cita_Nunca_LLegó.Controls.Add(this.label3);
            this.btn_Cita_Nunca_LLegó.Controls.Add(this.pictureBox3);
            this.btn_Cita_Nunca_LLegó.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cita_Nunca_LLegó.Location = new System.Drawing.Point(578, 55);
            this.btn_Cita_Nunca_LLegó.Name = "btn_Cita_Nunca_LLegó";
            this.btn_Cita_Nunca_LLegó.ParentControl = this;
            this.btn_Cita_Nunca_LLegó.Radius = 10;
            this.btn_Cita_Nunca_LLegó.ShadowColor = System.Drawing.Color.Black;
            this.btn_Cita_Nunca_LLegó.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btn_Cita_Nunca_LLegó.Size = new System.Drawing.Size(246, 74);
            this.btn_Cita_Nunca_LLegó.TabIndex = 32;
            this.btn_Cita_Nunca_LLegó.Click += new System.EventHandler(this.btn_Cita_Nunca_LLegó_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 19.19F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "No llegó:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(172, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel_opcion
            // 
            this.panel_opcion.BaseColor = System.Drawing.Color.White;
            this.panel_opcion.Location = new System.Drawing.Point(128, 135);
            this.panel_opcion.Name = "panel_opcion";
            this.panel_opcion.ParentControl = this;
            this.panel_opcion.Radius = 10;
            this.panel_opcion.ShadowColor = System.Drawing.Color.Black;
            this.panel_opcion.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.panel_opcion.Size = new System.Drawing.Size(561, 118);
            this.panel_opcion.TabIndex = 33;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // notifi_no_llego
            // 
            this.notifi_no_llego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifi_no_llego.CloseInterval = 5;
            this.notifi_no_llego.EnabledNoti = false;
            this.notifi_no_llego.Image = ((System.Drawing.Image)(resources.GetObject("notifi_no_llego.Image")));
            this.notifi_no_llego.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_no_llego.ImageElipse = true;
            this.notifi_no_llego.ImageVisible = true;
            this.notifi_no_llego.SoundEnabled = true;
            this.notifi_no_llego.Text = "El cliente no se presentó";
            this.notifi_no_llego.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifi_no_llego.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifi_no_llego.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifi_no_llego.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_no_llego.TitleText = "No se presentó";
            this.notifi_no_llego.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // frm_Editar_CIta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 265);
            this.Controls.Add(this.panel_opcion);
            this.Controls.Add(this.btn_Cita_Nunca_LLegó);
            this.Controls.Add(this.btnCita_Pospuesta);
            this.Controls.Add(this.btnCita_Terminada);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Editar_CIta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Editar_CIta";
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            this.btnCita_Terminada.ResumeLayout(false);
            this.btnCita_Terminada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnCita_Pospuesta.ResumeLayout(false);
            this.btnCita_Pospuesta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.btn_Cita_Nunca_LLegó.ResumeLayout(false);
            this.btn_Cita_Nunca_LLegó.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_GradientPanel panel_Titulo;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label btnCerar;
        private UIDC.UI_ShadowPanel btnCita_Terminada;
        private UIDC.UI_ShadowPanel btn_Cita_Nunca_LLegó;
        private UIDC.UI_ShadowPanel btnCita_Pospuesta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private UIDC.UI_ShadowPanel panel_opcion;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_Notification notifi_no_llego;
    }
}