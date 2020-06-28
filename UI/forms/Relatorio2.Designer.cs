namespace PadraoDeProjetoEmCamadas.forms
{
    partial class Relatorio2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sql10351329DataSet = new PadraoDeProjetoEmCamadas.sql10351329DataSet();
            this.eleicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleicaoTableAdapter = new PadraoDeProjetoEmCamadas.sql10351329DataSetTableAdapters.EleicaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sql10351329DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eleicaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.forms.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sql10351329DataSet
            // 
            this.sql10351329DataSet.DataSetName = "sql10351329DataSet";
            this.sql10351329DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eleicaoBindingSource
            // 
            this.eleicaoBindingSource.DataMember = "Eleicao";
            this.eleicaoBindingSource.DataSource = this.sql10351329DataSet;
            // 
            // eleicaoTableAdapter
            // 
            this.eleicaoTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Relatorio2";
            this.Text = "Relatorio2";
            this.Load += new System.EventHandler(this.Relatorio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sql10351329DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sql10351329DataSet sql10351329DataSet;
        private System.Windows.Forms.BindingSource eleicaoBindingSource;
        private sql10351329DataSetTableAdapters.EleicaoTableAdapter eleicaoTableAdapter;
    }
}