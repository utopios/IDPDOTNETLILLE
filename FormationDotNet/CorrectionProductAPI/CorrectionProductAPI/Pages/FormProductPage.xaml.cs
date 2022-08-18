
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
    public partial class FormProductPage : ContentPage
    {
        private Product editProduct = null;
        private ProductApiService _productApiService;
        public FormProductPage()
        {
            InitializeComponent();
            _productApiService = new ProductApiService();
        }

        public FormProductPage(Product product) : this()
        {
            editProduct = product;
            TitleEntry.Text = product.Title;
            StockEntry.Text = product.Stock.ToString();
            PriceEntry.Text = product.Price.ToString();
        }
        private async void ValidButton_Clicked(object sender, EventArgs e)
        {
            string title = TitleEntry.Text;
            int stock;
            decimal price;
            Product p;
            bool result = false;
            if (decimal.TryParse(PriceEntry.Text, out price) && int.TryParse(StockEntry.Text, out stock))
            {
                if (editProduct == null)
                {
                    p = new Product()
                    {
                        Title = title,
                        Stock = stock,
                        Price = price,

                    };
                    Product product = await _productApiService.PostProduct(p);
                    result = product != null;
                }
                else
                { 
                    
                    editProduct = null;
                }
                if(result)
                {
                    TitleEntry.Text = "";
                    PriceEntry.Text = "";
                    StockEntry.Text = "";
                    await Navigation.PopToRootAsync();
                }
                
            }
        }
    }
}