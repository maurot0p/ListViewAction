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
    public partial class Page13 : ContentPage
    {
        public Page13()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int a = int.Parse(a1.Text);
            int b = int.Parse(b2.Text);
            int c = int.Parse(c3.Text);
            int suma1 = a + b;
            int suma2 = b + c;
            int multi1 = a * b;
            int multi2 = b * c;
            int multi3 = a * b * c;
            int multiadd = multi1 + c;
            int multiadd2 = multi2 + a;
            int multiadd3 = suma1 * c;
            int multiadd4 = suma2 * a;
            int sum = a + b + c;
            int multireal = Math.Max(Math.Max(multiadd, multiadd2), Math.Max(multi3, multiadd3));
            int elyear = (Math.Max(Math.Max(multiadd4, sum), multireal));
            Label label = new Label();
            label.Text = elyear.ToString();
            layout.Children.Add(label);

        }
    }
}