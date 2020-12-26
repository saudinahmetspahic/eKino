using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using System.Windows.Forms;
using System.Windows.Threading;

namespace eKino.Desktop
{
    public partial class frmPaketDetalji : Form
    {
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _korisnikPaketService = new ApiService("KorisnikPaket");
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        private Paket _paket = null;

        public frmPaketDetalji(int paketId)
        {
            _paket = _paketService.GetById<Paket>(paketId);
            InitializeComponent();
        }
            
        private void frmPaketDetalji_Load(object sender, EventArgs e)
        {
            if (_paket != null)
            {
                if(_ulogaService.GetByName<Uloga>("Admin").Id != _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault().UlogaId)
                {
                    nudCijena.ReadOnly = true;
                    nudOcijena.ReadOnly = true;
                    dtpDatumIsteka.Enabled = false;
                }
                lblDatumKreiranja.Text = _paket.DatumKreiranja.ToString("dd/MM/yyyy");
                lblOpis.Text = _paket.Opis;
                dtpDatumIsteka.Value = _paket.DatumIsteka ?? DateTime.Now;
                nudCijena.Value = (decimal)_paket.Cijena;
                nudOcijena.Value = _paket.MaxOcijena;
            }
        }

        private void bttnIzbrisiPaket_Click(object sender, EventArgs e)
        {
            var pk = _korisnikPaketService.Get<List<Paket>>(new KorisnikPaketSearchRequest { PaketId = _paket.Id }).ToList();
            foreach (var p in pk)
            {
                _korisnikPaketService.Remove(p.Id);
            }

            Task.Delay(1000);

            _paketService.Remove(_paket.Id);

            var frm = new frmPocetna();
            frm.Show();
            this.MdiParent.Close();
        }

        private void bttnIzmijeni_Click(object sender, EventArgs e)
        {
            var model = new PaketInsertRequest
            {
                Cijena = (double)nudCijena.Value,
                MaxOcijena = (int)nudOcijena.Value,
                DatumIsteka = dtpDatumIsteka.Value,
                Opis = _paket.Opis,
                DatumKreiranja = _paket.DatumKreiranja
            };
            _paketService.Update<PaketInsertRequest>(_paket.Id, model);
        }

    }
}
