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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var numero1 = int.Parse(num1.Text);
            var numero2 = int.Parse(num2.Text);
            for (int i = numero1 + 1; i < numero2; i++)
            {
                if (i % 3 == 0)  //asumi que eran multiploxamas por separado de 2 y 3
                {
                    Label label = new Label();
                    label.Text = i + " es multiplo de 3, el cuadrado de " + i + " es " + i * i + " y el cubo de " + i + " es " + i * i * i;
                    layout.Children.Add(label);
                }
                if (i % 2 == 0)
                {
                    Label label = new Label();
                    label.Text = i + " es multiplo de 2, el cuadrado de " + i + " es " + i * i + " y el cubo de " + i + " es " + i * i * i;
                    layout.Children.Add(label);
                }

            }
        }
    }
}