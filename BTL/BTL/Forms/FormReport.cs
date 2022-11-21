using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class FormReport : Form
    {
        DataTable table;
        int index;
        public FormReport(int index, DataTable dataTable)
        {
            this.table = dataTable;
            this.index = index;
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (index == 1)
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "BTL.Reports.Report1.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataSet1";
                    reportDataSource.Value = table;
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.RefreshReport();
                }
                if (index == 2)
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "BTL.Reports.Report2.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataSet1";
                    reportDataSource.Value = table;
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
