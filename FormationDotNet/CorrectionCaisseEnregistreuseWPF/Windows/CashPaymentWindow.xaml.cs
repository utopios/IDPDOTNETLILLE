using DAOCaisseEnregistreuse.Classes;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour CashPaymentWindow.xaml
    /// </summary>
    public partial class CashPaymentWindow : Window
    {
        private CashRegistry _cashRegistry;
        private Order _order;
        private ListView _productListView;
        private Label _totalLabel;
        private TextBox _productIdTextBox;
        public CashPaymentWindow()
        {
            InitializeComponent();
        }

        public CashPaymentWindow(CashRegistry cashRegistry ,Order order, ListView productListView, Label totalLabel, TextBox productIdTextBox) : this()
        {
            _cashRegistry = cashRegistry;
            _order = order;
            _productListView = productListView;
            _totalLabel = totalLabel;
            _productIdTextBox = productIdTextBox;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal amount;
            if(decimal.TryParse(AmountTextBox.Text, out amount))
            {
                CashPayment cashPayment = new CashPayment(amount);
                if(_cashRegistry.AddOrder(_order, cashPayment))
                {
                    _order = new Order();
                    _productListView.ItemsSource = new List<ProductOrder>(_order.Products);
                    _totalLabel.Content = _order.Total;
                    _productIdTextBox.Text = "";
                    changeLabel.Content = cashPayment.Change;
                }
            }
        }
    }
}
