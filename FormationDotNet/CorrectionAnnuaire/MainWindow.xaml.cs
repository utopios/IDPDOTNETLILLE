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
        private List<TextBox> textBoxesEmails;
        public MainWindow()
        {
            textBoxesEmails = new List<TextBox>();
            InitializeComponent();
        }

        public void ActionValidClick(object sender, RoutedEventArgs routedEventArgs)
        {
            Contact contact = new Contact(prenom.Text, nom.Text, telephone.Text);
            
            if(contact.Save())
            {
                foreach (TextBox textBox in textBoxesEmails)
                {
                    if (textBox.Text != "")
                    {
                        Email e = new Email()
                        {
                            Mail = textBox.Text,
                        };
                        e.Save(contact.Id);
                    }
                }
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

        public void AddEmailTextBox(object sender, RoutedEventArgs routedEventArgs)
        {
            TextBox emailTextBox = new TextBox() { Width = 300};
            emails.Children.Add(emailTextBox);
            textBoxesEmails.Add(emailTextBox);
        }
    }
}
