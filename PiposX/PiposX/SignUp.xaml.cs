using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PiposX
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUp : ContentPage
	{
		public SignUp ()
		{
			InitializeComponent ();
            var Signin = new TapGestureRecognizer();
            Signin.Tapped += (o, e) =>
            {
                Application.Current.MainPage = new NavigationPage(new LoginPage())
                {
                    BarBackgroundColor = Color.FromHex("#000000"),
                    BarTextColor = Color.White
                };
              };
            lblsignin.GestureRecognizers.Add(Signin);
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpFinel());

        }
    }
}