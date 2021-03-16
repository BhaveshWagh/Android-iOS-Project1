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
    public partial class OTP : ContentPage
    {
        public OTP()
        {
            InitializeComponent();
        }

        private void B1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (B1.Text.Length > 0)
            {
                B2.Focus();
            }
        }

        private void B2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (B2.Text.Length > 0)
            {
                B3.Focus();
            }
        }

        private void B3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (B3.Text.Length > 0)
            {
                B4.Focus();
            }
        }

        private void B4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (B4.Text.Length > 0)
            {
                B5.Focus();
            }
        }
    }
}