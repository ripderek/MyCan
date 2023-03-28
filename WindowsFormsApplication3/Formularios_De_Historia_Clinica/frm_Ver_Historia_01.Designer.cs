namespace WindowsFormsApplication3
{
    partial class frm_Ver_Historia_01
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
            this.SP_VER_DATOS_HISOTRIA_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter = new WindowsFormsApplication3.DataSet_Historial_ClinicoTableAdapters.SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter();
            this.DataSet_Historia_Clinica_Nuevo_Mejorada = new WindowsFormsApplication3.DataSet_Historia_Clinica_Nuevo_Mejorada();
            this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_HISOTRIA_DATASET01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Historia_Clinica_Nuevo_Mejorada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter
            // 
            this.SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter.ClearBeforeFill = true;
            // 
            // DataSet_Historia_Clinica_Nuevo_Mejorada
            // 
            this.DataSet_Historia_Clinica_Nuevo_Mejorada.DataSetName = "DataSet_Historia_Clinica_Nuevo_Mejorada";
            this.DataSet_Historia_Clinica_Nuevo_Mejorada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VER_DATOS_PACIENTE_DATASET01BindingSource
            // 
            this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource.DataMember = "SP_VER_DATOS_PACIENTE_DATASET01";
            this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource.DataSource = this.DataSet_Historia_Clinica_Nuevo_Mejorada;
            // 
            // frm_Ver_Historia_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 449);
            this.Name = "frm_Ver_Historia_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Clinico";
            this.Load += new System.EventHandler(this.frm_Ver_Historia_01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_HISOTRIA_DATASET01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Historia_Clinica_Nuevo_Mejorada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_PACIENTE_DATASET01BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SP_VER_DATOS_HISOTRIA_DATASET01BindingSource;
        private DataSet_Historial_ClinicoTableAdapters.SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter SP_VER_DATOS_HISOTRIA_DATASET01TableAdapter;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_PACIENTE_DATASET01BindingSource;
        private DataSet_Historia_Clinica_Nuevo_Mejorada DataSet_Historia_Clinica_Nuevo_Mejorada;
    }
}