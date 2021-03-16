using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agecal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate_Button_Clicked(object sender, EventArgs e)
        {
            int byear = int.Parse(BYear_Entry.Text);

            int age = DateTime.Now.Year - byear;

            Oplabel.Text = age.ToString();

            DisplayAlert("Age calculator", $"Your Age is: {age}", "ok");
;
        }

     
    }
}
