using AnnuaireAdoNet.Classes;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CorrectionAnnuaire.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        private Contact contact;

        public ObservableCollection<Contact> Contacts { get; set; }

        public ICommand ConfirmCommand { get; set; }

        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                RaisePropertyChanged("FirstName");
                RaisePropertyChanged("LastName");
                RaisePropertyChanged("Phone");
            }
        }
        public string FirstName
        {
            set
            {
                contact.FirstName = value;
                RaisePropertyChanged("FirstName");
            }
            get => contact.FirstName;
        }

        public string LastName
        {
            set
            {
                contact.LastName = value;
                RaisePropertyChanged("LastName");
            }
            get => contact.LastName;
        }

        public string Phone
        {
            set
            {
                contact.Phone = value;
                RaisePropertyChanged("Phone");
            }
            get => contact.Phone;
        }

        public ContactViewModel()
        {
            Contact= new Contact();
            Contacts = new ObservableCollection<Contact>(Contact.GetContacts());
            ConfirmCommand = new RelayCommand(ConfirmContact);
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ConfirmContact()
        {
            if (Contact.Id == 0)
            {
               
                if (Contact.Save())
                {
                    
                    MessageBox.Show("Contact ajouté avec l'id " + Contact.Id);
                    
                    Contacts.Add(Contact);
                    Contact = new Contact();
                }
                else
                {
                    MessageBox.Show("Erreur ajout contact");
                }
            }
            else
            {
              
                if (Contact.Update())
                {
                    MessageBox.Show("Contact modifié ");

                    Contact = new Contact();
                }
            }
        }
    }
}
