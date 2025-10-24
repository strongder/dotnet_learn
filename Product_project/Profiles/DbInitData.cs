namespace Product_project.Profiles
{
    using Microsoft.AspNetCore.Identity;
    using Product_project.Models;

    public static class DbInitData
    {
        public static async Task SeedAsync(UserManager<User> userManager,
                                           RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            if (!await roleManager.RoleExistsAsync("Employee"))
                await roleManager.CreateAsync(new IdentityRole("Employee"));

            if (await userManager.FindByEmailAsync("admin@example.com") == null)
            {
                var admin = new User
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    FullName = "Administrator"
                };
                await userManager.CreateAsync(admin, "Admin@123");
                await userManager.AddToRoleAsync(admin, "Admin");
            }

            if (await userManager.FindByEmailAsync("employee1@example.com") == null)
            {
                var employee = new User
                {
                    UserName = "employee1@example.com",
                    Email = "employee1@example.com",
                    FullName = "Employee 1"
                };
                await userManager.CreateAsync(employee, "Admin@123");
                await userManager.AddToRoleAsync(employee, "Employee");
            }
        }
    }

}
