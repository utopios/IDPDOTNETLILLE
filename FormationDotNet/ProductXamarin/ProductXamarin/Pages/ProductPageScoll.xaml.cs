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
    public partial class ProductPageScroll : ContentPage
    {
        private ObservableCollection<Product> products;
        private int? productId;
        public ProductPageScroll()
        {
            products = new ObservableCollection<Product>();
            InitializeComponent();
            
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
                    CreateProductStackLayout(p);
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

        private void CreateProductStackLayout(Product product)
        {
            StackLayout main = new StackLayout();
            StackLayout l1 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            StackLayout l2 = new StackLayout() { Orientation = StackOrientation.Horizontal };
            main.Children.Add(l1);
            main.Children.Add(l2);
            Label lTitle = new Label() { Text = product.Title };
            Label lPrice = new Label() { Text = product.Price.ToString() };
            Label lDescription = new Label() { Text = product.ShortDescription };
            l1.Children.Add(lTitle);
            l1.Children.Add(lPrice);
            l2.Children.Add(lDescription);
            ScrollProduct.Children.Add(main);
         }
    }
}