using eKino.Mobile.Models;
using eKino.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class PaketKupiVM : BaseViewModel
    {
        private readonly ApiService _paketService = new ApiService("Paket");
        private int _paketId;
        private double _cijena;
        ICommand InitCommand;
        public PaketKupiVM(int PaketId, double Cijena)
        {
            InitCommand = new Command(() => { Init(); });
            _paketId = PaketId;
            _cijena = Cijena;
        }

        public void Init()
        {
            _vrsteKartica.Add(new Item { Id = "pm_card_visa", Text = "Visa" });
            _vrsteKartica.Add(new Item { Id = "pm_card_mastercard", Text = "Mastercard" });
            Paket = _paketService.GetById<Paket>(_paketId);
        }

        private ObservableCollection<Item> _vrsteKartica = new ObservableCollection<Item>();
        public ObservableCollection<Item> VrsteKartica
        {
            get { return _vrsteKartica; }
            set { SetProperty(ref _vrsteKartica, value); }
        }
        private Paket _paket;
        public Paket Paket { 
            get { return _paket; } 
            set { SetProperty(ref _paket, value); } 
        }
        public double Cijena
        {
            get { return _cijena; }
            set { SetProperty(ref _cijena, value); }
        }
    }
}
