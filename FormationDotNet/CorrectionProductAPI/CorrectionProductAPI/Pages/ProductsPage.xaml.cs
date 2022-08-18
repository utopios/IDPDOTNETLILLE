using CorrectionProductAPI.Models;
using CorrectionProductAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionProductAPI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        private ProductApiService _productApiService;
        public ProductsPage()
        {
            InitializeComponent();
            _productApiService = new ProductApiService();

        }

        protected async override void OnAppearing()
        {
            GetProducts();
        }

        private async void GetProducts()
        {
            ProductsListView.ItemsSource = await _productApiService.GetProducts();
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