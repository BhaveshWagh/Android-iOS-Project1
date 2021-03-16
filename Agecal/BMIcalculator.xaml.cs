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
    public partial class BMIcalculator : ContentPage
    {
        public BMIcalculator()
        {
            InitializeComponent();
        }

        private void CalculatorBMIButton_Clicked(object sender, EventArgs e)
        {
            // BMI = (Wt in kg) / (Hgt in (mt)2)

            var Weight_in_kg = double.Parse(kgEntry.Text);
            var Height_in_cm = double.Parse(CmEntry.Text);
            var Height_in_meter = (Height_in_cm / 100.0);
            var hims = (Height_in_meter * Height_in_meter);
            var bmi = (Weight_in_kg / hims);

            BMI_lable.Text = bmi.ToString();
        }
        int wt = 0;

        private void KgSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            kgEntry.Text = KgSlider.Value.ToString();
        }

        private void CmSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CmEntry.Text = CmSlider.Value.ToString();
        }
    }
} 