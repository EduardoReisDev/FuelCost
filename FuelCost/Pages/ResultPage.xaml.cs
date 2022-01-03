using Xamarin.Forms;

namespace FuelCost.Pages
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CarConsumptionPage());
        }
    }
}
