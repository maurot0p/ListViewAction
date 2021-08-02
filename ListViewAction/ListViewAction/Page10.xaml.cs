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
    public partial class Page10 : ContentPage
    {
        public Page10()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int year = int.Parse(n1.Text);
            int n = year + 1;
            int elyear = 0;
            for (int i = year + 1; i <= n; i++)
            {
                int millar = i / 1000;
                int centena = (i % 1000) / 100;
                int decena = (i % 100) / 10;
                int unidad = i % 10;

                if (millar != centena && millar != decena && millar != unidad && centena != decena && centena != unidad && decena != unidad)
                {
                    elyear = i;
                }
                else
                {
                    n++;
                }
            }
            Label label = new Label();
            label.Text = elyear.ToString();
            layout.Children.Add(label);

        }
    }
}