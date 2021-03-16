using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agecal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebBrowser : ContentPage
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void goButton_Clicked(object sender, EventArgs e)
        {
            myBrowser.Source = $"https://www.google.com/search?q={AddressBar.Text.ToString()}";

            if (myBrowser.CanGoBack)
            {
                BackButton.BackgroundColor = Color.Salmon;
            }
          

            if (myBrowser.CanGoForward)
            {
                ForwardButton.BackgroundColor = Color.Salmon;
            }
            
        }

        private void AddressBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            myBrowser.Source = $"https://www.google.com/search?q={AddressBar.Text.ToString()}";


            if (myBrowser.CanGoBack)
            {
                BackButton.BackgroundColor = Color.Salmon;
            }

            if (myBrowser.CanGoForward)
            {
                ForwardButton.BackgroundColor = Color.Salmon;
            }
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if (myBrowser.CanGoBack)
            {
                myBrowser.GoBack();
            }
            
        }

        private void ForwardButton_Clicked(object sender, EventArgs e)
        {
            if (myBrowser.CanGoForward)
            {
                myBrowser.GoForward();
            }
        }
    }
}