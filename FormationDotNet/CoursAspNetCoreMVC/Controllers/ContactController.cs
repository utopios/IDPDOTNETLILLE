using AnnuaireEntityFrameWorkCore.Classes;
using AnnuaireEntityFrameWorkCore.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCoreMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index(string search, string message, string type)
        {
            //
            DataContext _data = new DataContext();
            //ViewData["contacts"] = _data.Contacts.ToList();
            //ViewBag.contacts = _data.Contacts.ToList();
            ViewBag.message = message;
            ViewBag.type = type;
            if (search == null || search == "")
            {
                return View(_data.Contacts.ToList());

            }
            else
            {
                return View(_data.Contacts.Where(c => c.FirstName == search || c.LastName == search || c.Phone == search).ToList());
            }
        }

        public IActionResult Form(int? id)
        {
            Contact contact = new Contact();
            if (id != null)
            {
                DataContext _data = new DataContext();
                contact = _data.Contacts.Find(id);
            }
            return View(contact);
        }

        //public IActionResult SubmitForm(string firstName, string lastName, string phone)
        public IActionResult SubmitForm([Bind("FirstName", "LastName", "Phone")] Contact contact, int? id)
        {

            DataContext _data = new DataContext();
            //Contact contact = new Contact()
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Phone = phone
            //};
            if(id == null)
            {
                _data.Contacts.Add(contact);
                _data.SaveChanges();
            }
            else
            {
                Contact updateContact = _data.Contacts.Find(id);
                if(updateContact != null)
                {
                    updateContact.FirstName = contact.FirstName;
                    updateContact.LastName = contact.LastName;
                    updateContact.Phone = contact.Phone;
                    _data.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult DetailContact(int id)
        {
            DataContext _data = new DataContext();
            return View(_data.Contacts.Find(id));
        }

        public IActionResult DeleteContact(int id)
        {
            DataContext _data = new DataContext();
            Contact contact = _data.Contacts.Find(id);
            object data;
            if (contact == null)
            {
                data = new { message = "aucun contact avec cet id", type = "alert-danger" };
            }
            else
            {
                _data.Contacts.Remove(contact);
                _data.SaveChanges();
                data = new { Message = "suppression Ok", type = "alert-success" };
            }
            return RedirectToAction("Index", data);
        }
    }
}
