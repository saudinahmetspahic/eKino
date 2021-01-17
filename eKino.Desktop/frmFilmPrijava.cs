using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmFilmPrijava : Form
    {
        private readonly ApiService _prijaveService = new ApiService("Prijava");
        private int _filmId;
        public frmFilmPrijava(int filmId)
        {
            InitializeComponent();
            _filmId = filmId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PopuniTabelu();
        }



        private void PopuniTabelu()
        {
            var prijave = _prijaveService.Get<List<Prijava>>(new PrijavaSearchRequest { FilmId = _filmId });
            var source = new List<object>();
            var i = 1;
            foreach (var p in prijave)
            {
                if (!bttnNeaktivne.Checked)
                {
                    if (!p.Rijeseno)
                        continue;
                }
                if (!bttnAktivne.Checked)
                {
                    if (p.Rijeseno)
                        continue;
                }

                source.Add(new
                {
                    Id = p.Id,
                    RedniBroj = i,
                    Opis = p.Opis,
                    VlasnikAutorskihPrava = p.VlasnikAutPrava,
                    Email = p.Email,
                    Telefon = p.Telefon,
                    Rijeseno = p.Rijeseno ? "Da" : "Ne"
                });
                i++;
            }
            dgvPrijave.DataSource = source;
            if (dgvPrijave.ColumnCount > 0) // pravi bug kad je lista prazna (nema kolona u tabeli)
                dgvPrijave.Columns[0].Visible = false;
        }

        private void bttnNeaktivne_CheckedChanged(object sender, EventArgs e)
        {
            PopuniTabelu();
        }

        private void bttnAktivne_CheckedChanged(object sender, EventArgs e)
        {
            PopuniTabelu();
        }

        private void dgvPrijave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var prijavaId = (int)dgvPrijave.SelectedRows[0].Cells[0].Value;
            var prijava = _prijaveService.Get<List<Prijava>>(new PrijavaSearchRequest { Id = prijavaId }).FirstOrDefault(); // _prijaveService.GetById<Prijava>(prijavaId);
            prijava.Rijeseno = !prijava.Rijeseno;
            _prijaveService.Update<Prijava>(prijavaId, new PrijavaInsertRequest
            {
                Rijeseno = prijava.Rijeseno
            });
            PopuniTabelu();

        }


    }
}
