namespace WindowsFormsApplication3
{
    partial class Form_RECEPCION_PRODUCTOS_CRUZADA
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
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dt_fecha_fin = new MetroFramework.Controls.MetroDateTime();
            this.dt_fecha_inicio = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_REPECION_COMPRAS_CRUZADA = new WindowsFormsApplication3.DataSet_REPECION_COMPRAS_CRUZADA();
            this.SP_ANLITICS_COMPRA_PRO_AÑOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter = new WindowsFormsApplication3.DataSet_REPECION_COMPRAS_CRUZADATableAdapters.SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter();
            this.SP_ANLITICS_COMPRA_PRO_TOTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter = new WindowsFormsApplication3.DataSet_REPECION_COMPRAS_CRUZADATableAdapters.SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_REPECION_COMPRAS_CRUZADA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANLITICS_COMPRA_PRO_AÑOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANLITICS_COMPRA_PRO_TOTALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dt_fecha_fin);
            this.uI_ShadowPanel1.Controls.Add(this.dt_fecha_inicio);
            this.uI_ShadowPanel1.Controls.Add(this.label1);
            this.uI_ShadowPanel1.Controls.Add(this.label5);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 9);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1228, 56);
            this.uI_ShadowPanel1.TabIndex = 3;
            // 
            // dt_fecha_fin
            // 
            this.dt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_fin.Location = new System.Drawing.Point(506, 17);
            this.dt_fecha_fin.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_fecha_fin.Name = "dt_fecha_fin";
            this.dt_fecha_fin.Size = new System.Drawing.Size(110, 29);
            this.dt_fecha_fin.TabIndex = 56;
            this.dt_fecha_fin.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.dt_fecha_fin.ValueChanged += new System.EventHandler(this.dt_fecha_fin_ValueChanged);
            // 
            // dt_fecha_inicio
            // 
            this.dt_fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_inicio.Location = new System.Drawing.Point(250, 17);
            this.dt_fecha_inicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_fecha_inicio.Name = "dt_fecha_inicio";
            this.dt_fecha_inicio.Size = new System.Drawing.Size(105, 29);
            this.dt_fecha_inicio.TabIndex = 56;
            this.dt_fecha_inicio.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.dt_fecha_inicio.ValueChanged += new System.EventHandler(this.dt_fecha_inicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(361, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Fecha Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(73, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha Inicio:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "asd";
            reportDataSource1.Value = this.SP_ANLITICS_COMPRA_PRO_AÑOBindingSource;
            reportDataSource2.Name = "sas";
            reportDataSource2.Value = this.SP_ANLITICS_COMPRA_PRO_TOTALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_RECEPCION_COMPRA_CRUZADA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(1213, 551);
            this.reportViewer1.TabIndex = 4;
            // 
            // DataSet_REPECION_COMPRAS_CRUZADA
            // 
            this.DataSet_REPECION_COMPRAS_CRUZADA.DataSetName = "DataSet_REPECION_COMPRAS_CRUZADA";
            this.DataSet_REPECION_COMPRAS_CRUZADA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_ANLITICS_COMPRA_PRO_AÑOBindingSource
            // 
            this.SP_ANLITICS_COMPRA_PRO_AÑOBindingSource.DataMember = "SP_ANLITICS_COMPRA_PRO_AÑO";
            this.SP_ANLITICS_COMPRA_PRO_AÑOBindingSource.DataSource = this.DataSet_REPECION_COMPRAS_CRUZADA;
            // 
            // SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter
            // 
            this.SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_ANLITICS_COMPRA_PRO_TOTALBindingSource
            // 
            this.SP_ANLITICS_COMPRA_PRO_TOTALBindingSource.DataMember = "SP_ANLITICS_COMPRA_PRO_TOTAL";
            this.SP_ANLITICS_COMPRA_PRO_TOTALBindingSource.DataSource = this.DataSet_REPECION_COMPRAS_CRUZADA;
            // 
            // SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter
            // 
            this.SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RECEPCION_PRODUCTOS_CRUZADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1237, 634);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RECEPCION_PRODUCTOS_CRUZADA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RECEPCION_PRODUCTOS_CRUZADA";
            this.Load += new System.EventHandler(this.Form_RECEPCION_PRODUCTOS_CRUZADA_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_REPECION_COMPRAS_CRUZADA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANLITICS_COMPRA_PRO_AÑOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANLITICS_COMPRA_PRO_TOTALBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private MetroFramework.Controls.MetroDateTime dt_fecha_fin;
        private MetroFramework.Controls.MetroDateTime dt_fecha_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_ANLITICS_COMPRA_PRO_AÑOBindingSource;
        private DataSet_REPECION_COMPRAS_CRUZADA DataSet_REPECION_COMPRAS_CRUZADA;
        private System.Windows.Forms.BindingSource SP_ANLITICS_COMPRA_PRO_TOTALBindingSource;
        private DataSet_REPECION_COMPRAS_CRUZADATableAdapters.SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter SP_ANLITICS_COMPRA_PRO_AÑOTableAdapter;
        private DataSet_REPECION_COMPRAS_CRUZADATableAdapters.SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter SP_ANLITICS_COMPRA_PRO_TOTALTableAdapter;
    }
}