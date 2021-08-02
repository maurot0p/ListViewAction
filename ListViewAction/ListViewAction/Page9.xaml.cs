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
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string scores_ = n1.Text;
            List<int> numbers = new List<int>(Array.ConvertAll(scores_.Split(' '), int.Parse));
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max) max = numbers[i];
                if (numbers[i] < min) min = numbers[i];
            }
            Label label = new Label();
            label.Text = "El maximo es " + max.ToString();
            layout.Children.Add(label);
            Label label2 = new Label();
            label2.Text = "El minimo es " + min.ToString();
            layout.Children.Add(label2);

        }
    }
}