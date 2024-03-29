﻿using DAOCaisseEnregistreuse.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CorrectionCaisseEnregistreuseWPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private CashRegistry cashRegistry;
        private Order order;
        public HomeWindow()
        {
            InitializeComponent();
            cashRegistry = new CashRegistry();
            order = new Order();
            ProductsListView.ItemsSource = order.Products;
        }

        private void AddProductToOrderClick(object sender, RoutedEventArgs e)
        {
            int productNumber;
            if(int.TryParse(ProductIdTextBox.Text, out productNumber))
            {
                Product product = cashRegistry.GetProductById(productNumber);
                if(product != null)
                {
                    order.AddProduct(product);
                    //ProductsListView.ItemsSource = new List<ProductOrder>(order.Products);
                    //TotalLabel.Content = order.Total;
                    ProductIdTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Aucun produit avec cet id");
                }
            }
            else
            {
                MessageBox.Show("Merci de saisir un numéro");
            }
        }

        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {
            if(ProductsListView.SelectedItem is ProductOrder product)
            {
                if(order.DeleteProduct(product))
                {
                    //ProductsListView.ItemsSource = new List<ProductOrder>(order.Products);
                    TotalLabel.Content = order.Total;
                }
            }
        }

        private void NewOrderClick(object sender, RoutedEventArgs e)
        {
            order = new Order();
            ProductsListView.ItemsSource = new List<ProductOrder>(order.Products);
            TotalLabel.Content = order.Total;
            ProductIdTextBox.Text = "";
        }

        private void ProductsClick(object sender, RoutedEventArgs e)
        {
            ProductWindow w = new ProductWindow();
            w.Show();
        }

        private void CardPaymentClick(object sender, RoutedEventArgs e)
        {
            CardPayment payment = new CardPayment();
            if(cashRegistry.AddOrder(order, payment))
            {
                MessageBox.Show("Paiement OK");
                order = new Order();
                ProductsListView.ItemsSource = new List<ProductOrder>(order.Products);
                TotalLabel.Content = order.Total;
                ProductIdTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Paiement NOT OK!!!!!!");
            }
        }

        private void CashPaymentClick(object sender, RoutedEventArgs e)
        {
            CashPaymentWindow w = new CashPaymentWindow(cashRegistry, order, ProductsListView, TotalLabel, ProductIdTextBox);
            w.Show();
        }
    }
}
