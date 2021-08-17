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

       public async void Button_Clicked(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                await DisplayAlert("Advertencia", "Los campos son obligatorios.", "Ok");
                

            }
            else
            {
                await DisplayAlert("Bienvenido", "Hola " + txtUsuario.Text, "Ok");
            }
        }
    }
}