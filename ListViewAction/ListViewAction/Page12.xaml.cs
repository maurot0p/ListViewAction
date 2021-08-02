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
    public partial class Page12 : ContentPage
    {
        public Page12()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Double a = int.Parse(a1.Text);
            Double b = int.Parse(b2.Text);
            Double c = int.Parse(c3.Text);
            Double s = (a + b + c) / 2;
            Double area = Math.Sqrt( s * (s - a) * (s - b) * (s - c) );
            Label label = new Label();
            label.Text = area.ToString();
            layout.Children.Add(label);

        }
    }
}