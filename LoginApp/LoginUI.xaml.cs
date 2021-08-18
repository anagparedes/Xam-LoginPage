using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

       public async void OnButtonClicked(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(userText.Text) || string.IsNullOrEmpty(passwordText.Text))
            {
                await DisplayAlert("Warning!", "The fields are required.", "Ok");
                

            }
            else
            {
                await DisplayAlert("Welcome!", "Hi " + userText.Text, "Ok");
            }
        }
    }
}