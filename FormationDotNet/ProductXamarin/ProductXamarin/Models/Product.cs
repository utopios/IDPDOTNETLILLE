using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductXamarin.Models
{
    public class Product : ViewModelBase
    {
        public static int count = 0;
        private string title;
        private string description;
        private decimal price;
        public int Id { get; set; }
        public string Title
        {
            get => title; set
            {
                title = value;
                RaisePropertyChanged();
            }
        }
        public string Description
        {
            get => description; set
            {
                description = value;
                RaisePropertyChanged("ShortDescription");
            }
        }
        public decimal Price
        {
            get => price; set
            {
                price = value;
                RaisePropertyChanged();
            }
        }
        public string ShortDescription { get => (Description.Length >= 20) ? Description.Substring(0, 20) : Description; }

        public Product()
        {
            Id = ++count;
        }
    }
}
