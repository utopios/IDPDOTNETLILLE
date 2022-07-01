using AnnuaireAdoNet.Classes;
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

namespace CorrectionAnnuaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ActionValidClick(object sender, RoutedEventArgs routedEventArgs)
        {
            Contact contact = new Contact(prenom.Text, nom.Text, telephone.Text);
            if(contact.Save())
            {
                MessageBox.Show("Contact ajouté avec l'id " + contact.Id);
                prenom.Text = "";
                nom.Text = "";
                telephone.Text = "";
            }
            else
            {
                MessageBox.Show("Erreur ajout contact");
            }
        }
    }
}
