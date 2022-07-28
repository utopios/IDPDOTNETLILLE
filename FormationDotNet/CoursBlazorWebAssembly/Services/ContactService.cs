using CoursBlazorWebAssembly.Models;

namespace CoursBlazorWebAssembly.Services
{
    public class ContactService
    {
        public List<Contact> Contacts { get; set; }

        public ContactService()
        {
            Contacts = new List<Contact>();
        }
    }
}
