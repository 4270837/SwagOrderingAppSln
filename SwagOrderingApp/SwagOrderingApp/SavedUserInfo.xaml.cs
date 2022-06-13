using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SwagOrderingApp.Data;

namespace SwagOrderingApp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavedUserInfo : ContentPage
    {
        public SavedUserInfo()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            SwagTDatabase database = await SwagTDatabase.Instance;
            listView.ItemsSource = await database.GetTsAsync();
        }

        
       private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
       {
            if (listView.SelectedItem != null)
            {
                await Navigation.PushAsync(new MainPage{BindingContext = listView.SelectedItem as SwagT});
            }
       }
    }
}