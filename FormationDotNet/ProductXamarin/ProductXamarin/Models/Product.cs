using System;
using System.Collections.Generic;
using System.Text;

namespace ProductXamarin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get => (Description.Length >= 20) ? Description.Substring(0, 20) : Description; }

    }
}
