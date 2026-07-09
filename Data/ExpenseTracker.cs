using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker2.Data
{
    public static class SeedData
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));

            if (!await roleManager.RoleExistsAsync("Buyer"))
                await roleManager.CreateAsync(new IdentityRole("Buyer"));

            if (!await roleManager.RoleExistsAsync("Client"))
                await roleManager.CreateAsync(new IdentityRole("Client"));
        }

        public static async Task SeedAdminAsync(UserManager<IdentityUser> userManager)
        {
            string adminEmail = "admin@afribase.com";
            string adminPassword = "Admin@123"; // strong password!

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
