using System;
using SwagOrderingApp.Data;
using Xamarin.Forms;

namespace SwagOrderingApp
{
    public partial class MainPage : ContentPage
    {        
        public MainPage()
        {
            InitializeComponent();
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var swagT = (SwagT)BindingContext;
            SwagTDatabase database = await SwagTDatabase.Instance;
            await database.SaveTAsync(swagT);
            await Navigation.PopAsync();
            //Navigation.PushAsync(new SavedUserInfo());
        }

    }
}
