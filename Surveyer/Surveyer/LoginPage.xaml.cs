using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Surveyer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            btnSignup.Clicked += BtnSignup_Clicked;
        }

        private void BtnSignup_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SignUp();
           // DisplayAlert("Signup Clicked", "Signup Button has Been clicked yet to be programmed", "OK");
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Login Clicked", "Login Button has Been clicked yet to be programmed", "OK");
            
        }
    }
}