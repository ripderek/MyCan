﻿namespace WindowsFormsApplication3
{
    partial class frm_MC_Modificar_CrearProveedor
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
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentifacion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.cmb_Estado = new MetroFramework.Controls.MetroComboBox();
            this.cmbIdentificacion = new MetroFramework.Controls.MetroComboBox();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel5 = new UIDC.UI_ShadowPanel();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.lblCrear = new System.Windows.Forms.Label();
            this.btnCerar = new System.Windows.Forms.Label();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.btnGuardar = new UIDC.UI_ShadowPanel();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.panel_Titulo = new UIDC.UI_GradientPanel();
            this.btnEliminar = new UIDC.UI_ShadowPanel();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.uI_ShadowPanel6 = new UIDC.UI_ShadowPanel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel7 = new UIDC.UI_ShadowPanel();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.btnGuardar.SuspendLayout();
            this.panel_Titulo.SuspendLayout();
            this.btnEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.BackColor = System.Drawing.Color.Transparent;
            this.lblModificar.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblModificar.Location = new System.Drawing.Point(22, 8);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(191, 47);
            this.lblModificar.TabIndex = 4;
            this.lblModificar.Text = "Modificar:";
            this.lblModificar.Visible = false;
            this.lblModificar.Click += new System.EventHandler(this.lblModificar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(127, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(465, 28);
            this.txtNombre.TabIndex = 12;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(124, 130);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowDepth = 50;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(473, 29);
            this.uI_ShadowPanel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(61, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(130, 206);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(461, 28);
            this.txtApellidos.TabIndex = 15;
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(131, 212);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowDepth = 50;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(61, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellidos:";
            // 
            // txtIdentifacion
            // 
            this.txtIdentifacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentifacion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifacion.Location = new System.Drawing.Point(337, 289);
            this.txtIdentifacion.Name = "txtIdentifacion";
            this.txtIdentifacion.Size = new System.Drawing.Size(256, 28);
            this.txtIdentifacion.TabIndex = 21;
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(130, 371);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(461, 28);
            this.txtCelular.TabIndex = 22;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.ItemHeight = 23;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_Estado.Location = new System.Drawing.Point(130, 698);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(184, 29);
            this.cmb_Estado.TabIndex = 23;
            this.cmb_Estado.UseSelectable = true;
            this.cmb_Estado.Visible = false;
            // 
            // cmbIdentificacion
            // 
            this.cmbIdentificacion.FormattingEnabled = true;
            this.cmbIdentificacion.ItemHeight = 23;
            this.cmbIdentificacion.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte",
            "Ruc"});
            this.cmbIdentificacion.Location = new System.Drawing.Point(131, 295);
            this.cmbIdentificacion.Name = "cmbIdentificacion";
            this.cmbIdentificacion.Size = new System.Drawing.Size(184, 29);
            this.cmbIdentificacion.TabIndex = 24;
            this.cmbIdentificacion.UseSelectable = true;
            this.cmbIdentificacion.SelectionChangeCommitted += new System.EventHandler(this.cmbIdentificacion_SelectionChangeCommitted);
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(337, 295);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowDepth = 50;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(255, 29);
            this.uI_ShadowPanel3.TabIndex = 19;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(131, 377);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowDepth = 50;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel4.TabIndex = 20;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblEstado.Location = new System.Drawing.Point(61, 658);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 28);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(61, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Numero Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(61, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Identificacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(61, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero Sucursal:";
            // 
            // uI_ShadowPanel5
            // 
            this.uI_ShadowPanel5.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel5.Location = new System.Drawing.Point(127, 459);
            this.uI_ShadowPanel5.Name = "uI_ShadowPanel5";
            this.uI_ShadowPanel5.ParentControl = this;
            this.uI_ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel5.ShadowDepth = 50;
            this.uI_ShadowPanel5.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel5.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel5.TabIndex = 20;
            // 
            // txtSucursal
            // 
            this.txtSucursal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSucursal.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(126, 453);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(461, 28);
            this.txtSucursal.TabIndex = 22;
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCrear.Location = new System.Drawing.Point(22, 6);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(122, 47);
            this.lblCrear.TabIndex = 4;
            this.lblCrear.Text = "Crear:";
            // 
            // btnCerar
            // 
            this.btnCerar.AutoSize = true;
            this.btnCerar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerar.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerar.Location = new System.Drawing.Point(638, 0);
            this.btnCerar.Name = "btnCerar";
            this.btnCerar.Size = new System.Drawing.Size(40, 43);
            this.btnCerar.TabIndex = 27;
            this.btnCerar.Text = "X";
            this.btnCerar.Click += new System.EventHandler(this.label6_Click);
            this.btnCerar.MouseEnter += new System.EventHandler(this.btnCerar_MouseEnter);
            this.btnCerar.MouseLeave += new System.EventHandler(this.btnCerar_MouseLeave);
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnGuardar.Controls.Add(this.lblGuardar);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(460, 682);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ParentControl = this;
            this.btnGuardar.Radius = 2;
            this.btnGuardar.ShadowColor = System.Drawing.Color.Black;
            this.btnGuardar.ShadowDepth = 50;
            this.btnGuardar.ShadowShift = 8;
            this.btnGuardar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnGuardar.Size = new System.Drawing.Size(136, 54);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.ForeColor = System.Drawing.Color.White;
            this.lblGuardar.Location = new System.Drawing.Point(27, 12);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(90, 28);
            this.lblGuardar.TabIndex = 0;
            this.lblGuardar.Text = "Guardar";
            this.lblGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this;
            // 
            // panel_Titulo
            // 
            this.panel_Titulo.BackColor = System.Drawing.Color.White;
            this.panel_Titulo.Controls.Add(this.lblCrear);
            this.panel_Titulo.Controls.Add(this.lblModificar);
            this.panel_Titulo.Controls.Add(this.btnCerar);
            this.panel_Titulo.Location = new System.Drawing.Point(-1, -1);
            this.panel_Titulo.Name = "panel_Titulo";
            this.panel_Titulo.Size = new System.Drawing.Size(684, 60);
            this.panel_Titulo.TabIndex = 29;
            this.panel_Titulo.UIBackColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(111)))), ((int)(((byte)(249)))));
            this.panel_Titulo.UIBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UIForeColor = System.Drawing.Color.Empty;
            this.panel_Titulo.UIPrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panel_Titulo.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners;
            this.panel_Titulo.UITopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            this.panel_Titulo.UITopRight = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(23)))), ((int)(((byte)(205)))));
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(195)))));
            this.btnEliminar.Controls.Add(this.lblEliminar);
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(320, 682);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ParentControl = this;
            this.btnEliminar.Radius = 2;
            this.btnEliminar.ShadowColor = System.Drawing.Color.Black;
            this.btnEliminar.ShadowDepth = 50;
            this.btnEliminar.ShadowShift = 8;
            this.btnEliminar.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.btnEliminar.Size = new System.Drawing.Size(136, 54);
            this.btnEliminar.TabIndex = 28;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.White;
            this.lblEliminar.Location = new System.Drawing.Point(24, 12);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(88, 28);
            this.lblEliminar.TabIndex = 0;
            this.lblEliminar.Text = "Eliminar";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.lblDireccion.Location = new System.Drawing.Point(61, 505);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(106, 28);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Direccion:";
            // 
            // uI_ShadowPanel6
            // 
            this.uI_ShadowPanel6.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel6.Location = new System.Drawing.Point(129, 547);
            this.uI_ShadowPanel6.Name = "uI_ShadowPanel6";
            this.uI_ShadowPanel6.ParentControl = this;
            this.uI_ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel6.ShadowDepth = 50;
            this.uI_ShadowPanel6.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel6.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel6.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(129, 541);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(461, 28);
            this.txtDireccion.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(139)))));
            this.label6.Location = new System.Drawing.Point(66, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Compañia:";
            // 
            // uI_ShadowPanel7
            // 
            this.uI_ShadowPanel7.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel7.Location = new System.Drawing.Point(134, 630);
            this.uI_ShadowPanel7.Name = "uI_ShadowPanel7";
            this.uI_ShadowPanel7.ParentControl = this;
            this.uI_ShadowPanel7.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel7.ShadowDepth = 50;
            this.uI_ShadowPanel7.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel7.Size = new System.Drawing.Size(462, 29);
            this.uI_ShadowPanel7.TabIndex = 20;
            // 
            // txtCompañia
            // 
            this.txtCompañia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompañia.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompañia.Location = new System.Drawing.Point(134, 624);
            this.txtCompañia.MaxLength = 50;
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(461, 28);
            this.txtCompañia.TabIndex = 22;
            // 
            // frm_MC_Modificar_CrearProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(677, 788);
            this.Controls.Add(this.panel_Titulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIdentifacion);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.cmbIdentificacion);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel7);
            this.Controls.Add(this.uI_ShadowPanel6);
            this.Controls.Add(this.uI_ShadowPanel5);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MC_Modificar_CrearProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MC_Modificar_CrearProveedor";
            this.btnGuardar.ResumeLayout(false);
            this.btnGuardar.PerformLayout();
            this.panel_Titulo.ResumeLayout(false);
            this.panel_Titulo.PerformLayout();
            this.btnEliminar.ResumeLayout(false);
            this.btnEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.TextBox txtNombre;
        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidos;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentifacion;
        private System.Windows.Forms.TextBox txtCelular;
        private MetroFramework.Controls.MetroComboBox cmb_Estado;
        private MetroFramework.Controls.MetroComboBox cmbIdentificacion;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSucursal;
        private UIDC.UI_ShadowPanel uI_ShadowPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label btnCerar;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_ShadowPanel btnGuardar;
        private System.Windows.Forms.Label lblGuardar;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_GradientPanel panel_Titulo;
        private UIDC.UI_ShadowPanel btnEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtDireccion;
        private UIDC.UI_ShadowPanel uI_ShadowPanel6;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtCompañia;
        private UIDC.UI_ShadowPanel uI_ShadowPanel7;
        private System.Windows.Forms.Label label6;
    }
}