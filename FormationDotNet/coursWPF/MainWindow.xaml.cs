using coursWPF.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace coursWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Title = "Avec du C#";
            //b1.Content = "Contenu bouton ajouté en c#";
            //CreateStackPanel();
            //CreateGrid();
        }

        private void CreateStackPanel()
        {
            StackPanel stack = new StackPanel();
            stack.Orientation = Orientation.Horizontal;
            stack.Children.Add(new Button() { Content = "b1" });
            stack.Children.Add(new Button() { Content = "b2" });
            stack.Children.Add(new Label() { Content = "label 1" });
            Content = stack;

        }

        private void CreateGrid()
        {
            Grid grid = new Grid();
            RowDefinition row1 = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };
            RowDefinition row2 = new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Star)
            };
            grid.RowDefinitions.Add(row2);
            grid.RowDefinitions.Add(row1);
            Button b1 = new Button() { Content = "b1" };
            Button b2 = new Button() { Content = "b2" };
            b1.Click += DemoClick;
            b2.Click += DemoClick;
            Grid.SetRow(b1, 0);
            Grid.SetRow(b2, 1);
            grid.Children.Add(b1);
            grid.Children.Add(b2);
            Content = grid;
        }
        public void DemoClick(object sender, RoutedEventArgs eventArgs)
        {
            Button b = (Button)sender;

            MessageBox.Show("Click OK sur bouton"+ b.Content);
            SecondWindow w = new SecondWindow(this);
            w.Show();
        }
    }
}
