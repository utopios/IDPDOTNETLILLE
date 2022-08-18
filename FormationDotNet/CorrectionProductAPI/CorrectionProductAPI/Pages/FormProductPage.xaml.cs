
using CorrectionProductAPI.Models;
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
        public FormProductPage()
        {
            InitializeComponent();
        }

        public FormProductPage(Product product) : this()
        {
            editProduct = product;
            TitleEntry.Text = product.Title;
            //DescriptionEntry.Text = product.Description;
            PriceEntry.Text = product.Price.ToString();
        }
        private async void ValidButton_Clicked(object sender, EventArgs e)
        {
            string title = TitleEntry.Text;
            string description = DescriptionEntry.Text;
            decimal price;
            Product p;
            if (decimal.TryParse(PriceEntry.Text, out price))
            {
                if (editProduct == null)
                {
                    p = new Product()
                    {
                        Title = title,
                        //Description = description,
                        Price = price,

                    };
                   // Product.Products.Add(p);
                }
                else
                { 
                    editProduct.Title = title;
                    //editProduct.Description = description;
                    editProduct.Price = price;
                    editProduct = null;
                }
                TitleEntry.Text = "";
                PriceEntry.Text = "";
                DescriptionEntry.Text = "";
                await Navigation.PopToRootAsync();
            }
        }
    }
}