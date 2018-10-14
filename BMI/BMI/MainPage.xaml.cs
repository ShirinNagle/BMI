using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
            
             void BtnCalcLabel_Clicked(object sender, EventArgs e)
            {
                double fHeight = Convert.ToDouble(entryHeight.Text);
                double fWeight = Convert.ToDouble(entryWeight.Text);
                double bmiResult = Math.Round( fWeight / (fHeight * fHeight), 2);
                                           
                bmiResultLbl.Text = "Your BMI is " + Convert.ToString(bmiResult);

            if (bmiResult >= 40)
            {
                String result = bmiResultWords.Text = "Please visit your Doctor!!";
            }
            else if (bmiResult >= 30)
            {
                String result = bmiResultWords.Text = "You are obese!!";
            }
            else if (bmiResult >= 25)
            {
                String result = bmiResultWords.Text = "You are over weight!!";
            }

            else if (bmiResult >= 18.5)
            {
                String result = bmiResultWords.Text = "Your BMI is within a normal range!!";
            }
            else
            {
                String result = bmiResultWords.Text = "You are underweight!!";
            }

        }

        
    }
}
