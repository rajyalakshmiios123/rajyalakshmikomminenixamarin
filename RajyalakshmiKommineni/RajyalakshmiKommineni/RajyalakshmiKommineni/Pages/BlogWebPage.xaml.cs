using RajyalakshmiKommineni.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RajyalakshmiKommineni.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BlogWebPage : ContentPage
    {
        BlogViewModel blogViewModel;
        public BlogWebPage()
        {
            InitializeComponent();
            webView.Navigating += WebView_Navigating;
            webView.Navigated += WebView_Navigated;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            Title = "";
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            Title = "Loading...";
        }

        void backButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                this.Navigation.PopAsync(); // closes the in-app browser view.
            }
        }


        void forwardButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }
    }
}