using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobilna2024
{
    public partial class MainPage : ContentPage
    {
        string[] napisy = { "Dzień dobry", "Good morning", "Buenos dias" };
        int quoteIndex = 0;
        public MainPage()
        {
            InitializeComponent();

            

            cytat.Text = napisy[0];
        }
       
        private void Button_Clicked(object sender, EventArgs e)
        {
          quoteIndex++;
            if (quoteIndex > napisy.Length)
                quoteIndex = 0;
            cytat.Text = napisy[quoteIndex];
        }
    }
}
