using AnnuaireAdoNet.Classes;
using CorrectionAnnuaire.ViewModels;
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
        private Contact contactToEdit;
        private ContactViewModel viewModel;
        public MainWindow()
        {
            textBoxesEmails = new List<TextBox>();
            InitializeComponent();
            viewModel = new ContactViewModel();
            DataContext = viewModel;
            //listBoxContact.ItemsSource = Contact.GetContacts();
        }

        //public void ActionValidClick(object sender, RoutedEventArgs routedEventArgs)
        //{
        //    if(viewModel.Contact.Id == 0)
        //    {
        //        //Contact contact = new Contact(prenom.Text, nom.Text, telephone.Text);

        //        if (viewModel.Contact.Save())
        //        {
        //            //foreach (TextBox textBox in textBoxesEmails)
        //            //{
        //            //    if (textBox.Text != "")
        //            //    {
        //            //        Email e = new Email()
        //            //        {
        //            //            Mail = textBox.Text,
        //            //        };
        //            //        e.Save(contact.Id);
        //            //    }
        //            //}
        //            MessageBox.Show("Contact ajouté avec l'id " + viewModel.Contact.Id);
        //            //prenom.Text = "";
        //            //nom.Text = "";
        //            //telephone.Text = "";
        //            //listBoxContact.ItemsSource = Contact.GetContacts();
        //            viewModel.Contacts.Add(viewModel.Contact);
        //            viewModel.Contact = new Contact();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erreur ajout contact");
        //        }
        //    }
        //    else
        //    {
        //        //contactToEdit.LastName = nom.Text;
        //        //contactToEdit.FirstName = prenom.Text;
        //        //contactToEdit.Phone = telephone.Text;
        //        if(viewModel.Contact.Update())
        //        {
        //            MessageBox.Show("Contact modifié ");
        //            //prenom.Text = "";
        //            //nom.Text = "";
        //            //telephone.Text = "";
        //            //listBoxContact.ItemsSource = Contact.GetContacts();
        //            //contactToEdit = null;
        //            viewModel.Contact = new Contact();
        //        }
        //    }
            
        //}

        public void AddEmailTextBox(object sender, RoutedEventArgs routedEventArgs)
        {
            TextBox emailTextBox = new TextBox() { Width = 300};
            emails.Children.Add(emailTextBox);
            textBoxesEmails.Add(emailTextBox);
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if(listBoxContact.SelectedItem is Contact c)
            {
                c.Delete();
                viewModel.Contacts.Remove(c);
                //listBoxContact.ItemsSource = Contact.GetContacts();
            }
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            if (listBoxContact.SelectedItem is Contact c)
            {
                //contactToEdit = c;
                //nom.Text = c.LastName;
                //prenom.Text = c.FirstName;
                //telephone.Text = c.Phone;
                viewModel.Contact = c;
            }
        }
    }
}
