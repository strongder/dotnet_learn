using Microsoft.AspNetCore.Identity;
using Product_project.DTOs;

namespace Product_project.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginDto dto);

        Task<IdentityResult> Register(RegisterDto dto);
    }
}
