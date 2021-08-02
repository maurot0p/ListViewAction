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
    public partial class Page11 : ContentPage
    {
        public Page11()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            int n = int.Parse(n_.Text);
            string scores = k.Text;
            List<int> numbers = new List<int>(Array.ConvertAll(scores.Split(' '), int.Parse));
            int[] arr = new int[n + 1];
            int[] arr2= new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                arr[i] = numbers[i-1];
            }
            for (int i = 1; i <=n; i++)
            {
                arr2[i] = Array.IndexOf(arr, i);
            }
            arr2 = arr2.Skip(1).ToArray();
            Label label = new Label();
            var result = string.Join(" ", arr2); // (.NET 4.0+)
            label.Text = result;
            layout.Children.Add(label);
        }
    }
}