using AnnuaireEntityFrameWorkCore.Classes;
using AnnuaireEntityFrameWorkCore.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiContact.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private DataContext _dataContext;

        public ContactController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataContext.Contacts.ToList());
        }

        [HttpGet("{phone}")]
        public IActionResult Get(string phone)
        {
            Contact contact = _dataContext.Contacts.FirstOrDefault(c => c.Phone== phone);
            if (contact != null)
                return Ok(contact);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Contact contact)
        {
            _dataContext.Contacts.Add(contact);
            if(_dataContext.SaveChanges() > 0)
            {
                return Ok(contact);
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Contact contact = _dataContext.Contacts.Find(id);
            if (contact != null)
            {
                _dataContext.Contacts.Remove(contact);
                if (_dataContext.SaveChanges() > 0)
                {
                    return Ok(new {message = "delete ok"});
                }
                else
                {
                    return StatusCode(500);
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
