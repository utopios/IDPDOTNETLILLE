
using AnnuaireEntityFrameWorkCore.Classes;
using AnnuaireEntityFrameWorkCore.Tools;
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

        private DataContext _dataContext;

        private Contact contact;

        private Contact selectedContact;

        public ObservableCollection<Contact> Contacts { get; set; }

        public ICommand ConfirmCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

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

        public Contact SelectedContact { get => selectedContact; set => selectedContact = value; }

        public ContactViewModel()
        {
            _dataContext = new DataContext();
            Contact= new Contact();
            Contacts = new ObservableCollection<Contact>(_dataContext.Contacts);
            ConfirmCommand = new RelayCommand(ConfirmContact);
            EditCommand = new RelayCommand(EditCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);
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
                _dataContext.Contacts.Add(Contact);
                if (_dataContext.SaveChanges() > 0)
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
              
                if (_dataContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Contact modifié ");

                    Contact = new Contact();
                    
                }
            }
        }

        private void EditCommandAction()
        {
            if(SelectedContact != null)
            {
                Contact = SelectedContact;
            }
        }

        private void DeleteCommandAction()
        {
            if (SelectedContact != null)
            {
                //SelectedContact.Delete();
                _dataContext.Contacts.Remove(SelectedContact);
                _dataContext.SaveChanges();
                Contacts.Remove(SelectedContact);
            }
        }
    }
}
