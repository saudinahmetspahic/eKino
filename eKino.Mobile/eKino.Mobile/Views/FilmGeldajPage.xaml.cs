using eKino.Mobile.Models;
using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmGeldajPage : ContentPage
    {
        public LibVLC _libvlc { get; set; }
        public FilmGeldajPage(string link)
        {
            InitializeComponent();

            BindingContext = this;

            Core.Initialize();
            _libvlc = new LibVLC();

            //var link = "https://ia601403.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4";
            var media = new Media(_libvlc, link, FromType.FromLocation);
            myvideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myvideo.MediaPlayer.Play();
        }

        protected override bool OnBackButtonPressed()
        {
            myvideo.MediaPlayer.Stop();
            return base.OnBackButtonPressed();
        }
    }
}