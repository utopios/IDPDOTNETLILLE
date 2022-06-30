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
    /// Logique d'interaction pour Calculatrice.xaml
    /// </summary>
    public partial class Calculatrice : Window
    {
        private string[] tab = new string[] { "C", "+/-", "%", "/", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "0", ",", "=" };
        private Grid grid;
        public Calculatrice()
        {
            InitializeComponent();
            grid = new Grid();
            CreateRowsAndCols();
            CreateButton();
            CreateBlackScreen();
            Content = grid;
        }

        private void CreateBlackScreen()
        {
            Label label = new Label()
            {
                Content = 0,
                HorizontalContentAlignment = HorizontalAlignment.Right,
                VerticalContentAlignment = VerticalAlignment.Bottom,
                Foreground = new SolidColorBrush(Colors.White),
                Background = new SolidColorBrush(Colors.Black)
            };
            Grid.SetColumn(label, 0);
            Grid.SetRow(label, 0);
            Grid.SetColumnSpan(label, 4);
            grid.Children.Add(label);
        }

        private void CreateRowsAndCols()
        {
            for(int i = 1; i <=6; i++)
            {
                if (i <= 4)
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength( i== 1 ? 2 : 1, GridUnitType.Star) });
            }
        }

        private void CreateButton()
        {
            int row = 1, col = 0,count = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                
                Button b = new Button()
                {
                    Content = tab[i]
                };
                grid.Children.Add(b);
                Grid.SetColumn(b, col);
                Grid.SetRow(b, row);
                if (tab[i] == "0")
                {
                    col++;
                    Grid.SetColumnSpan(b, 2);
                    count++;
                }
                if ((count+1)%4 == 0)
                {
                    row++;
                    col = 0;
                    b.Background = new SolidColorBrush(Colors.Orange);
                }else
                {
                    col++;
                }
                count++;
            }
        }
    }
}
