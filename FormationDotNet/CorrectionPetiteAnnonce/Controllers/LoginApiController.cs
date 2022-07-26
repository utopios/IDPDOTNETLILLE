using CorrectionPetiteAnnonce.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorrectionPetiteAnnonce.Controllers
{
    [Route("api/v1/login")]
    [ApiController]
    public class LoginApiController : ControllerBase
    {
        private ILogin _loginService;

        public LoginApiController(ILogin loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Post(UserDTO userDTO)
        {
            string token = _loginService.Login(userDTO);
            if(token != null)
            {
                return Ok(token);
            }
            else
            {
                return StatusCode(401);
            }
        }
    }
}
