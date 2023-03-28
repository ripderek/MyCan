namespace WindowsFormsApplication3
{
    partial class frm_Agregar_Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Agregar_Cita));
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.lblCrear = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempoDuracion = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel5 = new UIDC.UI_ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.datetimeFecha_Destinada = new MetroFramework.Controls.MetroDateTime();
            this.btnAgendar = new UIDC.UI_ButtonMaterial();
            this.Time_Hora_destinada = new MetroFramework.Controls.MetroDateTime();
            this.notifi_agregar = new UIDC.UI_Notification();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMinutos = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this.panel_Titulo;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this.panel_Titulo;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Controls.Add(this.btnCerar);
            this.panel_Titulo.Location = new System.Drawing.Point(-1, -1);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(664, 49);
            this.panel_Titulo.TabIndex = 30;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(78)))));
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
            this.lblCrear.Location = new System.Drawing.Point(22, 0);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(171, 47);
            this.lblCrear.TabIndex = 4;
            this.lblCrear.Text = "Agendar:";
            // 
            // btnCerar
            // 
            this.btnCerar.AutoSize = true;
            this.btnCerar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerar.Location = new System.Drawing.Point(624, 3);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 27;
            this.btnCerar.Text = "X";
            this.btnCerar.Click += new System.EventHandler(this.btnCerar_Click);
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtCedulaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaCliente.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(53, 122);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(246, 28);
            this.txtCedulaCliente.TabIndex = 45;
            this.txtCedulaCliente.TextChanged += new System.EventHandler(this.txtCedulaCliente_TextChanged);
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(50, 128);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel3.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(347, 122);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(246, 28);
            this.txtNombreCliente.TabIndex = 47;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(344, 128);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Medico:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 28);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(53, 227);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel2.TabIndex = 48;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreMedico.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(347, 221);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(246, 28);
            this.txtNombreMedico.TabIndex = 51;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(344, 227);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel4.TabIndex = 50;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(50, 323);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(543, 52);
            this.txtDescripcion.TabIndex = 52;
            this.txtDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(24, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tiempo Duracion (min):";
            // 
            // txtTiempoDuracion
            // 
            this.txtTiempoDuracion.BackColor = System.Drawing.SystemColors.Window;
            this.txtTiempoDuracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempoDuracion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoDuracion.Location = new System.Drawing.Point(56, 442);
            this.txtTiempoDuracion.Name = "txtTiempoDuracion";
            this.txtTiempoDuracion.Size = new System.Drawing.Size(246, 28);
            this.txtTiempoDuracion.TabIndex = 54;
            // 
            // uI_ShadowPanel5
            // 
            this.uI_ShadowPanel5.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel5.Location = new System.Drawing.Point(53, 448);
            this.uI_ShadowPanel5.Name = "uI_ShadowPanel5";
            this.uI_ShadowPanel5.ParentControl = this;
            this.uI_ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel5.ShadowDepth = 50;
            this.uI_ShadowPanel5.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel5.Size = new System.Drawing.Size(251, 29);
            this.uI_ShadowPanel5.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(339, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha Destinada:";
            // 
            // datetimeFecha_Destinada
            // 
            this.datetimeFecha_Destinada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeFecha_Destinada.Location = new System.Drawing.Point(347, 441);
            this.datetimeFecha_Destinada.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetimeFecha_Destinada.Name = "datetimeFecha_Destinada";
            this.datetimeFecha_Destinada.Size = new System.Drawing.Size(246, 29);
            this.datetimeFecha_Destinada.TabIndex = 55;
            this.datetimeFecha_Destinada.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(46)))), ((int)(((byte)(208)))));
            this.btnAgendar.ElipseColor = System.Drawing.Color.Black;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(452, 526);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Radio = 10;
            this.btnAgendar.Size = new System.Drawing.Size(143, 41);
            this.btnAgendar.TabIndex = 56;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // Time_Hora_destinada
            // 
            this.Time_Hora_destinada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_Hora_destinada.Location = new System.Drawing.Point(29, 535);
            this.Time_Hora_destinada.MinimumSize = new System.Drawing.Size(0, 29);
            this.Time_Hora_destinada.Name = "Time_Hora_destinada";
            this.Time_Hora_destinada.Size = new System.Drawing.Size(246, 29);
            this.Time_Hora_destinada.TabIndex = 55;
            this.Time_Hora_destinada.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Time_Hora_destinada.Value = new System.DateTime(2022, 2, 17, 20, 30, 0, 0);
            this.Time_Hora_destinada.Visible = false;
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
            this.notifi_agregar.Text = "Cita Agendada";
            this.notifi_agregar.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifi_agregar.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifi_agregar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_agregar.TitleText = "Cita Agendada";
            this.notifi_agregar.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(24, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "Time_Hora_destinada";
            this.label6.Visible = false;
            // 
            // TxtMinutos
            // 
            this.TxtMinutos.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMinutos.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinutos.Location = new System.Drawing.Point(508, 476);
            this.TxtMinutos.MaxLength = 2;
            this.TxtMinutos.Name = "TxtMinutos";
            this.TxtMinutos.Size = new System.Drawing.Size(35, 35);
            this.TxtMinutos.TabIndex = 54;
            this.TxtMinutos.Text = "00";
            this.TxtMinutos.TextChanged += new System.EventHandler(this.TxtMinutos_TextChanged);
            this.TxtMinutos.MouseEnter += new System.EventHandler(this.TxtMinutos_MouseEnter);
            this.TxtMinutos.MouseLeave += new System.EventHandler(this.TxtMinutos_MouseLeave);
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Window;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(467, 476);
            this.txtHora.MaxLength = 2;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(35, 35);
            this.txtHora.TabIndex = 54;
            this.txtHora.Text = "00";
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            this.txtHora.MouseEnter += new System.EventHandler(this.txtHora_MouseEnter);
            this.txtHora.MouseLeave += new System.EventHandler(this.txtHora_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(342, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "Hora: 24h";
            // 
            // frm_Agregar_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 594);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.Time_Hora_destinada);
            this.Controls.Add(this.datetimeFecha_Destinada);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.TxtMinutos);
            this.Controls.Add(this.txtTiempoDuracion);
            this.Controls.Add(this.uI_ShadowPanel5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreMedico);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.txtCedulaCliente);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Agregar_Cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Agregar_Cita";
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_GradientPanel panel_Titulo;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label btnCerar;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTiempoDuracion;
        private UIDC.UI_ShadowPanel uI_ShadowPanel5;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime datetimeFecha_Destinada;
        private UIDC.UI_ButtonMaterial btnAgendar;
        private MetroFramework.Controls.MetroDateTime Time_Hora_destinada;
        private UIDC.UI_Notification notifi_agregar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox TxtMinutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}