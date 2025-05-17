using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnVoltarInicioClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
