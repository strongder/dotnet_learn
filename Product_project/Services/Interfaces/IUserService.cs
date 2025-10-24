using Microsoft.AspNetCore.Identity;
using Product_project.DTOs;
using Product_project.Models;

namespace Product_project.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByIdAsync(string id);
        Task<IList<string>> GetRolesAsync(User user);
        Task<IdentityResult> CreateUserAsync(User user, string password);
        Task<IdentityResult> AddToRoleAsync(User user, string role);

    }
}
