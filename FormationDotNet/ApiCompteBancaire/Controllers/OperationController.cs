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
        public IActionResult Post([FromBody] OperationDTO operationDTO, [FromRoute]int id)
        {
            Account account = _accountRepository.Find(a => a.AccountNumber == id);
            if (account == null)
                return NotFound();
            Operation operation = new Operation(operationDTO.amount);
            if(operationDTO.type == "deposit")
            {
                if(account.Deposit(operation) && _accountRepository.Update())
                {
                    return Ok();
                }
                return StatusCode(500);
            }else if(operationDTO.type == "withDraw") 
            {
                if (account.WithDraw(operation) && _accountRepository.Update())
                {
                    return Ok();
                }
                return StatusCode(500);
            }
            return StatusCode(500);
        }
    }

    public record OperationDTO(decimal amount, string type);
}
