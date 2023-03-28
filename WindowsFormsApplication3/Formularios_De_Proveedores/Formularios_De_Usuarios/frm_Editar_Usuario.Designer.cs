namespace WindowsFormsApplication3
{
    partial class frm_Editar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editar_Usuario));
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbPregunta = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContraseña2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.uI_PictureBox1 = new UIDC.UI_PictureBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnContinuar = new UIDC.UI_ShadowPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContraseña1 = new System.Windows.Forms.Label();
            this.btnVer_Contra = new System.Windows.Forms.PictureBox();
            this.btnNo_Ver_Contra = new System.Windows.Forms.PictureBox();
            this.panel_PreguntaSe = new UIDC.UI_ShadowPanel();
            this.txtPreguntaS = new System.Windows.Forms.TextBox();
            this.panel_CedUser = new UIDC.UI_ShadowPanel();
            this.txtCedulaUser = new System.Windows.Forms.TextBox();
            this.lblID_USER = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.notificacion = new UIDC.UI_Notification();
            this.btnNo_Ver_Contra1 = new System.Windows.Forms.PictureBox();
            this.btnVer_Contra1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.uI_PictureBox1)).BeginInit();
            this.btnContinuar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra1)).BeginInit();
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
            // txtRespuesta
            // 
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta.Location = new System.Drawing.Point(328, 508);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(461, 28);
            this.txtRespuesta.TabIndex = 25;
            // 
            // txtPassword1
            // 
            this.txtPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(326, 344);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(432, 28);
            this.txtPassword1.TabIndex = 26;
            this.txtPassword1.UseSystemPasswordChar = true;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(327, 262);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(431, 28);
            this.txtPassword.TabIndex = 27;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(327, 178);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(461, 28);
            this.txtUserName.TabIndex = 28;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
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
            this.cmbPregunta.Location = new System.Drawing.Point(324, 430);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(460, 29);
            this.cmbPregunta.TabIndex = 16;
            this.cmbPregunta.TabStop = false;
            this.cmbPregunta.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label6.Location = new System.Drawing.Point(312, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Respuesta de seguridad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(312, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pregunta de seguridad:";
            // 
            // lblContraseña2
            // 
            this.lblContraseña2.AutoSize = true;
            this.lblContraseña2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblContraseña2.Location = new System.Drawing.Point(312, 310);
            this.lblContraseña2.Name = "lblContraseña2";
            this.lblContraseña2.Size = new System.Drawing.Size(196, 28);
            this.lblContraseña2.TabIndex = 22;
            this.lblContraseña2.Text = "Nueva Constraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblUsuario.Location = new System.Drawing.Point(312, 102);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 28);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(312, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(309, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 43);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Editar Usuario";
            // 
            // uI_PictureBox1
            // 
            this.uI_PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("uI_PictureBox1.Image")));
            this.uI_PictureBox1.Location = new System.Drawing.Point(-94, 62);
            this.uI_PictureBox1.Name = "uI_PictureBox1";
            this.uI_PictureBox1.Size = new System.Drawing.Size(510, 506);
            this.uI_PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uI_PictureBox1.TabIndex = 18;
            this.uI_PictureBox1.TabStop = false;
            this.uI_PictureBox1.Click += new System.EventHandler(this.uI_PictureBox1_Click);
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(326, 186);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel1.TabIndex = 29;
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(326, 276);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(432, 29);
            this.uI_ShadowPanel2.TabIndex = 30;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(326, 353);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(432, 29);
            this.uI_ShadowPanel3.TabIndex = 30;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(327, 517);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(432, 29);
            this.uI_ShadowPanel4.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(327, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 28);
            this.textBox1.TabIndex = 26;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Transparent;
            this.btnContinuar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnContinuar.Controls.Add(this.label8);
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.Location = new System.Drawing.Point(633, 575);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.ParentControl = this;
            this.btnContinuar.Radius = 2;
            this.btnContinuar.ShadowColor = System.Drawing.Color.Black;
            this.btnContinuar.ShadowDepth = 50;
            this.btnContinuar.ShadowShift = 8;
            this.btnContinuar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnContinuar.Size = new System.Drawing.Size(165, 54);
            this.btnContinuar.TabIndex = 31;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
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
            // 
            // lblContraseña1
            // 
            this.lblContraseña1.AutoSize = true;
            this.lblContraseña1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblContraseña1.Location = new System.Drawing.Point(312, 225);
            this.lblContraseña1.Name = "lblContraseña1";
            this.lblContraseña1.Size = new System.Drawing.Size(186, 28);
            this.lblContraseña1.TabIndex = 24;
            this.lblContraseña1.Text = "Contraseña Actual";
            this.lblContraseña1.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnVer_Contra
            // 
            this.btnVer_Contra.BackColor = System.Drawing.Color.Transparent;
            this.btnVer_Contra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer_Contra.Image = ((System.Drawing.Image)(resources.GetObject("btnVer_Contra.Image")));
            this.btnVer_Contra.Location = new System.Drawing.Point(765, 267);
            this.btnVer_Contra.Name = "btnVer_Contra";
            this.btnVer_Contra.Size = new System.Drawing.Size(33, 30);
            this.btnVer_Contra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVer_Contra.TabIndex = 32;
            this.btnVer_Contra.TabStop = false;
            this.btnVer_Contra.Visible = false;
            this.btnVer_Contra.Click += new System.EventHandler(this.btnVer_Contra_Click);
            // 
            // btnNo_Ver_Contra
            // 
            this.btnNo_Ver_Contra.BackColor = System.Drawing.Color.Transparent;
            this.btnNo_Ver_Contra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo_Ver_Contra.Image = ((System.Drawing.Image)(resources.GetObject("btnNo_Ver_Contra.Image")));
            this.btnNo_Ver_Contra.Location = new System.Drawing.Point(765, 267);
            this.btnNo_Ver_Contra.Name = "btnNo_Ver_Contra";
            this.btnNo_Ver_Contra.Size = new System.Drawing.Size(33, 30);
            this.btnNo_Ver_Contra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNo_Ver_Contra.TabIndex = 33;
            this.btnNo_Ver_Contra.TabStop = false;
            this.btnNo_Ver_Contra.Visible = false;
            this.btnNo_Ver_Contra.Click += new System.EventHandler(this.btnNo_Ver_Contra_Click);
            // 
            // panel_PreguntaSe
            // 
            this.panel_PreguntaSe.BaseColor = System.Drawing.Color.White;
            this.panel_PreguntaSe.Location = new System.Drawing.Point(328, 432);
            this.panel_PreguntaSe.Name = "panel_PreguntaSe";
            this.panel_PreguntaSe.ParentControl = this;
            this.panel_PreguntaSe.ShadowColor = System.Drawing.Color.Black;
            this.panel_PreguntaSe.ShadowDepth = 50;
            this.panel_PreguntaSe.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.panel_PreguntaSe.Size = new System.Drawing.Size(432, 29);
            this.panel_PreguntaSe.TabIndex = 30;
            this.panel_PreguntaSe.Visible = false;
            // 
            // txtPreguntaS
            // 
            this.txtPreguntaS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreguntaS.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntaS.Location = new System.Drawing.Point(329, 426);
            this.txtPreguntaS.Name = "txtPreguntaS";
            this.txtPreguntaS.ReadOnly = true;
            this.txtPreguntaS.Size = new System.Drawing.Size(432, 28);
            this.txtPreguntaS.TabIndex = 26;
            this.txtPreguntaS.Visible = false;
            // 
            // panel_CedUser
            // 
            this.panel_CedUser.BaseColor = System.Drawing.Color.White;
            this.panel_CedUser.Location = new System.Drawing.Point(407, 107);
            this.panel_CedUser.Name = "panel_CedUser";
            this.panel_CedUser.ParentControl = this;
            this.panel_CedUser.ShadowColor = System.Drawing.Color.Black;
            this.panel_CedUser.ShadowDepth = 50;
            this.panel_CedUser.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.panel_CedUser.Size = new System.Drawing.Size(379, 29);
            this.panel_CedUser.TabIndex = 29;
            this.panel_CedUser.Visible = false;
            // 
            // txtCedulaUser
            // 
            this.txtCedulaUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaUser.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaUser.Location = new System.Drawing.Point(408, 99);
            this.txtCedulaUser.Name = "txtCedulaUser";
            this.txtCedulaUser.Size = new System.Drawing.Size(378, 28);
            this.txtCedulaUser.TabIndex = 28;
            this.txtCedulaUser.Visible = false;
            // 
            // lblID_USER
            // 
            this.lblID_USER.AutoSize = true;
            this.lblID_USER.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_USER.Location = new System.Drawing.Point(41, 84);
            this.lblID_USER.Name = "lblID_USER";
            this.lblID_USER.Size = new System.Drawing.Size(146, 43);
            this.lblID_USER.TabIndex = 19;
            this.lblID_USER.Text = "ID_USER";
            // 
            // btnCerar
            // 
            this.btnCerar.AutoSize = true;
            this.btnCerar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerar.Location = new System.Drawing.Point(775, -1);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 34;
            this.btnCerar.Text = "X";
            this.btnCerar.Click += new System.EventHandler(this.btnCerar_Click);
            // 
            // notificacion
            // 
            this.notificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notificacion.CloseInterval = 5;
            this.notificacion.EnabledNoti = false;
            this.notificacion.Image = ((System.Drawing.Image)(resources.GetObject("notificacion.Image")));
            this.notificacion.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notificacion.ImageElipse = true;
            this.notificacion.ImageVisible = true;
            this.notificacion.SoundEnabled = true;
            this.notificacion.Text = "Bienvenido a MyCan";
            this.notificacion.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notificacion.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notificacion.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notificacion.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notificacion.TitleText = "Inicio de Sesion";
            this.notificacion.TypeSound = UIDC.UI_Notification.sun.Hand;
            // 
            // btnNo_Ver_Contra1
            // 
            this.btnNo_Ver_Contra1.BackColor = System.Drawing.Color.Transparent;
            this.btnNo_Ver_Contra1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo_Ver_Contra1.Image = ((System.Drawing.Image)(resources.GetObject("btnNo_Ver_Contra1.Image")));
            this.btnNo_Ver_Contra1.Location = new System.Drawing.Point(766, 347);
            this.btnNo_Ver_Contra1.Name = "btnNo_Ver_Contra1";
            this.btnNo_Ver_Contra1.Size = new System.Drawing.Size(33, 30);
            this.btnNo_Ver_Contra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNo_Ver_Contra1.TabIndex = 33;
            this.btnNo_Ver_Contra1.TabStop = false;
            this.btnNo_Ver_Contra1.Visible = false;
            this.btnNo_Ver_Contra1.Click += new System.EventHandler(this.btnNo_Ver_Contra1_Click);
            // 
            // btnVer_Contra1
            // 
            this.btnVer_Contra1.BackColor = System.Drawing.Color.Transparent;
            this.btnVer_Contra1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer_Contra1.Image = ((System.Drawing.Image)(resources.GetObject("btnVer_Contra1.Image")));
            this.btnVer_Contra1.Location = new System.Drawing.Point(766, 347);
            this.btnVer_Contra1.Name = "btnVer_Contra1";
            this.btnVer_Contra1.Size = new System.Drawing.Size(33, 30);
            this.btnVer_Contra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVer_Contra1.TabIndex = 32;
            this.btnVer_Contra1.TabStop = false;
            this.btnVer_Contra1.Visible = false;
            this.btnVer_Contra1.Click += new System.EventHandler(this.btnVer_Contra1_Click);
            // 
            // frm_Editar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(817, 655);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.btnCerar);
            this.Controls.Add(this.btnVer_Contra1);
            this.Controls.Add(this.btnVer_Contra);
            this.Controls.Add(this.btnNo_Ver_Contra1);
            this.Controls.Add(this.btnNo_Ver_Contra);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPreguntaS);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.panel_PreguntaSe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.txtCedulaUser);
            this.Controls.Add(this.panel_CedUser);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblContraseña2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContraseña1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID_USER);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.uI_PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Editar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Editar_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.uI_PictureBox1)).EndInit();
            this.btnContinuar.ResumeLayout(false);
            this.btnContinuar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo_Ver_Contra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer_Contra1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private MetroFramework.Controls.MetroComboBox cmbPregunta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContraseña2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private UIDC.UI_PictureBox uI_PictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private UIDC.UI_ShadowPanel btnContinuar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblContraseña1;
        private System.Windows.Forms.PictureBox btnVer_Contra;
        private System.Windows.Forms.PictureBox btnNo_Ver_Contra;
        private System.Windows.Forms.TextBox txtPreguntaS;
        private UIDC.UI_ShadowPanel panel_PreguntaSe;
        private System.Windows.Forms.TextBox txtCedulaUser;
        private UIDC.UI_ShadowPanel panel_CedUser;
        private System.Windows.Forms.Label lblID_USER;
        private System.Windows.Forms.Label btnCerar;
        private UIDC.UI_Notification notificacion;
        private System.Windows.Forms.PictureBox btnVer_Contra1;
        private System.Windows.Forms.PictureBox btnNo_Ver_Contra1;
    }
}