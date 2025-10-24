using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Product_project.Data;
using Product_project.DTOs;
using Product_project.Models;
using Product_project.Services.Interfaces;

namespace Product_project.Services.Implements
{
    public class UserService : IUserService
    {
        public Task<IdentityResult> AddToRoleAsync(User user, string role)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateUserAsync(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<string>> GetRolesAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
