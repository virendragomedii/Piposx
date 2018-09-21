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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            var Signup = new TapGestureRecognizer();
            Signup.Tapped += (o, e) =>
            {
                Navigation.PushAsync(new SignUp());

            };
            lblcreateac.GestureRecognizers.Add(Signup);
            var ForgetPassword = new TapGestureRecognizer();
            ForgetPassword.Tapped += (o, e) =>
            {
                Navigation.PushAsync(new ForgetPassword());
            };
            lblforgot.GestureRecognizers.Add(ForgetPassword);
            LanguageEng();
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var d4 = txtEmail.Text;
            var d = "";

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
            btnfacebookLogin.Text = AppGlobalResources.Resource.home_login_facebook;
            lbljoin.Text = AppGlobalResources.Resource.home_signin_text;
            txtEmail.Placeholder = AppGlobalResources.Resource.home_email;
            txtpassword.Placeholder = AppGlobalResources.Resource.home_password;
            btnsubmit.Text = AppGlobalResources.Resource.home_signin;
            lblforgot.Text = AppGlobalResources.Resource.home_forgot_password;
            lblcreateac.Text = AppGlobalResources.Resource.home_dont_have_account;
        }
        private void LanguageFr()
        {
            lbljoin.Text = AppGlobalResources.Resourcefr.home_signin_text;
            btnfacebookLogin.Text = AppGlobalResources.Resourcefr.home_login_facebook;
            txtEmail.Placeholder = AppGlobalResources.Resourcefr.home_email;
            txtpassword.Placeholder = AppGlobalResources.Resourcefr.home_password;
            btnsubmit.Text = AppGlobalResources.Resourcefr.home_signin;
            lblforgot.Text = AppGlobalResources.Resourcefr.home_forgot_password;
            lblcreateac.Text = AppGlobalResources.Resourcefr.home_dont_have_account;
        }


    }
}