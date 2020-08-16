using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eKino.Mobile.Models;
using LibVLCSharp.Shared;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.CompilerServices;

namespace eKino.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }
        public LibVLC _libvlc { get; set; }
        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;

            Core.Initialize();
            _libvlc = new LibVLC();
            
            var link = "https://ia601403.us.archive.org/5/items/cc-1916-10-02-the-pawnshop-512kb/CC_1916_10_02_ThePawnshop_512kb.mp4";
            var media = new Media(_libvlc, link, FromType.FromLocation);
            myvideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myvideo.MediaPlayer.Play();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}