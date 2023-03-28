namespace WindowsFormsApplication3
{
    partial class frm_VER_TOP_5_POR_TIPOS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_TOP_5_POR_TIPOS = new WindowsFormsApplication3.DataSet_TOP_5_POR_TIPOS();
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.cmbFiltro = new MetroFramework.Controls.MetroComboBox();
            this.toggle = new UIDC.UI_MaterialToggle();
            this.dt_fecha = new MetroFramework.Controls.MetroDateTime();
            this.dt_fecha_fin = new MetroFramework.Controls.MetroDateTime();
            this.dt_fecha_inicio = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uI_ShadowPanel2 = new UIDC.UI_ShadowPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uI_ShadowPanel3 = new UIDC.UI_ShadowPanel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uI_ShadowPanel4 = new UIDC.UI_ShadowPanel();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter = new WindowsFormsApplication3.DataSet_TOP_5_POR_TIPOSTableAdapters.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_TOP_5_POR_TIPOS)).BeginInit();
            this.uI_ShadowPanel1.SuspendLayout();
            this.uI_ShadowPanel2.SuspendLayout();
            this.uI_ShadowPanel3.SuspendLayout();
            this.uI_ShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource
            // 
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource.DataMember = "SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOS";
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource.DataSource = this.DataSet_TOP_5_POR_TIPOS;
            // 
            // DataSet_TOP_5_POR_TIPOS
            // 
            this.DataSet_TOP_5_POR_TIPOS.DataSetName = "DataSet_TOP_5_POR_TIPOS";
            this.DataSet_TOP_5_POR_TIPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.cmbFiltro);
            this.uI_ShadowPanel1.Controls.Add(this.toggle);
            this.uI_ShadowPanel1.Controls.Add(this.dt_fecha);
            this.uI_ShadowPanel1.Controls.Add(this.dt_fecha_fin);
            this.uI_ShadowPanel1.Controls.Add(this.dt_fecha_inicio);
            this.uI_ShadowPanel1.Controls.Add(this.label2);
            this.uI_ShadowPanel1.Controls.Add(this.label1);
            this.uI_ShadowPanel1.Controls.Add(this.label5);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 9);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(1228, 56);
            this.uI_ShadowPanel1.TabIndex = 2;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Enabled = false;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.ItemHeight = 23;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Año",
            "Mes",
            "Dia",
            "Todo"});
            this.cmbFiltro.Location = new System.Drawing.Point(936, 15);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(203, 29);
            this.cmbFiltro.TabIndex = 58;
            this.cmbFiltro.UseSelectable = true;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // toggle
            // 
            this.toggle.AutoSize = true;
            this.toggle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.toggle.Checked = true;
            this.toggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggle.EllipseBorderColor = "#3b73d1";
            this.toggle.EllipseColor = "#508ef5";
            this.toggle.Location = new System.Drawing.Point(640, 23);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(47, 19);
            this.toggle.TabIndex = 57;
            this.toggle.Text = "uI_MaterialToggle1";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.CheckedChanged += new System.EventHandler(this.toggle_CheckedChanged);
            // 
            // dt_fecha
            // 
            this.dt_fecha.Enabled = false;
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(808, 15);
            this.dt_fecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(110, 29);
            this.dt_fecha.TabIndex = 56;
            this.dt_fecha.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            this.dt_fecha.ValueChanged += new System.EventHandler(this.dt_fecha_ValueChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(706, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "Fecha:";
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
            // uI_ShadowPanel2
            // 
            this.uI_ShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel2.Controls.Add(this.reportViewer1);
            this.uI_ShadowPanel2.Location = new System.Drawing.Point(22, 73);
            this.uI_ShadowPanel2.Name = "uI_ShadowPanel2";
            this.uI_ShadowPanel2.ParentControl = this;
            this.uI_ShadowPanel2.Radius = 10;
            this.uI_ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel2.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel2.Size = new System.Drawing.Size(723, 360);
            this.uI_ShadowPanel2.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource3.Name = "datos";
            reportDataSource3.Value = this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_TOP_5_POR_TIPO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(686, 329);
            this.reportViewer1.TabIndex = 0;
            // 
            // uI_ShadowPanel3
            // 
            this.uI_ShadowPanel3.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel3.Controls.Add(this.reportViewer2);
            this.uI_ShadowPanel3.Location = new System.Drawing.Point(775, 73);
            this.uI_ShadowPanel3.Name = "uI_ShadowPanel3";
            this.uI_ShadowPanel3.ParentControl = this;
            this.uI_ShadowPanel3.Radius = 10;
            this.uI_ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel3.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel3.Size = new System.Drawing.Size(453, 360);
            this.uI_ShadowPanel3.TabIndex = 3;
            // 
            // reportViewer2
            // 
            this.reportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "da";
            reportDataSource1.Value = this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_TOP_5_TIPOS_CIRCULAR.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(18, 18);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowToolBar = false;
            this.reportViewer2.Size = new System.Drawing.Size(416, 329);
            this.reportViewer2.TabIndex = 0;
            // 
            // uI_ShadowPanel4
            // 
            this.uI_ShadowPanel4.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel4.Controls.Add(this.reportViewer3);
            this.uI_ShadowPanel4.Location = new System.Drawing.Point(22, 450);
            this.uI_ShadowPanel4.Name = "uI_ShadowPanel4";
            this.uI_ShadowPanel4.ParentControl = this;
            this.uI_ShadowPanel4.Radius = 10;
            this.uI_ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel4.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel4.Size = new System.Drawing.Size(1206, 211);
            this.uI_ShadowPanel4.TabIndex = 3;
            // 
            // reportViewer3
            // 
            this.reportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource2.Name = "dass";
            reportDataSource2.Value = this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_TOP_5_TIPOS_AREA.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(25, 10);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ShowToolBar = false;
            this.reportViewer3.Size = new System.Drawing.Size(1162, 191);
            this.reportViewer3.TabIndex = 0;
            // 
            // SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter
            // 
            this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter.ClearBeforeFill = true;
            // 
            // frm_VER_TOP_5_POR_TIPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1253, 673);
            this.Controls.Add(this.uI_ShadowPanel3);
            this.Controls.Add(this.uI_ShadowPanel4);
            this.Controls.Add(this.uI_ShadowPanel2);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_VER_TOP_5_POR_TIPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VER_TOP_5_POR_TIPOS";
            this.Load += new System.EventHandler(this.frm_VER_TOP_5_POR_TIPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_TOP_5_POR_TIPOS)).EndInit();
            this.uI_ShadowPanel1.ResumeLayout(false);
            this.uI_ShadowPanel1.PerformLayout();
            this.uI_ShadowPanel2.ResumeLayout(false);
            this.uI_ShadowPanel3.ResumeLayout(false);
            this.uI_ShadowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private MetroFramework.Controls.MetroComboBox cmbFiltro;
        private UIDC.UI_MaterialToggle toggle;
        private MetroFramework.Controls.MetroDateTime dt_fecha;
        private MetroFramework.Controls.MetroDateTime dt_fecha_fin;
        private MetroFramework.Controls.MetroDateTime dt_fecha_inicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private UIDC.UI_ShadowPanel uI_ShadowPanel2;
        private UIDC.UI_ShadowPanel uI_ShadowPanel3;
        private UIDC.UI_ShadowPanel uI_ShadowPanel4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSBindingSource;
        private DataSet_TOP_5_POR_TIPOS DataSet_TOP_5_POR_TIPOS;
        private DataSet_TOP_5_POR_TIPOSTableAdapters.SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter SP_ANALITICS_TOP_5_POR_TIPO_MAS_VENDIDOSTableAdapter;
    }
}