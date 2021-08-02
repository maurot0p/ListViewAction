using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewAction
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page14 : ContentPage
    {
        public Page14()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int n = int.Parse(a1.Text);
            double sum = 0;
            if (n % 2 == 0) sum = n / 2;
            else sum = ((n + 1) / 2) * (-1);
            Label label = new Label();
            label.Text = sum.ToString();
            layout.Children.Add(label);

        }
    }
}