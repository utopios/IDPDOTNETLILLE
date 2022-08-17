using ProductXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductXamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        private ObservableCollection<Product> products;
        public ProductPage()
        {
            products = new ObservableCollection<Product>();
            InitializeComponent();
            ProductsListView.ItemsSource = products;
        }

        private void ValidButton_Clicked(object sender, EventArgs e)
        {
            string title = TitleEntry.Text;
            string description = DescriptionEntry.Text;
            decimal price;
            if(decimal.TryParse(PriceEntry.Text, out price))
            {
                Product p = new Product()
                {
                    Title = title,
                    Description = description,
                    Price = price
                };
                products.Add(p);
            }
        }

        private void ProductsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ProductsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}