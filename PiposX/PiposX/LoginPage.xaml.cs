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
		public LoginPage ()
		{
			InitializeComponent ();
           
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
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            var d4=txtEmail.Text;
            var d = "";

        }
       

    }
    }