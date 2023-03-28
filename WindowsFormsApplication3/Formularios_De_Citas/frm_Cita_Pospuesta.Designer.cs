namespace WindowsFormsApplication3
{
    partial class frm_Cita_Pospuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cita_Pospuesta));
            this.btnAgendar = new UIDC.UI_ButtonMaterial();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.TxtMinutos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datetimeFecha_Destinada = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.notifi_cita_pospuesta = new UIDC.UI_Notification();
            this.SuspendLayout();
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
            this.btnAgendar.Location = new System.Drawing.Point(362, 54);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Radio = 10;
            this.btnAgendar.Size = new System.Drawing.Size(143, 41);
            this.btnAgendar.TabIndex = 64;
            this.btnAgendar.Text = "Guardar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Window;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(259, 59);
            this.txtHora.MaxLength = 2;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(35, 35);
            this.txtHora.TabIndex = 62;
            this.txtHora.Text = "00";
            // 
            // TxtMinutos
            // 
            this.TxtMinutos.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMinutos.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinutos.Location = new System.Drawing.Point(300, 59);
            this.TxtMinutos.MaxLength = 2;
            this.TxtMinutos.Name = "TxtMinutos";
            this.TxtMinutos.Size = new System.Drawing.Size(35, 35);
            this.TxtMinutos.TabIndex = 63;
            this.TxtMinutos.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(59, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 28);
            this.label7.TabIndex = 61;
            this.label7.Text = "Hora destinada: ";
            // 
            // datetimeFecha_Destinada
            // 
            this.datetimeFecha_Destinada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeFecha_Destinada.Location = new System.Drawing.Point(259, 19);
            this.datetimeFecha_Destinada.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetimeFecha_Destinada.Name = "datetimeFecha_Destinada";
            this.datetimeFecha_Destinada.Size = new System.Drawing.Size(246, 29);
            this.datetimeFecha_Destinada.TabIndex = 66;
            this.datetimeFecha_Destinada.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(59, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Fecha Pospuesta:";
            // 
            // notifi_cita_pospuesta
            // 
            this.notifi_cita_pospuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifi_cita_pospuesta.CloseInterval = 5;
            this.notifi_cita_pospuesta.EnabledNoti = false;
            this.notifi_cita_pospuesta.Image = ((System.Drawing.Image)(resources.GetObject("notifi_cita_pospuesta.Image")));
            this.notifi_cita_pospuesta.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_cita_pospuesta.ImageElipse = true;
            this.notifi_cita_pospuesta.ImageVisible = true;
            this.notifi_cita_pospuesta.SoundEnabled = true;
            this.notifi_cita_pospuesta.Text = "Se pospuso la cita";
            this.notifi_cita_pospuesta.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifi_cita_pospuesta.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifi_cita_pospuesta.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifi_cita_pospuesta.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifi_cita_pospuesta.TitleText = "Cita Pospuesta";
            this.notifi_cita_pospuesta.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // frm_Cita_Pospuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 118);
            this.Controls.Add(this.datetimeFecha_Destinada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.TxtMinutos);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cita_Pospuesta";
            this.Text = "frm_Cita_Pospuesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_ButtonMaterial btnAgendar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox TxtMinutos;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroDateTime datetimeFecha_Destinada;
        private System.Windows.Forms.Label label5;
        private UIDC.UI_Notification notifi_cita_pospuesta;
    }
}