using eKino.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop.Izvjestaji
{
    public partial class rptFilmovi : Form
    {
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int TipId { get; set; }
        public int ZanrId { get; set; }
        public List<Rpt_Filmovi_Result> Filmovi_Result { get; set; }

        public rptFilmovi()
        {
            InitializeComponent();
        }

        private void rptFilmovi_Load(object sender, EventArgs e)
        {
            var rds = new ReportDataSource("DataSet1", Filmovi_Result);

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TipId", TipId.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ZanrId", ZanrId.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", DatumOd.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", DatumDo.ToString()));
            this.reportViewer1.RefreshReport();
        }
    }
}
