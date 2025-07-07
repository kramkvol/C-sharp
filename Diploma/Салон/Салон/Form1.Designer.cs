
namespace Салон
{
    partial class Form1
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
            this.Отчет_по_оказанным_услугамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Салон_красотыDataSet = new Салон.Салон_красотыDataSet();
            this.Запись_представлениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Запись_представлениеTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Запись_представлениеTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Отчет_по_оказанным_услугамTableAdapter = new Салон.Салон_красотыDataSetTableAdapters.Отчет_по_оказанным_услугамTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_по_оказанным_услугамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Салон_красотыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Запись_представлениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Отчет_по_оказанным_услугамBindingSource
            // 
            this.Отчет_по_оказанным_услугамBindingSource.DataMember = "Отчет по оказанным услугам";
            this.Отчет_по_оказанным_услугамBindingSource.DataSource = this.Салон_красотыDataSet;
            // 
            // Салон_красотыDataSet
            // 
            this.Салон_красотыDataSet.DataSetName = "Салон_красотыDataSet";
            this.Салон_красотыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Запись_представлениеBindingSource
            // 
            this.Запись_представлениеBindingSource.DataMember = "Запись_представление";
            this.Запись_представлениеBindingSource.DataSource = this.Салон_красотыDataSet;
            // 
            // Запись_представлениеTableAdapter
            // 
            this.Запись_представлениеTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Отчет_по_оказанным_услугамBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Салон.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(978, 638);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчет_по_оказанным_услугамTableAdapter
            // 
            this.Отчет_по_оказанным_услугамTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 689);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_по_оказанным_услугамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Салон_красотыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Запись_представлениеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Запись_представлениеBindingSource;
        private Салон_красотыDataSet Салон_красотыDataSet;
        private Салон_красотыDataSetTableAdapters.Запись_представлениеTableAdapter Запись_представлениеTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_по_оказанным_услугамBindingSource;
        private Салон_красотыDataSetTableAdapters.Отчет_по_оказанным_услугамTableAdapter Отчет_по_оказанным_услугамTableAdapter;
    }
}