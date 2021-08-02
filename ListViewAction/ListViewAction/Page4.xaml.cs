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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Double a = int.Parse(a1.Text);
            Double b = int.Parse(b2.Text);
            Double c = int.Parse(c3.Text);
            if(a+b>c && a+c>b && b + c > a)
            {
                if(a==b && c == b)
                {
                    Label label = new Label();
                    label.Text = "Se puede formar un triangulo equilatero";
                layout.Children.Add(label);
                }
               else if(a==b || a==c || c==b)
                {
                    Label label = new Label();
                    label.Text = "Se puede formar un triangulo isosceles";
                    layout.Children.Add(label);
                }
                else
                {
                    Label label = new Label();
                    label.Text = "Se puede formar un triangulo escaleno";
                    layout.Children.Add(label);
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "No se puede formar un triangulo";
                layout.Children.Add(label);
            }
           
        }

    }
}
