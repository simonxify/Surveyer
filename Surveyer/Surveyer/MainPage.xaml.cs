using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Surveyer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void btnLogin_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked!");
            txtUserName.Text = "Login Clicked";
        }
        void btnSignup_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Sign up button Clicked", "OK");
            txtUserName.Text = "Sign up CLicked";
        }
    }
}
