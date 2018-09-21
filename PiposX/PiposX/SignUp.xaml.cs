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
            LanguageEng();
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            if (toolswitch.Icon == "switchImgF.png")
            {
                toolswitch.Icon = "switchImgE.png";

                LanguageEng();
            }
            else
            {
                toolswitch.Icon = "switchImgF.png";
                LanguageFr();
            }

        }
        private void LanguageEng()
        {
            lblsignup.Text = AppGlobalResources.Resource.home_signup;
            txtEmail.Placeholder = AppGlobalResources.Resource.home_email;
            txtpassword.Placeholder = AppGlobalResources.Resource.home_password;
            txtRepassword.Placeholder = AppGlobalResources.Resource.popup_retype_new_password;
            lblterms.Text = AppGlobalResources.Resource.home_agree_signup;
            btnsubmit.Text = AppGlobalResources.Resource.home_signup;
            lblsignin.Text = AppGlobalResources.Resource.home_click_to_signin;
        }
        private void LanguageFr()
        {
            lblsignup.Text = AppGlobalResources.Resourcefr.home_signup;
            txtEmail.Placeholder = AppGlobalResources.Resourcefr.home_email;
            txtpassword.Placeholder = AppGlobalResources.Resourcefr.home_password;
            txtRepassword.Placeholder = AppGlobalResources.Resourcefr.popup_retype_new_password;
            lblterms.Text = AppGlobalResources.Resourcefr.home_agree_signup;
            btnsubmit.Text = AppGlobalResources.Resourcefr.home_signup;
            lblsignin.Text = AppGlobalResources.Resourcefr.home_click_to_signin;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpFinel());

        }
    }
}