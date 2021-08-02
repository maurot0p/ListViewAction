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
    public partial class Page8 : ContentPage
    {
        public Page8()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int n_ = int.Parse(n.Text);
            int k_ = int.Parse(k.Text);
            string scores_ = scores.Text;
            List<int> numbers = new List<int>(Array.ConvertAll(scores_.Split(' '), int.Parse));

            int count = 0;
           
            for (int i = 0; i < n_; i++)
            {
                if ((numbers[i] >= numbers[k_ - 1]) && numbers[i] > 0) count++;
            }

            Label label = new Label();
            label.Text = count.ToString();
            layout.Children.Add(label);
        }
    }
}