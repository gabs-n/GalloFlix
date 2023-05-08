using GalloFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;
    
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Roles - Perfis de Usuario 

        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Moderador",
                NormalizedName = "MODERADOR"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Usuário",
                NormalizedName = "USUARIO"
            }

        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion       
        
        #region Popular AppUser - Usuários 
            List<AppUser> users = new()
            {
                new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Gabriela Ferreira Nicoleti",
                    DateOfBirth = DateTime.Parse("19/07/2005"),
                    Email = "nicoletigabriela2@gmail.com",
                    NormalizedEmail = "NICOLETIGABRIELA2@GMAIL.COM",
                    UserName = "Bibiela",
                    NormalizedUserName = "BIBIELA",
                    LockoutEnabled = false,
                    PhoneNumber = "14996664815",
                    PhoneNumberConfirmed = true,
                    EmailConfirmed = true,
                    ProfilePicture = "/img/users/avatar.png",
                }
            };
        foreach (var user in users)
        {
            PasswordHasher<AppUser> pass  = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<AppUser>().HasData(users);
        #endregion
    
        #region Populate UserRole - Usuário com perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() 
            {
                UserId = users[0].Id,
                RoleId = roles[0].Id 
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }

}