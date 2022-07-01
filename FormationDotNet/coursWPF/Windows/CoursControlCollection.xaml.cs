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
    /// Logique d'interaction pour CoursControlCollection.xaml
    /// </summary>
    public partial class CoursControlCollection : Window
    {
        private List<string> listeStrings = new List<string>() { "toto", "tata", "titi"};
        private List<object> listObjets = new List<object>() { new { Titre = "titre 1", Prix = "p1" }, new { Titre = "titre 2", Prix = "p2" } };
        public CoursControlCollection()
        {
            InitializeComponent();
            maListBox.ItemsSource = listeStrings;
            maListView.ItemsSource = listObjets;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            listeStrings.Add("test element");
            maListBox.ItemsSource =  new List<string>(listeStrings);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(maListBox.SelectedItem.ToString());
        }
    }
}
