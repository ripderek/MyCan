﻿namespace WindowsFormsApplication3
{
    partial class frm_Ver_Registrar_Historial_Clinico
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
            this.uI_Elipse1 = new UIDC.UI_Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Registrar_Historial_Clinico = new WindowsFormsApplication3.DataSet_Registrar_Historial_Clinico();
            this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_HISTORIA_CLINICA_RECIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_Registrar_Historial_ClinicoTableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter();
            this.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_Registrar_Historial_ClinicoTableAdapters.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter();
            this.SP_HISTORIA_CLINICA_RECIENTableAdapter = new WindowsFormsApplication3.DataSet_Registrar_Historial_ClinicoTableAdapters.SP_HISTORIA_CLINICA_RECIENTableAdapter();
            this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter = new WindowsFormsApplication3.DataSet_Registrar_Historial_ClinicoTableAdapters.SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Registrar_Historial_Clinico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HISTORIA_CLINICA_RECIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource)).BeginInit();
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
            this.uI_TitleBanner1.TabIndex = 5;
            this.uI_TitleBanner1.Text = "HISTORIAL CLINICO";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // uI_Elipse1
            // 
            this.uI_Elipse1.AddControl = this;
            this.uI_Elipse1.ElipseRadius = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 374);
            this.panel1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Veterinaria";
            reportDataSource1.Value = this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
            reportDataSource2.Name = "Paciente";
            reportDataSource2.Value = this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource;
            reportDataSource3.Name = "Historial";
            reportDataSource3.Value = this.SP_HISTORIA_CLINICA_RECIENBindingSource;
            reportDataSource4.Name = "Medicamentos";
            reportDataSource4.Value = this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.Report_Registrar_Historial_Clinico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(839, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01BindingSource
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataMember = "SP_VER_DATOS_VETERINARIA_DATASET01";
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataSource = this.DataSet_Registrar_Historial_Clinico;
            // 
            // DataSet_Registrar_Historial_Clinico
            // 
            this.DataSet_Registrar_Historial_Clinico.DataSetName = "DataSet_Registrar_Historial_Clinico";
            this.DataSet_Registrar_Historial_Clinico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VER_DATOS_PACIENTE_DATASET01BindingSource
            // 
            this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource.DataMember = "SP_VER_DATOS_PACIENTE_DATASET01";
            this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource.DataSource = this.DataSet_Registrar_Historial_Clinico;
            // 
            // SP_HISTORIA_CLINICA_RECIENBindingSource
            // 
            this.SP_HISTORIA_CLINICA_RECIENBindingSource.DataMember = "SP_HISTORIA_CLINICA_RECIEN";
            this.SP_HISTORIA_CLINICA_RECIENBindingSource.DataSource = this.DataSet_Registrar_Historial_Clinico;
            // 
            // SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource
            // 
            this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource.DataMember = "SP_MEDICAMENTO_USADO_ULTIMO_DETALLE";
            this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource.DataSource = this.DataSet_Registrar_Historial_Clinico;
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_DATOS_PACIENTE_DATASET01TableAdapter
            // 
            this.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter.ClearBeforeFill = true;
            // 
            // SP_HISTORIA_CLINICA_RECIENTableAdapter
            // 
            this.SP_HISTORIA_CLINICA_RECIENTableAdapter.ClearBeforeFill = true;
            // 
            // SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter
            // 
            this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // frm_Ver_Registrar_Historial_Clinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Ver_Registrar_Historial_Clinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIAL CLINICO";
            this.Load += new System.EventHandler(this.frm_Ver_Registrar_Historial_Clinico_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Registrar_Historial_Clinico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HISTORIA_CLINICA_RECIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private UIDC.UI_Elipse uI_Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_VETERINARIA_DATASET01BindingSource;
        private DataSet_Registrar_Historial_Clinico DataSet_Registrar_Historial_Clinico;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_PACIENTE_DATASET01BindingSource;
        private System.Windows.Forms.BindingSource SP_HISTORIA_CLINICA_RECIENBindingSource;
        private System.Windows.Forms.BindingSource SP_MEDICAMENTO_USADO_ULTIMO_DETALLEBindingSource;
        private DataSet_Registrar_Historial_ClinicoTableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter;
        private DataSet_Registrar_Historial_ClinicoTableAdapters.SP_VER_DATOS_PACIENTE_DATASET01TableAdapter SP_VER_DATOS_PACIENTE_DATASET01TableAdapter;
        private DataSet_Registrar_Historial_ClinicoTableAdapters.SP_HISTORIA_CLINICA_RECIENTableAdapter SP_HISTORIA_CLINICA_RECIENTableAdapter;
        private DataSet_Registrar_Historial_ClinicoTableAdapters.SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter SP_MEDICAMENTO_USADO_ULTIMO_DETALLETableAdapter;
    }
}