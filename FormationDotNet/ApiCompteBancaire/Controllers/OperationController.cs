using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCompteBancaire.Controllers
{
    [Route("api/v1/account/{id}/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {        
        private BaseRepository<Account> _accountRepository;
        public OperationController( BaseRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] OperationDTO operation, [FromRoute]int id)
        {
            return Ok();
        }
    }

    public record OperationDTO(decimal amount, string type);
}
