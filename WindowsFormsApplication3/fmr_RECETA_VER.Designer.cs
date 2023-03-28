namespace WindowsFormsApplication3
{
    partial class fmr_RECETA_VER
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
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_RECETA_NUEVA = new WindowsFormsApplication3.DataSet_RECETA_NUEVA();
            this.SP_VER_DETALLE_RECETA_MEDICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_RECETA_MEDICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_RECETA_NUEVATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter();
            this.SP_VER_DETALLE_RECETA_MEDICATableAdapter = new WindowsFormsApplication3.DataSet_RECETA_NUEVATableAdapters.SP_VER_DETALLE_RECETA_MEDICATableAdapter();
            this.SP_VER_RECETA_MEDICATableAdapter = new WindowsFormsApplication3.DataSet_RECETA_NUEVATableAdapters.SP_VER_RECETA_MEDICATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_RECETA_NUEVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DETALLE_RECETA_MEDICABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_RECETA_MEDICABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01BindingSource
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataMember = "SP_VER_DATOS_VETERINARIA_DATASET01";
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataSource = this.DataSet_RECETA_NUEVA;
            // 
            // DataSet_RECETA_NUEVA
            // 
            this.DataSet_RECETA_NUEVA.DataSetName = "DataSet_RECETA_NUEVA";
            this.DataSet_RECETA_NUEVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VER_DETALLE_RECETA_MEDICABindingSource
            // 
            this.SP_VER_DETALLE_RECETA_MEDICABindingSource.DataMember = "SP_VER_DETALLE_RECETA_MEDICA";
            this.SP_VER_DETALLE_RECETA_MEDICABindingSource.DataSource = this.DataSet_RECETA_NUEVA;
            // 
            // SP_VER_RECETA_MEDICABindingSource
            // 
            this.SP_VER_RECETA_MEDICABindingSource.DataMember = "SP_VER_RECETA_MEDICA";
            this.SP_VER_RECETA_MEDICABindingSource.DataSource = this.DataSet_RECETA_NUEVA;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Veterinaria";
            reportDataSource1.Value = this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
            reportDataSource2.Name = "Detalle";
            reportDataSource2.Value = this.SP_VER_DETALLE_RECETA_MEDICABindingSource;
            reportDataSource3.Name = "Receta_Datos";
            reportDataSource3.Value = this.SP_VER_RECETA_MEDICABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_RECETA_NUEVA_XD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(561, 303);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_DETALLE_RECETA_MEDICATableAdapter
            // 
            this.SP_VER_DETALLE_RECETA_MEDICATableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_RECETA_MEDICATableAdapter
            // 
            this.SP_VER_RECETA_MEDICATableAdapter.ClearBeforeFill = true;
            // 
            // fmr_RECETA_VER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 303);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fmr_RECETA_VER";
            this.Text = "Receta Medica";
            this.Load += new System.EventHandler(this.fmr_RECETA_VER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_RECETA_NUEVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DETALLE_RECETA_MEDICABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_RECETA_MEDICABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
        private DataSet_RECETA_NUEVA DataSet_RECETA_NUEVA;
        private System.Windows.Forms.BindingSource SP_VER_DETALLE_RECETA_MEDICABindingSource;
        private System.Windows.Forms.BindingSource SP_VER_RECETA_MEDICABindingSource;
        private DataSet_RECETA_NUEVATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter;
        private DataSet_RECETA_NUEVATableAdapters.SP_VER_DETALLE_RECETA_MEDICATableAdapter SP_VER_DETALLE_RECETA_MEDICATableAdapter;
        private DataSet_RECETA_NUEVATableAdapters.SP_VER_RECETA_MEDICATableAdapter SP_VER_RECETA_MEDICATableAdapter;

    }
}