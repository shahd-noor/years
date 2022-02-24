using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace years
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            for (int i = 1990; i <= 2030; i++)
            {
                Label label = new Label();

                t.Children.Add(label);
                label.Text = i + "\n";


            }
        }
    }
}