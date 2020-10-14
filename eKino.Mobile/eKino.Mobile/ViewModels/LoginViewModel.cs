using eKino.Mobile.Models;
using eKino.Model;
using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eKino.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            InitCommand = new Command(() => Init());
        }

        private readonly ApiService _gradoviService = new ApiService("Grad");

        public ObservableCollection<Grad> GradoviLista { get; set; } = new ObservableCollection<Grad>();

        Model.Grad _odabraniGrad = null;

        public Model.Grad OdabraniGrad
        {
            get { return _odabraniGrad; }
            set
            {
                SetProperty(ref _odabraniGrad, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
            

        private ICommand InitCommand = null;
        public void Init()
        {
            var gradovi = _gradoviService.Get<List<Grad>>();
            foreach (var grad in gradovi)
            {
                GradoviLista.Add(grad);
            }
        }


    }
}
