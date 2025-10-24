using Microsoft.AspNetCore.Mvc;
using Product_project.DTOs;
using Product_project.Services.Interfaces;

namespace Product_project.Controllers
{
    [Controller]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("login")]
        public async Task<string> Login([FromBody] LoginDto loginDto)
        {
            var token = await _auth.LoginAsync(loginDto);
            return token;
        }
    }
}
