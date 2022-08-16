using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursXamarinForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatricePage : ContentPage
    {
        private string[] tab = new string[] { "C", "+/-", "%", "/", "7", "8", "9", "X", "4", "5", "6", "-", "1", "2", "3", "+", "0", ",", "=" };
        Label label;
        Grid grid;
        public CalculatricePage()
        {
            InitializeComponent();
            grid = new Grid();
            CreateBlackScreen();
            CreateRowsAndCols();
            CreateButton();
            Content = grid;
        }

        private void CreateBlackScreen()
        {
            label = new Label()
            {
                Text = 0.ToString(),
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.End,
                TextColor = Color.White,
                BackgroundColor = Color.Black
            };
            Grid.SetColumn(label, 0);
            Grid.SetRow(label, 0);
            Grid.SetColumnSpan(label, 4);
            grid.Children.Add(label);
        }

        private void CreateRowsAndCols()
        {
            for (int i = 1; i <= 6; i++)
            {
                if (i <= 4)
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(i == 1 ? 2 : 1, GridUnitType.Star) });
            }
        }

        private void CreateButton()
        {
            int row = 1, col = 0, count = 0;
            for (int i = 0; i < tab.Length; i++)
            {

                Button b = new Button()
                {
                    Text = tab[i]
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
                if ((count + 1) % 4 == 0)
                {
                    row++;
                    col = 0;
                    b.BackgroundColor = Color.Orange;
                }
                else
                {
                    col++;
                }
                count++;
            }
        }
    }
}