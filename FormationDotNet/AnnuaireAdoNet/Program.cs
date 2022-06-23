// See https://aka.ms/new-console-template for more information
using AnnuaireAdoNet.Classes;
using AnnuaireAdoNet.DAO;

Console.WriteLine("Hello, World!");

Contact contact = new Contact("ihab", "abadi", "010101010");
contact.Emails.Add(new Email() { Mail = "t@t.fr" });
contact.Emails.Add(new Email() { Mail = "t@t.com" });
ContactDAO contactDAO = new ContactDAO();
if (contactDAO.Save(contact))
{
    contact.Emails.ForEach(e => e.Save(contact.Id));
}

List<Contact> contacts = Contact.GetContactByPhone("0101");
contacts.ForEach(c => c.Emails = Email.GetEmails(contact.Id));