using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            double a = Double.Parse(num1.Text);
            double b = Double.Parse(num2.Text);
            res.Text = (a * b * 1.036).ToString();
        }
        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            res.Text = String.Empty;
        }
    }
}
