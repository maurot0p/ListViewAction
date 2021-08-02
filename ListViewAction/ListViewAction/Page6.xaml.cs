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
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            string sumof = word.Text;
            char[] sum = sumof.ToCharArray();
            for (int i = 0; i < sum.Length; i = i + 2)
            {
                for (int j = 0; j < sum.Length - i - 2; j = j + 2)
                {
                    if (sum[j] > sum[j + 2])
                    {
                        char tmp = sum[j];
                        sum[j] = sum[j + 2];
                        sum[j + 2] = tmp;
                    }
                }
            }
            Label label = new Label();
            string charsStr = new string(sum);
            label.Text = charsStr;
            layout.Children.Add(label);
        }
    }
}