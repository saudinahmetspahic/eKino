using eKino.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace eKino.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaketAktuelnoPage : ContentPage
    {
        private PaketiAktuelnoViewModel model;
        public PaketAktuelnoPage()
        {
            InitializeComponent();
            BindingContext = model = new PaketiAktuelnoViewModel();

            AddElements();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private void AddElements()
        {
            model.Init();
            paketiStack.Margin = new Thickness(5);

            int i = 1;
            foreach (var paket in model.PaketiLista)
            {
                var grid = new Grid();
                grid.Margin = new Thickness(0, 3, 0, 3);
                grid.Padding = new Thickness(3);
                grid.BackgroundColor = Color.LightGray;
                grid.RowDefinitions = new RowDefinitionCollection { new RowDefinition { Height = 50 }, new RowDefinition { Height = 50 } };

                var labelOpis = new Label { Text = paket.Opis };
                var insideGrid = new Grid();
                insideGrid.ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition { Width = 50 }, new ColumnDefinition {  Width = new GridLength(1, GridUnitType.Auto) } };

                var labelredniBroj = new Label { Text = i.ToString() + "#", FontSize = 30, FontAttributes = FontAttributes.Bold, VerticalOptions = LayoutOptions.CenterAndExpand, VerticalTextAlignment = TextAlignment.Center }; i++;
                var labelZvjezdice = new Label { Text = GetMaxOcijenaText(paket.MaxOcijena), HorizontalTextAlignment = TextAlignment.End, VerticalOptions = LayoutOptions.CenterAndExpand, VerticalTextAlignment = TextAlignment.Center };
                insideGrid.Children.Add(labelredniBroj, 0, 0);
                insideGrid.Children.Add(labelZvjezdice, 1, 0);


                grid.Children.Add(labelOpis, 0, 0);
                grid.Children.Add(insideGrid, 0, 1);

                var tapG = new TapGestureRecognizer();
                tapG.Tapped += (sender, e) =>
                {
                    Navigation.PushAsync(new PaketDetaljiPage(paket.Id));
                };
                grid.GestureRecognizers.Add(tapG);

                paketiStack.Children.Add(grid);
            }
            
        }


        private string GetMaxOcijenaText(int maxocijena)
        {
            string rez = "Gledaj filmove sa ";
            for (int i = 0; i < maxocijena; i++)
            {
                if (i + 1 == maxocijena)
                {
                    if (i + 1 != 1)
                        rez += " i ";
                    rez += (i + 1).ToString() + " ★";
                }
                else
                {
                    if (i != 0)
                        rez += ", ";
                    rez += (i + 1).ToString();
                }
            }
            return rez;
        }

    }
}