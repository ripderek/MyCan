namespace WindowsFormsApplication3
{
    partial class frm_VER_FACTURA_ELECTRONICA
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.uI_ResizeControl1 = new UIDC.UI_ResizeControl();
            this.DataSet_FACTURA_ELECTRONICA = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICA();
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter();
            this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter();
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter();
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.uI_ResizeControl2 = new UIDC.UI_ResizeControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_FACTURA_ELECTRONICA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uI_TitleBanner1
            // 
            this.uI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateOFF;
            this.uI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff;
            this.uI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close_Maximize_Minimize;
            this.uI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uI_TitleBanner1.FlatAppearance.BorderSize = 0;
            this.uI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.uI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uI_TitleBanner1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.uI_TitleBanner1.ForeColor = System.Drawing.Color.White;
            this.uI_TitleBanner1.Location = new System.Drawing.Point(0, 0);
            this.uI_TitleBanner1.MoveActive = true;
            this.uI_TitleBanner1.Name = "uI_TitleBanner1";
            this.uI_TitleBanner1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uI_TitleBanner1.ParentControl = this;
            this.uI_TitleBanner1.Size = new System.Drawing.Size(839, 30);
            this.uI_TitleBanner1.TabIndex = 4;
            this.uI_TitleBanner1.Text = "RECEPCION";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // uI_ResizeControl1
            // 
            this.uI_ResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ResizeControl1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.uI_ResizeControl1.ForeColor = System.Drawing.Color.Black;
            this.uI_ResizeControl1.ForeColorDepth = 255;
            this.uI_ResizeControl1.Location = new System.Drawing.Point(819, 384);
            this.uI_ResizeControl1.Name = "uI_ResizeControl1";
            this.uI_ResizeControl1.Size = new System.Drawing.Size(20, 20);
            this.uI_ResizeControl1.TabIndex = 5;
            this.uI_ResizeControl1.TargetControl = this;
            // 
            // DataSet_FACTURA_ELECTRONICA
            // 
            this.DataSet_FACTURA_ELECTRONICA.DataSetName = "DataSet_FACTURA_ELECTRONICA";
            this.DataSet_FACTURA_ELECTRONICA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01BindingSource
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataMember = "SP_VER_DATOS_VETERINARIA_DATASET01";
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataSource = this.DataSet_FACTURA_ELECTRONICA;
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.ClearBeforeFill = true;
            // 
            // SP_DATOS_DETALLE_FACTURA_DATASETBindingSource
            // 
            this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource.DataMember = "SP_DATOS_DETALLE_FACTURA_DATASET";
            this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource.DataSource = this.DataSet_FACTURA_ELECTRONICA;
            // 
            // SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter
            // 
            this.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter.ClearBeforeFill = true;
            // 
            // SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource
            // 
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource.DataMember = "SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASET";
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource.DataSource = this.DataSet_FACTURA_ELECTRONICA;
            // 
            // SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter
            // 
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter.ClearBeforeFill = true;
            // 
            // SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource
            // 
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource.DataMember = "SP_RESULTADOS_DETALLE_FACTURA_DATASET";
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource.DataSource = this.DataSet_FACTURA_ELECTRONICA;
            // 
            // SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter
            // 
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter.ClearBeforeFill = true;
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uI_ResizeControl2);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 374);
            this.panel1.TabIndex = 6;
            // 
            // uI_ResizeControl2
            // 
            this.uI_ResizeControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ResizeControl2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.uI_ResizeControl2.ForeColor = System.Drawing.Color.Black;
            this.uI_ResizeControl2.ForeColorDepth = 255;
            this.uI_ResizeControl2.Location = new System.Drawing.Point(819, 354);
            this.uI_ResizeControl2.Name = "uI_ResizeControl2";
            this.uI_ResizeControl2.Size = new System.Drawing.Size(20, 20);
            this.uI_ResizeControl2.TabIndex = 1;
            this.uI_ResizeControl2.TargetControl = null;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Veterinaria";
            reportDataSource1.Value = this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource;
            reportDataSource3.Name = "Productos";
            reportDataSource3.Value = this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource;
            reportDataSource4.Name = "Resultados";
            reportDataSource4.Value = this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_FACTURA_ELECTRONICA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(839, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_VER_FACTURA_ELECTRONICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uI_ResizeControl1);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_VER_FACTURA_ELECTRONICA";
            this.Text = "RECEPCION";
            this.Load += new System.EventHandler(this.frm_VER_FACTURA_ELECTRONICA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_FACTURA_ELECTRONICA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_ResizeControl uI_ResizeControl1;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
        private DataSet_FACTURA_ELECTRONICA DataSet_FACTURA_ELECTRONICA;
        private System.Windows.Forms.BindingSource SP_DATOS_DETALLE_FACTURA_DATASETBindingSource;
        private System.Windows.Forms.BindingSource SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource;
        private System.Windows.Forms.BindingSource SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter;
        private UIDC.UI_DragForm uI_DragForm1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Panel panel1;
        private UIDC.UI_ResizeControl uI_ResizeControl2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}