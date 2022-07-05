using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCaisseEnregistreuse.Classes
{
    public class ProductOrder : INotifyPropertyChanged
    {
        private Product product;
        private int qty;

        public int Qty
        {
            get => qty; set
            {
                qty = value;
                RaisePropertyChanged("Total");
                RaisePropertyChanged("Qty");
            }
        }
        public Product Product { get => product; set => product = value; }

        public decimal Total { get => Qty * Product.Price; }

        public string Title { get => Product.Title; }

        public decimal Price { get => Product.Price; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
