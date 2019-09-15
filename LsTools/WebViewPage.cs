using System;

using Xamarin.Forms;

namespace LsTools
{
    public class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

