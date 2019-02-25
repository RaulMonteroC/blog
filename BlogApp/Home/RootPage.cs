using System;

using Xamarin.Forms;

namespace BlogApp.Home
{
    public class RootPage : NavigationPage
    {
        public RootPage(Page page) : base(page)
        {
            BarBackgroundColor = Color.FromHex("D0475D");
            BarTextColor = Color.White;            
        }
    }
}

