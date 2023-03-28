namespace WindowsFormsApplication3
{
    partial class frm_Report_FACS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dt_Facturas = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_FACTURA_ELECTRONICA = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICA();
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter();
            this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter();
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter();
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter = new WindowsFormsApplication3.DataSet_FACTURA_ELECTRONICATableAdapters.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_FACTURA_ELECTRONICA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dt_Facturas);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 12);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(308, 674);
            this.uI_ShadowPanel1.TabIndex = 4;
            // 
            // dt_Facturas
            // 
            this.dt_Facturas.AllowUserToAddRows = false;
            this.dt_Facturas.AllowUserToDeleteRows = false;
            this.dt_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_Facturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dt_Facturas.BackgroundColor = System.Drawing.Color.White;
            this.dt_Facturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_Facturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dt_Facturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dt_Facturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_Facturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_Facturas.EnableHeadersVisualStyles = false;
            this.dt_Facturas.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dt_Facturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Facturas.Location = new System.Drawing.Point(15, 12);
            this.dt_Facturas.MultiSelect = false;
            this.dt_Facturas.Name = "dt_Facturas";
            this.dt_Facturas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Facturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_Facturas.Size = new System.Drawing.Size(274, 636);
            this.dt_Facturas.TabIndex = 4;
            this.dt_Facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Facturas_CellContentClick);
            this.dt_Facturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Facturas_CellDoubleClick);
            // 
            // reportViewer1
            // 
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
            this.reportViewer1.Location = new System.Drawing.Point(340, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(885, 610);
            this.reportViewer1.TabIndex = 5;
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
            // frm_Report_FACS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 634);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Report_FACS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Report_FACS";
            this.Load += new System.EventHandler(this.frm_Report_FACS_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_FACTURA_ELECTRONICA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_DETALLE_FACTURA_DATASETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dt_Facturas;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
        private DataSet_FACTURA_ELECTRONICA DataSet_FACTURA_ELECTRONICA;
        private System.Windows.Forms.BindingSource SP_DATOS_DETALLE_FACTURA_DATASETBindingSource;
        private System.Windows.Forms.BindingSource SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETBindingSource;
        private System.Windows.Forms.BindingSource SP_RESULTADOS_DETALLE_FACTURA_DATASETBindingSource;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter SP_DATOS_DETALLE_FACTURA_DATASETTableAdapter;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter SP_LISTA_PRODUCTOS_DETALLE_FACTURA_DATASETTableAdapter;
        private DataSet_FACTURA_ELECTRONICATableAdapters.SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter SP_RESULTADOS_DETALLE_FACTURA_DATASETTableAdapter;
    }
}