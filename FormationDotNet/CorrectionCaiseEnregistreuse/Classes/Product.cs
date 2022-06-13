using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionCaisseEnregistreuse.Classes
{
    class Product
    {
        private int id;
        private string title;
        private decimal price;
        private int stock;
        private static int count = 0;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public decimal Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }

        public Product(string title, decimal price, int stock)
        {
            this.Id = ++count;
            this.Title = title;
            this.Price = price;
            this.Stock = stock;
        }
    }
}
