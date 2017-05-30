using HomeLogin.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Button btncontrol = (Button)sender;
            //string providername = btncontrol.Text;
            string providername = "google";
            if (OAuthConfig.User == null)
            {
                Navigation.PushModalAsync(new ProviderLoginPage(providername));
                //Need to create ProviderLoginPage so follow Step 4 and Step 5  
            }
        }
    }
}