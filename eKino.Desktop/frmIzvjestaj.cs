using eKino.Desktop.Izvjestaji;
using eKino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eKino.Desktop
{
    public partial class frmIzvjestaj : Form
    {
        private readonly ApiService _zanrService = new ApiService("Zanr");
        private readonly ApiService _tipService = new ApiService("Tip");
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            dtpDatumDo.Value = DateTime.Now;
            dtpDatumOd.Value = DateTime.Now;

            var zanrovi = _zanrService.Get<List<Zanr>>();
            zanrovi.Insert(0, new Zanr { Id = 0, NazivZanra = "Odaberi zanr (opcionalno)" });
            cbxZanr.DataSource = zanrovi;
            cbxZanr.DisplayMember = "NazivZanra";
            cbxZanr.ValueMember = "Id";

            var tipovi = _tipService.Get<List<Tip>>();
            tipovi.Insert(0, new Tip { Id = 0, NazivTipa = "Odaberi tip (opcionalno)" });
            cbxTip.DataSource = tipovi;
            cbxTip.DisplayMember = "NazivTipa";
            cbxTip.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rpt = new rptFilmovi();
            rpt.DatumOd = dtpDatumOd.Value;
            rpt.DatumDo = dtpDatumDo.Value;
            rpt.ZanrId = (int)cbxZanr.SelectedValue;
            rpt.TipId = (int)cbxTip.SelectedValue;
            // select top(5) f.Naziv, z.NazivZanra, t.NazivTipa, Count(p.Id) as BrojProjekcija, Sum(p.CijenaUlaznice) * Count(p.Id) as UkupnaZarada, Avg(o.DataOcijena) as OcijenaFilma
            // from Film as f left outer join Zanr as z on f.ZanrId = z.Id  left outer join Tip as t on t.Id = f.TipId
            // left outer join Projekcija as p on p.FilmId = f.Id left outer join Rezervacija as r on r.ProjekcijaId = p.Id
            // left outer join Ocijena as o on o.FilmId = f.Id
            // where p.DatumProjekcije between @DatumOd and @DatumDo and(@Zanr = z.Id or @Zanr is null) and(@Tip = t.Id or @Tip is null)
            // group by f.Naziv, z.NazivZanra, t.NazivTipa
            // order by 4 desc, 5 desc
            //var connection = new SqlConnection(eKino.Configuration);

            StringBuilder sb = new StringBuilder();
            sb.Append("exec prPopularnostIZaradaFilmova @DatumOd = " + dtpDatumOd.Value.ToString() + ", @DatumDo = " + dtpDatumDo.Value.ToString() + ", @Zanr = " + ((int)cbxZanr.SelectedValue).ToString() + ", @Tip = " + ((int)cbxTip.SelectedValue).ToString());
            //sb.Append("select top(5) f.Naziv, z.NazivZanra, t.NazivTipa, Count(p.Id) as BrojProjekcija, Sum(p.CijenaUlaznice) * Count(p.Id) as UkupnaZarada, Avg(o.DataOcijena) as OcijenaFilma");
            //sb.Append("from Film as f left outer join Zanr as z on f.ZanrId = z.Id  left outer join Tip as t on t.Id = f.TipId");
            //sb.Append("left outer join Projekcija as p on p.FilmId = f.Id left outer join Rezervacija as r on r.ProjekcijaId = p.Id");
            //sb.Append("left outer join Ocijena as o on o.FilmId = f.Id");
            //sb.Append("where p.DatumProjekcije between @DatumOd and @DatumDo and(@Zanr = z.Id or @Zanr is null) and(@Tip = t.Id or @Tip is null)");
            //sb.Append("group by f.Naziv, z.NazivZanra, t.NazivTipa");
            //sb.Append("order by 4 desc, 5 desc");
            var con = new SqlConnection("Server=.;Database=170200;Trusted_Connection=True;");
            con.Open();
            SqlCommand sc = new SqlCommand(sb.ToString(), con);
            var r = sc.ExecuteReader();
            con.Close();
            

            //rpt.Filmovi_Result = r.Cast<List<Rpt_Filmovi_Result>>();
            //rpt.MdiParent = this.MdiParent;
            //rpt.Show();
            this.Close();
        }
    }
}
