namespace WindowsFormsApplication3
{
    partial class frm_Ver_Comprobante_Recepcion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.uI_DragForm1 = new UIDC.UI_DragForm();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uI_ResizeControl1 = new UIDC.UI_ResizeControl();
            this.SP_DATOS_REPCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Comprobante_Recepcion_Producto = new WindowsFormsApplication3.DataSet_Comprobante_Recepcion_Producto();
            this.SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_REPCIONTableAdapter = new WindowsFormsApplication3.DataSet_Comprobante_Recepcion_ProductoTableAdapters.SP_DATOS_REPCIONTableAdapter();
            this.SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter = new WindowsFormsApplication3.DataSet_Comprobante_Recepcion_ProductoTableAdapters.SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter();
            this.SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter = new WindowsFormsApplication3.DataSet_Comprobante_Recepcion_ProductoTableAdapters.SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_REPCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Comprobante_Recepcion_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Datos_Recepcion";
            reportDataSource1.Value = this.SP_DATOS_REPCIONBindingSource;
            reportDataSource2.Name = "Productos_Recepcion";
            reportDataSource2.Value = this.SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource;
            reportDataSource3.Name = "Resultados_Recepcion";
            reportDataSource3.Value = this.SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_Comprobante_Recepcion_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(839, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
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
            this.uI_TitleBanner1.TabIndex = 2;
            this.uI_TitleBanner1.Text = "RECEPCION";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // uI_DragForm1
            // 
            this.uI_DragForm1._TargetControl = this;
            this.uI_DragForm1.Enabled = true;
            this.uI_DragForm1.ParentControl = this;
            this.uI_DragForm1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uI_ResizeControl1);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 374);
            this.panel1.TabIndex = 4;
            // 
            // uI_ResizeControl1
            // 
            this.uI_ResizeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uI_ResizeControl1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.uI_ResizeControl1.ForeColor = System.Drawing.Color.Black;
            this.uI_ResizeControl1.ForeColorDepth = 255;
            this.uI_ResizeControl1.Location = new System.Drawing.Point(819, 354);
            this.uI_ResizeControl1.Name = "uI_ResizeControl1";
            this.uI_ResizeControl1.Size = new System.Drawing.Size(20, 20);
            this.uI_ResizeControl1.TabIndex = 1;
            this.uI_ResizeControl1.TargetControl = this;
            // 
            // SP_DATOS_REPCIONBindingSource
            // 
            this.SP_DATOS_REPCIONBindingSource.DataMember = "SP_DATOS_REPCION";
            this.SP_DATOS_REPCIONBindingSource.DataSource = this.DataSet_Comprobante_Recepcion_Producto;
            // 
            // DataSet_Comprobante_Recepcion_Producto
            // 
            this.DataSet_Comprobante_Recepcion_Producto.DataSetName = "DataSet_Comprobante_Recepcion_Producto";
            this.DataSet_Comprobante_Recepcion_Producto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource
            // 
            this.SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource.DataMember = "SP_LISTAR_PRODUCTOS_RECEPCION";
            this.SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource.DataSource = this.DataSet_Comprobante_Recepcion_Producto;
            // 
            // SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource
            // 
            this.SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource.DataMember = "SP_RESULTADOS_RECEPCION_PRODUCTOS";
            this.SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource.DataSource = this.DataSet_Comprobante_Recepcion_Producto;
            // 
            // SP_DATOS_REPCIONTableAdapter
            // 
            this.SP_DATOS_REPCIONTableAdapter.ClearBeforeFill = true;
            // 
            // SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter
            // 
            this.SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter.ClearBeforeFill = true;
            // 
            // SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter
            // 
            this.SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Ver_Comprobante_Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Ver_Comprobante_Recepcion";
            this.Text = "RECEPCION";
            this.Load += new System.EventHandler(this.frm_Ver_Comprobante_Recepcion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_REPCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Comprobante_Recepcion_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_DATOS_REPCIONBindingSource;
        private DataSet_Comprobante_Recepcion_Producto DataSet_Comprobante_Recepcion_Producto;
        private System.Windows.Forms.BindingSource SP_LISTAR_PRODUCTOS_RECEPCIONBindingSource;
        private System.Windows.Forms.BindingSource SP_RESULTADOS_RECEPCION_PRODUCTOSBindingSource;
        private DataSet_Comprobante_Recepcion_ProductoTableAdapters.SP_DATOS_REPCIONTableAdapter SP_DATOS_REPCIONTableAdapter;
        private DataSet_Comprobante_Recepcion_ProductoTableAdapters.SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter SP_LISTAR_PRODUCTOS_RECEPCIONTableAdapter;
        private DataSet_Comprobante_Recepcion_ProductoTableAdapters.SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter SP_RESULTADOS_RECEPCION_PRODUCTOSTableAdapter;
        private UIDC.UI_Elipse uI_Elipse1;
        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_DragForm uI_DragForm1;
        private System.Windows.Forms.Panel panel1;
        private UIDC.UI_ResizeControl uI_ResizeControl1;
    }
}