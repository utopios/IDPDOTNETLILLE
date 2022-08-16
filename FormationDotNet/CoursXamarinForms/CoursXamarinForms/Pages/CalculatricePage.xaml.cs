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
        private string[] tab = new string[] { "C", "+/-", "%", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "0", ",", "=" };
        Label label;
        Grid grid;
        private bool newNumber = true;
        private string operation = null;
        private double firstNumber = 0;
        private string[] operations = new string[] { "+", "-", "/", "*" };
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
                b.Clicked += ClickButton;
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

        private void MakeOperation()
        {
            double result = 0;
            double valScreen = Convert.ToDouble(label.Text.ToString());
            switch (operation)
            {
                case "+":
                    result = valScreen + firstNumber;
                    break;
                case "-":
                    result = firstNumber - valScreen;
                    break;
                case "/":
                    result = firstNumber / valScreen;
                    break;
                case "*":
                    result = firstNumber * valScreen;
                    break;
            }
            firstNumber = result;
            label.Text = result.ToString();
        }

        private void ClickButton(object sender, EventArgs routedEventArgs)
        {
            double number;
            if (sender is Button b)
            {
                string val = b.Text.ToString();
                if (double.TryParse(val, out number))
                {
                    if (newNumber)
                    {
                        label.Text = val;
                        newNumber = false;
                    }
                    else
                    {
                        label.Text += val;
                    }
                }
                else
                {
                    newNumber = true;
                    switch (val)
                    {
                        case ",":
                            if (!label.Text.ToString().Contains(","))
                            {
                                label.Text += ",";
                                newNumber = false;
                            }
                            break;
                        case string v when operations.Contains(v):
                            if (operation != null)
                            {
                                MakeOperation();
                            }
                            else
                            {
                                firstNumber = Convert.ToDouble(label.Text.ToString());
                            }
                            operation = v;
                            break;
                        case "=":
                            MakeOperation();
                            operation = null;
                            break;
                        case "C":
                            firstNumber = 0;
                            newNumber = true;
                            operation = null;
                            label.Text = 0.ToString();
                            break;

                    }
                }

            }
        }
    }
}