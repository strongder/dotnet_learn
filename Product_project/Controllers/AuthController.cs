using Microsoft.AspNetCore.Mvc;
using Product_project.DTOs;
using Product_project.Services.AuthService;

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
        public async Task<ActionResult<string>> Login([FromBody] LoginDto loginDto)
        {
            var token = await _auth.LoginAsync(loginDto);
            if (string.IsNullOrEmpty(token))
                return Unauthorized("Invalid username or password");

            return Ok(new {token = token});
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            var result = await _auth.Register(dto);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User registered successfully");
        }

    }
}
