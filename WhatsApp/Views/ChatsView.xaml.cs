using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatsView : ContentPage
    {
        public ChatsView()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Chat Button", "Select contact and ...", "OK");
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Item", "Item tapped", "OK");
        }
    }
}