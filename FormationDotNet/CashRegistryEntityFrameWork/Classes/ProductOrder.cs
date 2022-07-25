using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CashRegistryEntityFrameWork.Classes
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
        
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get => product; set => product = value; }
        [JsonIgnore]
        [ForeignKey("OrderId")]
        public Order Order { get; set; }


        [NotMapped]
        public decimal Total { get => Qty * Product.Price; }

        [NotMapped]
        public string Title { get => Product.Title; }
        [NotMapped]
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
