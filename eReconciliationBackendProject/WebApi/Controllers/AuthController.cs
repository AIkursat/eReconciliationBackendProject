using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("registersecondaccount")]
        public IActionResult RegisterSecondAccount(UserForRegister userForRegister)
        {
            var userExist = _authService.UserExists(userForRegister.Email);
            if (!userExist.Success)
            {
                return BadRequest(userExist.Message);
            }

            var registerResult = _authService.Register(userForRegister, userForRegister.Password);
            var result = _authService.CreateAccessToken(registerResult.Data, companyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            /*
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }
            */
            return BadRequest(registerResult.Message);
        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegister userForRegister, Company company)
        {
            // contrpl the use if that exists

            var userExist = _authService.UserExists(userForRegister.Email);
            if (!userExist.Success)
            {
                return BadRequest(userExist.Message);
            }

            // control the company if that exist

            var companyExist =     


            var registerResult = _authService.Register(userForRegister, userForRegister.Password);       
            var result = _authService.CreateAccessToken(registerResult.Data, companyId);
            if (result.Success)
            {
                return Ok(result.Data);
            }        
            /*
            if (registerResult.Success)
            {
                return Ok(registerResult);
            }
            */
            return BadRequest(registerResult.Message);
        }

        [HttpPost("login")]

        public IActionResult Login(UserForLogin userForLogin)
        {
            var userToLogin = _authService.Login(userForLogin);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            var result = _authService.CreateAccessToken(userToLogin.Data, 0);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(userToLogin.Message);
        }

    }
}
