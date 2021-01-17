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
            zanrovi.Insert(0, new Zanr { Id = 0, NazivZanra = "Odaberi zanr" });
            cbxZanr.DataSource = zanrovi;
            cbxZanr.DisplayMember = "NazivZanra";
            cbxZanr.ValueMember = "Id";

            var tipovi = _tipService.Get<List<Tip>>();
            tipovi.Insert(0, new Tip { Id = 0, NazivTipa = "Odaberi tip" });
            cbxTip.DataSource = tipovi;
            cbxTip.DisplayMember = "NazivTipa";
            cbxTip.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                //SqlConnection con = new SqlConnection("Server=.;Database=170200;Trusted_Connection=True;");
                SqlConnection con = new SqlConnection("Server=.;Database=170200_test;Trusted_Connection=True;");

                var datumod = dtpDatumOd.Value.Year.ToString() + "-" + dtpDatumOd.Value.Month + "-" + dtpDatumOd.Value.Day;
                var datumdo = dtpDatumDo.Value.Year.ToString() + "-" + dtpDatumDo.Value.Month + "-" + dtpDatumDo.Value.Day;

                var cmdText = "SELECT f.Naziv, z.NazivZanra, t.NazivTipa, Count(p.Id) as BrojProjekcija, cast(Sum(p.CijenaUlaznice) * Count(p.Id) as int) as UkupnaZarada, Avg(o.DataOcijena) as OcijenaFilma " +
                "FROM Film as f left outer join Zanr as z on f.ZanrId = z.Id  left outer join Tip as t on t.Id = f.TipId " +
                "left outer join Projekcija as p on p.FilmId = f.Id left outer join Rezervacija as r on r.ProjekcijaId = p.Id " +
                "left outer join Ocijena as o on o.FilmId = f.Id " +
                "WHERE (p.DatumProjekcije between '" +
                datumod + "' and '" + datumdo +
                "') and (" + (int)cbxZanr.SelectedValue + " = z.Id) and (" + (int)cbxTip.SelectedValue + " = t.Id) " +
                "GROUP BY f.Naziv, z.NazivZanra, t.NazivTipa " +
                "ORDER BY 4 desc, 5 desc";


                //SqlCommand cmd = new SqlCommand("proc_kreirajIzvjestaj", con);
                SqlCommand cmd = new SqlCommand(cmdText, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add("@DatumOd", SqlDbType.DateTime).Value = dtpDatumOd.Value;
                //cmd.Parameters.Add("@DatumDo", SqlDbType.DateTime).Value = dtpDatumDo.Value;
                //cmd.Parameters.Add("@Zanr", SqlDbType.Int).Value = (int)cbxZanr.SelectedValue;
                //cmd.Parameters.Add("@Tip", SqlDbType.Int).Value = (int)cbxTip.SelectedValue;

                var rpt = new rptFilmovi { Filmovi_Result = new List<Rpt_Filmovi_Result>() };
                rpt.DatumOd = dtpDatumOd.Value;
                rpt.DatumDo = dtpDatumDo.Value;
                rpt.ZanrId = (int)cbxZanr.SelectedValue;
                rpt.TipId = (int)cbxTip.SelectedValue;

                // SqlCommand cmd = new SqlCommand("proc_kreirajIzvjestaj", con);
                //var str = "select top(5) f.Naziv, z.NazivZanra, t.NazivTipa, Count(p.Id) as BrojProjekcija, cast(Sum(p.CijenaUlaznice) * Count(p.Id) as int) as UkupnaZarada, Avg(o.DataOcijena) as OcijenaFilma " +
                //    "from Film as f left outer join Zanr as z on f.ZanrId = z.Id  left outer join Tip as t on t.Id = f.TipId " +
                //    "left outer join Projekcija as p on p.FilmId = f.Id left outer join Rezervacija as r on r.ProjekcijaId = p.Id " +
                //    "left outer join Ocijena as o on o.FilmId = f.Id " +
                //    "where p.DatumProjekcije between '" + rpt.DatumOd.ToString("yyyy-MM-dd") + "' and  '" + rpt.DatumDo.ToString("yyyy-MM-dd") + "' and " + rpt.ZanrId + " = z.Id and " + rpt.TipId + " = t.Id " +
                //    "group by f.Naziv, z.NazivZanra, t.NazivTipa " +
                //    "order by 4 desc, 5 desc";
                //cmd.CommandText = str;
                cmd.CommandTimeout = 25;
                cmd.Connection = con;
                //cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();



                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    adp.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        var c = dt.Rows.Count > 5 ? 5 : dt.Rows.Count;
                        for (int i = 0; i < c; i++)
                        {
                            var row = dt.Rows[i];
                            var x = new Rpt_Filmovi_Result();
                            x.Naziv = (string)row[0];
                            x.NazivZanra = (string)row[1];
                            x.NazivTipa = (string)row[2];
                            x.BrojProjekcija = (int)row[3];
                            x.UkupnaZarada = (int)row[4];
                            x.OcijenaFilma = (int)row[5];
                            rpt.Filmovi_Result.Add(x);
                        }

                        rpt.MdiParent = this.MdiParent;
                        rpt.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void cbxTip_Validating(object sender, CancelEventArgs e)
        {
            if(cbxTip.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxTip, Messages.CBX_Vrsta);
            }
        }

        private void cbxZanr_Validating(object sender, CancelEventArgs e)
        {
            if (cbxZanr.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxZanr, Messages.CBX_Zanr);
            }
        }
    }
}
