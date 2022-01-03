using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FuelCost.Pages
{
    public partial class CarConsumptionPage : ContentPage
    {
        public CarConsumptionPage()
        {
            InitializeComponent();

            fancyEntry.Focused += FancyEntry_Focused;
            fancyEntry.Unfocused += FancyEntry_Unfocused;
        }

        private void FancyEntry_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrEmpty(fancyEntry.Text))
            {
                fancyEntryLabel.ScaleXTo(1);
                fancyEntryLabel.ScaleYTo(1);
                fancyEntryLabel.TranslateTo(0, 0);
            }
        }

        private void FancyEntry_Focused(object sender, FocusEventArgs e)
        {
            fancyEntryLabel.ScaleYTo(0.8);
            fancyEntryLabel.ScaleXTo(0.8);
            fancyEntryLabel.TranslateTo(0, -(fancyEntryLabel.Height));
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TravelledDistancePage());
        }
    }
}
