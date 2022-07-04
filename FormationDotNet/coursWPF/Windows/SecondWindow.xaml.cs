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

namespace coursWPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private MainWindow _mainWindow;
        public SecondWindow()
        {
            InitializeComponent();
        }

        public SecondWindow(string data) : this()
        {
            result.Content = data;
        }

        public SecondWindow(MainWindow window) : this()
        {
            _mainWindow = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
        }
    }
}
