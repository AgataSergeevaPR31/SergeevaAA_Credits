using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SergeevaAA_Credits
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void DDDD(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Login.Text) ||
                string.IsNullOrWhiteSpace(Password.Text) ||
                !checkBox.IsChecked)
            {
                await DisplayAlert("Ошибка", "Пожалуйста, заполните все поля и выберите 'Запомнить меня'.", "OK");
            }
            else
            {
                await Navigation.PushModalAsync(new Page2());
            }
        }
    }

    
    

}
