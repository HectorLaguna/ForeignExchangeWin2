using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForeignExchangeWin2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PesosEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value in Pesos", "Accept");
                return;
            }

            decimal pesos = 0;
            if (!decimal.TryParse(PesosEntry.Text, out pesos))
            {
                DisplayAlert("Error", "You must enter a value in Pesos", "Accept");
                return;
            }

            var dollars = pesos / 2976.19048M;
            var euros = pesos / 3517.63393M;
            var pounds = pesos / 3869.27083M;

            DollarsEntry.Text = string.Format("${0:N}", dollars);
            EurosEntry.Text = string.Format("€{0:N}", euros);
            PoundsEntry.Text = string.Format("£{0:N}", pounds);
        }
    }
}
