using eKino.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class PaketDetaljiViewModel : BaseViewModel
    {
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly int _paketId;
        public int PaketId
        {
            get { return _paketId; }
        }
        public PaketDetaljiViewModel(int paketId)
        {
            _paketId = paketId;
            InitCommand = new Command(() => { Init(); });
        }

        ICommand InitCommand;

        public void Init()
        {
            var paket = _paketService.GetById<Paket>(_paketId);
            if(paket != null)
            {
                DatumKreiranja = paket.DatumKreiranja.ToString("dd/MM/yyyy");
                DatumIsteka = paket.DatumIsteka ?? DateTime.Now;
                Opis = paket.Opis;
                MaxOcijena = paket.MaxOcijena;
                Cijena = paket.Cijena ?? 0;
            }
        }







        private string _datumKreiranja;
        public string DatumKreiranja
        {
            get { return _datumKreiranja; }
            set { SetProperty(ref _datumKreiranja, value); }
        }
        private DateTime _datumIsteka;
        public DateTime DatumIsteka
        {
            get { return _datumIsteka; }
            set { SetProperty(ref _datumIsteka, value); }
        }
        private int _maxOcijena;
        public int MaxOcijena
        {
            get { return _maxOcijena; }
            set { SetProperty(ref _maxOcijena, value); }
        }
        private double _cijnenaPaketa;
        public double Cijena
        {
            get { return _cijnenaPaketa; }
            set { SetProperty(ref _cijnenaPaketa, value); }
        }
        private string _opis;

        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }
    }
}
