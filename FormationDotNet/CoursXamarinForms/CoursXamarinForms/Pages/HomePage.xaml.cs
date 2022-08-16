using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursXamarinForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //GenerateContent();
        }

        private void GenerateContent()
        {
            StackLayout stackLayout = new StackLayout();
            Content = stackLayout;
            Label label = new Label() { Text = "content of label" };
            //stackLayout1.Children.Add(label);
            stackLayout.Children.Add(label);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = EntryName.Text;
        }
    }
}