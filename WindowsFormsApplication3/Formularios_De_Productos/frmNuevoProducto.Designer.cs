﻿namespace WindowsFormsApplication3
{
    partial class frmNuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoProducto));
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.lblCrear = new System.Windows.Forms.Label();
            this.cmb_Estado = new MetroFramework.Controls.MetroComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new UIDC.UI_ShadowPanel();
            this.lblRegistrar_Guardar = new System.Windows.Forms.Label();
            this.cmbCategoria = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioV2 = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel6 = new UIDC.UI_ShadowPanel();
            this.txtPrecioV1 = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel5 = new UIDC.UI_ShadowPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescipcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifica = new UIDC.UI_Notification();
            this.btnRegistrar = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.notifica_error = new UIDC.UI_Notification();
            this.panel_Titulo.SuspendLayout();
            this.btnGuardar.SuspendLayout();
            this.btnRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = null;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = null;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.uI_ShadowPanel1);
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Location = new System.Drawing.Point(-1, 0);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(725, 49);
            this.panel_Titulo.TabIndex = 31;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_Titulo.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UIForeColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel_Titulo.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.panel_Titulo.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.Coral;
            this.uI_ShadowPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(683, 7);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 6;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 20;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(37, 38);
            this.uI_ShadowPanel1.TabIndex = 31;
            this.uI_ShadowPanel1.Click += new System.EventHandler(this.uI_ShadowPanel1_Click);
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCrear.Location = new System.Drawing.Point(8, 1);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(190, 47);
            this.lblCrear.TabIndex = 4;
            this.lblCrear.Text = "Productos";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.ItemHeight = 23;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_Estado.Location = new System.Drawing.Point(272, 291);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(150, 29);
            this.cmb_Estado.TabIndex = 60;
            this.cmb_Estado.UseSelectable = true;
            this.cmb_Estado.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.lblEstado.Location = new System.Drawing.Point(33, 290);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 28);
            this.lblEstado.TabIndex = 59;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnGuardar.Controls.Add(this.lblRegistrar_Guardar);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(556, 276);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ParentControl = this;
            this.btnGuardar.Radius = 10;
            this.btnGuardar.ShadowColor = System.Drawing.Color.Black;
            this.btnGuardar.ShadowDepth = 50;
            this.btnGuardar.ShadowShift = 8;
            this.btnGuardar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnGuardar.Size = new System.Drawing.Size(136, 54);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRegistrar_Guardar
            // 
            this.lblRegistrar_Guardar.AutoSize = true;
            this.lblRegistrar_Guardar.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar_Guardar.ForeColor = System.Drawing.Color.White;
            this.lblRegistrar_Guardar.Location = new System.Drawing.Point(21, 12);
            this.lblRegistrar_Guardar.Name = "lblRegistrar_Guardar";
            this.lblRegistrar_Guardar.Size = new System.Drawing.Size(90, 28);
            this.lblRegistrar_Guardar.TabIndex = 0;
            this.lblRegistrar_Guardar.Text = "Guardar";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.ItemHeight = 23;
            this.cmbCategoria.Location = new System.Drawing.Point(270, 239);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(232, 29);
            this.cmbCategoria.TabIndex = 57;
            this.cmbCategoria.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(33, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 28);
            this.label9.TabIndex = 56;
            this.label9.Text = "Categoria:";
            // 
            // txtPrecioV2
            // 
            this.txtPrecioV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioV2.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV2.Location = new System.Drawing.Point(359, 134);
            this.txtPrecioV2.MaxLength = 2;
            this.txtPrecioV2.Name = "txtPrecioV2";
            this.txtPrecioV2.Size = new System.Drawing.Size(69, 28);
            this.txtPrecioV2.TabIndex = 54;
            this.txtPrecioV2.Text = "00";
            // 
            // uI_ShadowPanel6
            // 
            this.uI_ShadowPanel6.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel6.Location = new System.Drawing.Point(355, 139);
            this.uI_ShadowPanel6.Name = "uI_ShadowPanel6";
            this.uI_ShadowPanel6.ParentControl = this;
            this.uI_ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel6.ShadowDepth = 50;
            this.uI_ShadowPanel6.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel6.Size = new System.Drawing.Size(77, 29);
            this.uI_ShadowPanel6.TabIndex = 52;
            // 
            // txtPrecioV1
            // 
            this.txtPrecioV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioV1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV1.Location = new System.Drawing.Point(279, 134);
            this.txtPrecioV1.MaxLength = 50;
            this.txtPrecioV1.Name = "txtPrecioV1";
            this.txtPrecioV1.Size = new System.Drawing.Size(69, 28);
            this.txtPrecioV1.TabIndex = 55;
            this.txtPrecioV1.Text = "00";
            // 
            // uI_ShadowPanel5
            // 
            this.uI_ShadowPanel5.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel5.Location = new System.Drawing.Point(275, 139);
            this.uI_ShadowPanel5.Name = "uI_ShadowPanel5";
            this.uI_ShadowPanel5.ParentControl = this;
            this.uI_ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel5.ShadowDepth = 50;
            this.uI_ShadowPanel5.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel5.Size = new System.Drawing.Size(77, 29);
            this.uI_ShadowPanel5.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(33, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "Precio (Venta):";
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescipcion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescipcion.Location = new System.Drawing.Point(272, 183);
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(406, 28);
            this.txtDescipcion.TabIndex = 49;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(275, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(408, 28);
            this.txtNombre.TabIndex = 50;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(269, 189);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(414, 29);
            this.uI_ShadowPanel4.TabIndex = 47;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(272, 89);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(416, 29);
            this.uI_ShadowPanel3.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(33, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cantidad Por Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre:";
            // 
            // notifica
            // 
            this.notifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifica.CloseInterval = 5;
            this.notifica.EnabledNoti = false;
            this.notifica.Image = ((System.Drawing.Image)(resources.GetObject("notifica.Image")));
            this.notifica.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.ImageElipse = true;
            this.notifica.ImageVisible = true;
            this.notifica.SoundEnabled = true;
            this.notifica.Text = "Se registró el producto";
            this.notifica.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica.TitleText = "PRODUCTO REGISTRADO";
            this.notifica.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnRegistrar.Controls.Add(this.label3);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(556, 276);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.ParentControl = this;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.ShadowColor = System.Drawing.Color.Black;
            this.btnRegistrar.ShadowDepth = 50;
            this.btnRegistrar.ShadowShift = 8;
            this.btnRegistrar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnRegistrar.Size = new System.Drawing.Size(136, 54);
            this.btnRegistrar.TabIndex = 58;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registrar";
            // 
            // notifica_error
            // 
            this.notifica_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.notifica_error.CloseInterval = 5;
            this.notifica_error.EnabledNoti = false;
            this.notifica_error.Image = ((System.Drawing.Image)(resources.GetObject("notifica_error.Image")));
            this.notifica_error.ImageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica_error.ImageElipse = true;
            this.notifica_error.ImageVisible = true;
            this.notifica_error.SoundEnabled = true;
            this.notifica_error.Text = "Se proceso un error";
            this.notifica_error.TextFont = new System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.notifica_error.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notifica_error.TitleFont = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold);
            this.notifica_error.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.notifica_error.TitleText = "Error Al registrar";
            this.notifica_error.TypeSound = UIDC.UI_Notification.sun.Asterisk;
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 363);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecioV2);
            this.Controls.Add(this.uI_ShadowPanel6);
            this.Controls.Add(this.txtPrecioV1);
            this.Controls.Add(this.uI_ShadowPanel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescipcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoProducto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            this.btnGuardar.ResumeLayout(false);
            this.btnGuardar.PerformLayout();
            this.btnRegistrar.ResumeLayout(false);
            this.btnRegistrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Notification notifica;
        private UIDC.UI_GradientPanel panel_Titulo;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label lblCrear;
        private MetroFramework.Controls.MetroComboBox cmb_Estado;
        private System.Windows.Forms.Label lblEstado;
        private UIDC.UI_ShadowPanel btnGuardar;
        private System.Windows.Forms.Label lblRegistrar_Guardar;
        private MetroFramework.Controls.MetroComboBox cmbCategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioV2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel6;
        private System.Windows.Forms.TextBox txtPrecioV1;
        private UIDC.UI_ShadowPanel uI_ShadowPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescipcion;
        private System.Windows.Forms.TextBox txtNombre;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UIDC.UI_ShadowPanel btnRegistrar;
        private System.Windows.Forms.Label label3;
        private UIDC.UI_Notification notifica_error;
    }
}