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
        private int? productId;
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
            Product p;
            if(decimal.TryParse(PriceEntry.Text, out price))
            {
                if(productId == null)
                {
                    p = new Product()
                    {
                        Title = title,
                        Description = description,
                        Price = price,
                    
                    };
                    products.Add(p);
                }else
                {
                    p = products.FirstOrDefault(el => el.Id == productId);
                    if(p != null)
                    {
                        p.Title = title; 
                        p.Description = description; 
                        p.Price= price;
                    }
                    productId = null;
                }
                TitleEntry.Text = "";
                PriceEntry.Text = "";
                DescriptionEntry.Text = "";
            }

        }

        private void ProductsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ProductsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        //private void MenuItem_Clicked(object sender, EventArgs e)
        //{
        //    Product p = (Product)(sender as Button).CommandParameter;
        //}

        private void DeleteItem_Clicked(object sender, EventArgs e)
        {
            Product p = (Product)(sender as MenuItem).CommandParameter;
            products.Remove(p);
        }
        private void EditItem_Clicked(object sender, EventArgs e)
        {
            Product p = (Product)(sender as MenuItem).CommandParameter;
            TitleEntry.Text = p.Title;
            PriceEntry.Text = p.Price.ToString();
            DescriptionEntry.Text = p.Description;
            productId = p.Id;
        }
    }
}