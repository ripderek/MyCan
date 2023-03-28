namespace WindowsFormsApplication3
{
    partial class MC_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC_CrearUsuario));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUsuario = new MetroFramework.Controls.MetroComboBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel5 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel6 = new UIDC.UI_ShadowPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.cmbPregunta = new MetroFramework.Controls.MetroComboBox();
            this.btnVer_Contra1 = new System.Windows.Forms.PictureBox();
            this.btnVer_Contra = new System.Windows.Forms.PictureBox();
            this.btnNo_Ver_Contra1 = new System.Windows.Forms.PictureBox();
            this.btnNo_Ver_Contra = new System.Windows.Forms.PictureBox();
            this.uI_PictureBox1 = new UIDC.UI_PictureBox();
            this.notifi_agregar = new UIDC.UI_Notification();
            this.uI_ShadowPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uI_PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Creación de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(312, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(312, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(312, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Repetir contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(312, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pregunta de seguridad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label6.Location = new System.Drawing.Point(312, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Respuesta de seguridad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label7.Location = new System.Drawing.Point(312, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Usuario:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.ItemHeight = 23;
            this.cmbUsuario.Items.AddRange(new object[] {
            "A"});
            this.cmbUsuario.Location = new System.Drawing.Point(422, 102);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(366, 29);
            this.cmbUsuario.TabIndex = 1;
            this.cmbUsuario.TabStop = false;
            this.cmbUsuario.UseSelectable = true;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(326, 184);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel1.TabIndex = 13;
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(326, 268);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(432, 29);
            this.uI_ShadowPanel2.TabIndex = 13;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(326, 350);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(432, 29);
            this.uI_ShadowPanel3.TabIndex = 13;
            // 
            // uI_ShadowPanel5
            // 
            this.uI_ShadowPanel5.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel5.Location = new System.Drawing.Point(326, 514);
            this.uI_ShadowPanel5.Name = "uI_ShadowPanel5";
            this.uI_ShadowPanel5.ParentControl = this;
            this.uI_ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel5.ShadowDepth = 50;
            this.uI_ShadowPanel5.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel5.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel5.TabIndex = 13;
            // 
            // uI_ShadowPanel6
            // 
            this.uI_ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.uI_ShadowPanel6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.uI_ShadowPanel6.Controls.Add(this.label8);
            this.uI_ShadowPanel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel6.Location = new System.Drawing.Point(623, 572);
            this.uI_ShadowPanel6.Name = "uI_ShadowPanel6";
            this.uI_ShadowPanel6.ParentControl = this;
            this.uI_ShadowPanel6.Radius = 2;
            this.uI_ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel6.ShadowDepth = 50;
            this.uI_ShadowPanel6.ShadowShift = 8;
            this.uI_ShadowPanel6.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel6.Size = new System.Drawing.Size(165, 54);
            this.uI_ShadowPanel6.TabIndex = 8;
            this.uI_ShadowPanel6.Click += new System.EventHandler(this.uI_ShadowPanel6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(29, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Continuar";
            this.label8.Click += new System.EventHandler(this.uI_ShadowPanel6_Click);
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(327, 178);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(461, 28);
            this.txtUserName.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(327, 262);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(431, 28);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPassword1
            // 
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(326, 344);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(432, 28);
            this.txtPassword1.TabIndex = 14;
            this.txtPassword1.UseSystemPasswordChar = true;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(328, 508);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(461, 28);
            this.txtRespuesta.TabIndex = 14;
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.ItemHeight = 23;
            this.cmbPregunta.Items.AddRange(new object[] {
            "Nombre de tu Mascota",
            "Nombre de tu escuela primaria",
            "Color favorito",
            "Videojuego Favorito",
            "Musica Favorita"});
            this.cmbPregunta.Location = new System.Drawing.Point(328, 438);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(460, 29);
            this.cmbPregunta.TabIndex = 1;
            this.cmbPregunta.TabStop = false;
            this.cmbPregunta.UseSelectable = true;
            this.cmbPregunta.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // btnVer_Contra1
            // 
            this.btnVer_Contra1.BackColor = System.Drawing.Color.Transparent;
            this.btnVer_Contra1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer_Contra1.Image = ((System.Drawing.Image)(resources.GetObject("btnVer_Contra1.Image")));
            this.btnVer_Contra1.Location = new System.Drawing.Point(764, 341);
            this.btnVer_Contra1.Name = "btnVer_Contra1";
            this.btnVer_Contra1.Size = new System.Drawing.Size(33, 30);
            this.btnVer_Contra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVer_Contra1.TabIndex = 15;
            this.btnVer_Contra1.TabStop = false;
            this.btnVer_Contra1.Visible = false;
            this.btnVer_Contra1.Click += new System.EventHandler(this.btnVer_Contra1_Click);
            // 
            // btnVer_Contra
            // 
            this.btnVer_Contra.BackColor = System.Drawing.Color.Transparent;
            this.btnVer_Contra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer_Contra.Image = ((System.Drawing.Image)(resources.GetObject("btnVer_Contra.Image")));
            this.btnVer_Contra.Location = new System.Drawing.Point(764, 262);
            this.btnVer_Contra.Name = "btnVer_Contra";
            this.btnVer_Contra.Size = new System.Drawing.Size(33, 30);
            this.btnVer_Contra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVer_Contra.TabIndex = 15;
            this.btnVer_Contra.TabStop = false;
            this.btnVer_Contra.Visible = false;
            this.btnVer_Contra.Click += new System.EventHandler(this.btnVer_Contra_Click);
            // 
            // btnNo_Ver_Contra1
            // 
            this.btnNo_Ver_Contra1.BackColor = System.Drawing.Color.Transparent;
            this.btnNo_Ver_Contra1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo_Ver_Contra1.Image = ((System.Drawing.Image)(resources.GetObject("btnNo_Ver_Contra1.Image")));
            this.btnNo_Ver_Contra1.Location = new System.Drawing.Point(764, 342);
            this.btnNo_Ver_Contra1.Name = "btnNo_Ver_Contra1";
            this.btnNo_Ver_Contra1.Size = new System.Drawing.Size(33, 30);
            this.btnNo_Ver_Contra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNo_Ver_Contra1.TabIndex = 15;
            this.btnNo_Ver_Contra1.TabStop = false;
            this.btnNo_Ver_Contra1.Visible = false;
            this.btnNo_Ver_Contra1.Click += new System.EventHandler(this.btnNo_Ver_Contra1_Click);
            // 
            // btnNo_Ver_Contra
            // 
            this.btnNo_Ver_Contra.BackColor = System.Drawing.Color.Transparent;
            this.btnNo_Ver_Contra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo_Ver_Contra.Image = ((System.Drawing.Image)(resources.GetObject("btnNo_Ver_Contra.Image")));
            this.btnNo_Ver_Contra.Location = new System.Drawing.Point(764, 262);
            this.btnNo_Ver_Contra.Name = "btnNo_Ver_Contra";
            this.btnNo_Ver_Contra.Size = new System.Drawing.Size(33, 30);
            this.btnNo_Ver_Contra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNo_Ver_Contra.TabIndex = 15;
            this.btnNo_Ver_Contra.TabStop = false;
            this.btnNo_Ver_Contra.Visible = false;
            this.btnNo_Ver_Contra.Click += new System.EventHandler(this.btnNo_Ver_Contra_Click);
            // 
            // uI_PictureBox1
            // 
            this.uI_PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("uI_PictureBox1.Image")));
            this.uI_PictureBox1.Location = new System.Drawing.Point(-19, 184);
            this.uI_PictureBox1.Name = "uI_PictureBox1";
            this.uI_PictureBox1.Size = new System.Drawing.Size(325, 327);
            this.uI_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uI_PictureBox1.TabIndex = 9;
            this.uI_PictureBox1.TabStop = false;
            // 
            // notifi_agregar
            // 
            this.notifi_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifi_agregar.CloseInterval = 5;
            this.notifi_agregar.EnabledNoti = false;
            this.notifi_agregar.Image = ((System.Drawing.Image)(resources.GetObject("notifi_agregar.Image")));
            this.notifi_agregar.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar.ImageElipse = true;
            this.notifi_agregar.ImageVisible = true;
            this.notifi_agregar.SoundEnabled = true;
            this.notifi_agregar.Text = "Notification text (Place text)";
            this.notifi_agregar.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifi_agregar.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar.TitleText = "Personal Agregado";
            this.notifi_agregar.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // MC_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(833, 694);
            this.Controls.Add(this.btnVer_Contra1);
            this.Controls.Add(this.btnVer_Contra);
            this.Controls.Add(this.btnNo_Ver_Contra1);
            this.Controls.Add(this.btnNo_Ver_Contra);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.uI_ShadowPanel6);
            this.Controls.Add(this.uI_ShadowPanel5);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uI_PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MC_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC_CrearUsuario";
            this.uI_ShadowPanel6.ResumeLayout(false);
            this.uI_ShadowPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uI_PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_PictureBox uI_PictureBox1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cmbUsuario;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel5;
        private UIDC.UI_ShadowPanel uI_ShadowPanel6;
        private System.Windows.Forms.Label label8;
        private UIDC.UI_DragForm uI_DragForm1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private MetroFramework.Controls.MetroComboBox cmbPregunta;
        private UIDC.UI_Notification notifi_agregar;
        private System.Windows.Forms.PictureBox btnVer_Contra;
        private System.Windows.Forms.PictureBox btnNo_Ver_Contra;
        private System.Windows.Forms.PictureBox btnVer_Contra1;
        private System.Windows.Forms.PictureBox btnNo_Ver_Contra1;
    }
}