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
            Account account = _accountRepository.Find(a => a.AccountNumber == id);
            if (account == null)
                return NotFound();
            else
                return Ok(new ResponseAccountDTO(new CustomerDTO(account.Customer.FirstName, account.Customer.LastName, account.Customer.Phone), account.AccountNumber, account.TotalAmount, account.Operations));
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountDTO accountDTO)
        {
            Customer customer = new Customer()
            {
                FirstName = accountDTO.Customer.FirstName,
                LastName = accountDTO.Customer.LastName,
                Phone = accountDTO.Customer.Phone
            };
            Account account = new Account(customer, Bank.CreateRandomAccountNumber(5));
            _accountRepository.Create(account);
            return Ok(new ResponseAccountDTO(accountDTO.Customer, account.AccountNumber, account.TotalAmount, account.Operations));
        }
    }
    public record CustomerDTO(string FirstName, string LastName, string Phone);
    public record AccountDTO(CustomerDTO Customer);
    public record ResponseAccountDTO(CustomerDTO Customer, int NumberAccount, decimal TotalAmount = 0, List<Operation> operations = null);
}
