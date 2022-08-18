using ProductNavigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductNavigation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
            ProductsListView.ItemsSource = Product.Products;
        }

        private async void ProductsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item is Product product)
            {
                await Navigation.PushAsync(new ProductPage(product));
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormProductPage());
        }
    }
}