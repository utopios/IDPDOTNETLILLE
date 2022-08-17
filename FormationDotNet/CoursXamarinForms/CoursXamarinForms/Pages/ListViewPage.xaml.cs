using CoursXamarinForms.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursXamarinForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        ObservableCollection<string> datas = new ObservableCollection<string>() { "toto", "tata", "titi" };
        ObservableCollection<Personne> dataPersonnes = new ObservableCollection<Personne>() { new Personne() { Name = "tata", Age=33 } };
        public ListViewPage()
        {
            InitializeComponent();
            demoListView.ItemsSource = dataPersonnes;
            //Enlever le bouton retour
            NavigationPage.SetHasBackButton(this, false);
            //NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            datas.Add(demoEntry.Text);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}