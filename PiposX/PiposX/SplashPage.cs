using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PiposX
{
	public class SplashPage : ContentPage
	{
        Image splashImage;
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "SplashIcon.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            Label lblname;
            lblname = new Label
            {

                HeightRequest = 100,
                Text = "connect to your community better",
                TextColor = Color.White
            };
            AbsoluteLayout.SetLayoutFlags(lblname, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(lblname, new Rectangle(0.5, 0.62, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(lblname);
            this.BackgroundColor = Color.FromHex("#429de3");
            this.Content = sub;
        }
        protected async override void OnAppearing()
        {
            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(1, 1500, Easing.Linear);
            await splashImage.ScaleTo(1, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new LoginPage())
            {
                BarBackgroundColor = Color.FromHex("#000000"),
                BarTextColor=Color.White
            };
        }
    }
}