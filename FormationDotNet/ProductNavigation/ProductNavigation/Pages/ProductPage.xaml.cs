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
    public partial class ProductPage : ContentPage
    {
        private Product _product;
        public ProductPage(Product product)
        {
            InitializeComponent();
            _product = product;
            BindingContext = _product;
        }

        private async void EditButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormProductPage(_product));
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            Product.Products.Remove(_product);
            await Navigation.PopToRootAsync();
        }
    }
}