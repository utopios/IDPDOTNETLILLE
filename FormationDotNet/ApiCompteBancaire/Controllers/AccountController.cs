using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Tools;
using BankEntityFrameWork.Repositories;

namespace ApiCompteBancaire.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private BaseRepository<Customer> _customerRepository;
        private BaseRepository<Account> _accountRepository;
        public AccountController(BaseRepository<Customer> customerRepository, BaseRepository<Account> accountRepository)
        {
            _customerRepository = customerRepository;
            _accountRepository = accountRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Account account)
        {
            return Ok(account);
        }
    }
}
