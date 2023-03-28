namespace WindowsFormsApplication3
{
    partial class frmNOVEDADES_DEL_DIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNOVEDADES_DEL_DIA));
            this.btncerrar = new System.Windows.Forms.Label();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.lbltipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtCitas = new System.Windows.Forms.Label();
            this.txtOfertas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.AutoSize = true;
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Segoe UI Variable Display", 21.75F, System.Drawing.FontStyle.Bold);
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncerrar.Location = new System.Drawing.Point(502, -1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 38);
            this.btncerrar.TabIndex = 13;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 50;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.Color.Transparent;
            this.lbltipo.Font = new System.Drawing.Font("Segoe UI Variable Display", 55F, System.Drawing.FontStyle.Bold);
            this.lbltipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltipo.Location = new System.Drawing.Point(12, 9);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(202, 99);
            this.lbltipo.TabIndex = 1;
            this.lbltipo.Text = "Hola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 53);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tenemos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 53);
            this.label2.TabIndex = 53;
            this.label2.Text = "Novedades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 53);
            this.label3.TabIndex = 53;
            this.label3.Text = "Las siguientes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(336, 368);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.BackColor = System.Drawing.Color.Transparent;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStock.Location = new System.Drawing.Point(47, 277);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(395, 36);
            this.txtStock.TabIndex = 53;
            this.txtStock.Text = "Hay 1001 Ofertas programadas ";
            this.txtStock.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCitas
            // 
            this.txtCitas.AutoSize = true;
            this.txtCitas.BackColor = System.Drawing.Color.Transparent;
            this.txtCitas.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCitas.Location = new System.Drawing.Point(47, 322);
            this.txtCitas.Name = "txtCitas";
            this.txtCitas.Size = new System.Drawing.Size(395, 36);
            this.txtCitas.TabIndex = 53;
            this.txtCitas.Text = "Hay 1001 Ofertas programadas ";
            this.txtCitas.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOfertas
            // 
            this.txtOfertas.AutoSize = true;
            this.txtOfertas.BackColor = System.Drawing.Color.Transparent;
            this.txtOfertas.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfertas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOfertas.Location = new System.Drawing.Point(47, 369);
            this.txtOfertas.Name = "txtOfertas";
            this.txtOfertas.Size = new System.Drawing.Size(395, 36);
            this.txtOfertas.TabIndex = 53;
            this.txtOfertas.Text = "Hay 1001 Ofertas programadas ";
            this.txtOfertas.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmNOVEDADES_DEL_DIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(48)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(541, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txtOfertas);
            this.Controls.Add(this.txtCitas);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNOVEDADES_DEL_DIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNOVEDADES_DEL_DIA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btncerrar;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtOfertas;
        private System.Windows.Forms.Label txtCitas;
        private System.Windows.Forms.Label txtStock;
    }
}