namespace WindowsFormsApplication3
{
    partial class frmOPCION_RECETAS
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
            this.uI_ShadowPanel1 = new UIDC.UI_ShadowPanel();
            this.dt_Recetas = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_RECETA_NUEVA = new WindowsFormsApplication3.DataSet_RECETA_NUEVA();
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_RECETA_NUEVATableAdapters.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter();
            this.SP_VER_DETALLE_RECETA_MEDICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DETALLE_RECETA_MEDICATableAdapter = new WindowsFormsApplication3.DataSet_RECETA_NUEVATableAdapters.SP_VER_DETALLE_RECETA_MEDICATableAdapter();
            this.SP_VER_RECETA_MEDICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_RECETA_MEDICATableAdapter = new WindowsFormsApplication3.DataSet_RECETA_NUEVATableAdapters.SP_VER_RECETA_MEDICATableAdapter();
            this.uI_ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Recetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_RECETA_NUEVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DETALLE_RECETA_MEDICABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_RECETA_MEDICABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_ShadowPanel1
            // 
            this.uI_ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.uI_ShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.uI_ShadowPanel1.Controls.Add(this.dt_Recetas);
            this.uI_ShadowPanel1.Location = new System.Drawing.Point(12, 12);
            this.uI_ShadowPanel1.Name = "uI_ShadowPanel1";
            this.uI_ShadowPanel1.ParentControl = this;
            this.uI_ShadowPanel1.Radius = 10;
            this.uI_ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.uI_ShadowPanel1.ShadowStyle = UIDC.UI_ShadowPanel.ShadowMode.Centrada;
            this.uI_ShadowPanel1.Size = new System.Drawing.Size(308, 674);
            this.uI_ShadowPanel1.TabIndex = 5;
            // 
            // dt_Recetas
            // 
            this.dt_Recetas.AllowUserToAddRows = false;
            this.dt_Recetas.AllowUserToDeleteRows = false;
            this.dt_Recetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_Recetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dt_Recetas.BackgroundColor = System.Drawing.Color.White;
            this.dt_Recetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt_Recetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dt_Recetas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dt_Recetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(209)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Recetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_Recetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_Recetas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_Recetas.EnableHeadersVisualStyles = false;
            this.dt_Recetas.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dt_Recetas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Recetas.Location = new System.Drawing.Point(15, 12);
            this.dt_Recetas.MultiSelect = false;
            this.dt_Recetas.Name = "dt_Recetas";
            this.dt_Recetas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Recetas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_Recetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_Recetas.Size = new System.Drawing.Size(274, 636);
            this.dt_Recetas.TabIndex = 4;
            this.dt_Recetas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Recetas_CellDoubleClick);
            // 
            // reportViewer1
            // 
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
            this.reportViewer1.Location = new System.Drawing.Point(326, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(883, 674);
            this.reportViewer1.TabIndex = 6;
            // 
            // DataSet_RECETA_NUEVA
            // 
            this.DataSet_RECETA_NUEVA.DataSetName = "DataSet_RECETA_NUEVA";
            this.DataSet_RECETA_NUEVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01BindingSource
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataMember = "SP_VER_DATOS_VETERINARIA_DATASET01";
            this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource.DataSource = this.DataSet_RECETA_NUEVA;
            // 
            // SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter
            // 
            this.SP_VER_DATOS_VETERINARIA_DATASET01TableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_DETALLE_RECETA_MEDICABindingSource
            // 
            this.SP_VER_DETALLE_RECETA_MEDICABindingSource.DataMember = "SP_VER_DETALLE_RECETA_MEDICA";
            this.SP_VER_DETALLE_RECETA_MEDICABindingSource.DataSource = this.DataSet_RECETA_NUEVA;
            // 
            // SP_VER_DETALLE_RECETA_MEDICATableAdapter
            // 
            this.SP_VER_DETALLE_RECETA_MEDICATableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_RECETA_MEDICABindingSource
            // 
            this.SP_VER_RECETA_MEDICABindingSource.DataMember = "SP_VER_RECETA_MEDICA";
            this.SP_VER_RECETA_MEDICABindingSource.DataSource = this.DataSet_RECETA_NUEVA;
            // 
            // SP_VER_RECETA_MEDICATableAdapter
            // 
            this.SP_VER_RECETA_MEDICATableAdapter.ClearBeforeFill = true;
            // 
            // frmOPCION_RECETAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 729);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.uI_ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOPCION_RECETAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOPCION_RECETAS";
            this.Load += new System.EventHandler(this.frmOPCION_RECETAS_Load);
            this.uI_ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_Recetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_RECETA_NUEVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_VETERINARIA_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DETALLE_RECETA_MEDICABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_RECETA_MEDICABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_ShadowPanel uI_ShadowPanel1;
        private System.Windows.Forms.DataGridView dt_Recetas;
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