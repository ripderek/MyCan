namespace WindowsFormsApplication3
{
    partial class frm_CITA_ESTADISTICA
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
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dt_fecha_fin = new MetroFramework.Controls.MetroDateTime();
            this.dt_fecha_inicio = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_ESTADISTICA_CITAS = new WindowsFormsApplication3.DataSet_ESTADISTICA_CITAS();
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter = new WindowsFormsApplication3.DataSet_ESTADISTICA_CITASTableAdapters.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter();
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter = new WindowsFormsApplication3.DataSet_ESTADISTICA_CITASTableAdapters.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter();
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter = new WindowsFormsApplication3.DataSet_ESTADISTICA_CITASTableAdapters.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter();
            this.uI_ShadowPanel1.SuspendLayout();
            this.uI_ShadowPanel2.SuspendLayout();
            this.uI_ShadowPanel3.SuspendLayout();
            this.uI_ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ESTADISTICA_CITAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource)).BeginInit();
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
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(5, 9);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1228, 56);
            this.uI_ShadowPanel1.TabIndex = 4;
            // 
            // dt_fecha_fin
            // 
            this.dt_fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_fin.Location = new System.Drawing.Point(486, 14);
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
            this.dt_fecha_inicio.Location = new System.Drawing.Point(230, 14);
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
            this.label1.Location = new System.Drawing.Point(341, 9);
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
            this.label5.Location = new System.Drawing.Point(53, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha Inicio:";
            // 
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Controls.Add(this.reportViewer3);
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(44, 71);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 10;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(557, 323);
            this.uI_ShadowPanel2.TabIndex = 5;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Controls.Add(this.reportViewer2);
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(646, 71);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.Radius = 10;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(557, 323);
            this.uI_ShadowPanel3.TabIndex = 5;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Controls.Add(this.reportViewer1);
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(44, 410);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.Radius = 10;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(1159, 212);
            this.uI_ShadowPanel4.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_GRAFICO_PASTEL_1_CITAS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(36, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(1106, 184);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource2.Name = "asdasda";
            reportDataSource2.Value = this.SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_CITAS_ANALISIS_CIRCULAR2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(19, 16);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(521, 294);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportViewer3
            // 
            this.reportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource3.Name = "asdasd";
            reportDataSource3.Value = this.SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_CITAS_ANALISIS_CIRCULAR.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(20, 16);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ShowToolBar = false;
            this.reportViewer3.Size = new System.Drawing.Size(508, 294);
            this.reportViewer3.TabIndex = 0;
            // 
            // DataSet_ESTADISTICA_CITAS
            // 
            this.DataSet_ESTADISTICA_CITAS.DataSetName = "DataSet_ESTADISTICA_CITAS";
            this.DataSet_ESTADISTICA_CITAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource
            // 
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource.DataMember = "SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NO";
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource.DataSource = this.DataSet_ESTADISTICA_CITAS;
            // 
            // SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter
            // 
            this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource
            // 
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource.DataMember = "SP_ANALITICS_GRAFICA_PASTEL_NO_SE";
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource.DataSource = this.DataSet_ESTADISTICA_CITAS;
            // 
            // SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter
            // 
            this.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter.ClearBeforeFill = true;
            // 
            // SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource
            // 
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource.DataMember = "SP_ANALITICS_GRAFICA_PASTEL_SI_SE";
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource.DataSource = this.DataSet_ESTADISTICA_CITAS;
            // 
            // SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter
            // 
            this.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter.ClearBeforeFill = true;
            // 
            // frm_CITA_ESTADISTICA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1237, 634);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CITA_ESTADISTICA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CITA_ESTADISTICA";
            this.Load += new System.EventHandler(this.frm_CITA_ESTADISTICA_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel3.ResumeLayout(false);
            this.uI_ShadowPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ESTADISTICA_CITAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private MetroFramework.Controls.MetroDateTime dt_fecha_fin;
        private MetroFramework.Controls.MetroDateTime dt_fecha_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOBindingSource;
        private DataSet_ESTADISTICA_CITAS DataSet_ESTADISTICA_CITAS;
        private DataSet_ESTADISTICA_CITASTableAdapters.SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter SP_ANALITICS_NUMERO_CITAS_TERMINADAS_NOTableAdapter;
        private System.Windows.Forms.BindingSource SP_ANALITICS_GRAFICA_PASTEL_NO_SEBindingSource;
        private DataSet_ESTADISTICA_CITASTableAdapters.SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter SP_ANALITICS_GRAFICA_PASTEL_NO_SETableAdapter;
        private System.Windows.Forms.BindingSource SP_ANALITICS_GRAFICA_PASTEL_SI_SEBindingSource;
        private DataSet_ESTADISTICA_CITASTableAdapters.SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter SP_ANALITICS_GRAFICA_PASTEL_SI_SETableAdapter;
    }
}