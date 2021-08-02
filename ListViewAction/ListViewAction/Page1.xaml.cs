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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        Label label = new Label();
                        label.Text = i.ToString();
                        layout.Children.Add(label);
                    }
                }
            }
        }
    }
}