using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BaiTapWinForm
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void FormReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "BaiTapWinForm.Report1.rdlc";
            ReportDataSource rp = new ReportDataSource();
            rp.Name = "DataSet1";
            rp.Value = modify.DT("Select * from NHANVIEN");
            reportViewer1.LocalReport.DataSources.Add(rp);
            this.reportViewer1.RefreshReport();
        }
    }
}
