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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Label label = new Label();
            string time = word.Text;
            string[] s = time.Split(':');
            if (int.Parse(s[0]) <= 12) //digo que 12 del mediodia es am
            {
                label.Text = s[0] + ":" + s[1] + "am";
                layout.Children.Add(label);
            }
            else
            {
                label.Text = int.Parse(s[0]) - 12 + ":" + s[1] + "pm";

                layout.Children.Add(label);
            }
          
        }

    }
}