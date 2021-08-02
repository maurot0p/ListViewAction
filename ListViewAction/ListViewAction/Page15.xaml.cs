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
    public partial class Page15 : ContentPage
    {
        public Page15()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int n = int.Parse(n_.Text);
            int even = 0, uneven = 0, index = 1;
            string scores = k.Text;
            int[] arr = new int[n + 1];
            List<int> numbers = new List<int>(Array.ConvertAll(scores.Split(' '), int.Parse));
            for (int i = 1; i <= n; i++)
            {
                int a = numbers[i - 1];
                if (a % 2 == 0) even++;
                else uneven++;
                arr[i] = a;
            }
            for (int i = 1; i <= n; i++)
            {
                if (even > uneven)
                {
                    if (arr[i] % 2 != 0)
                    {
                        index = i;
                    }
                }
                else
                {
                    if (arr[i] % 2 == 0)
                    {
                        index = i;
                    }
                }
            }
                Label label = new Label();
                label.Text = index.ToString();
                layout.Children.Add(label);
            }
        }
    }
