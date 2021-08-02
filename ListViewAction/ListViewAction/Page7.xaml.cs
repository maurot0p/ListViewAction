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
    public partial class Page7 : ContentPage
    {
        public Page7()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Double n = Double.Parse(areaa.Text);
            Double x = Math.Sqrt(n);
            Double perimetro = 4.0 * x;
            Label label = new Label();
            label.Text = perimetro.ToString();
            layout.Children.Add(label);
        }
    }
}