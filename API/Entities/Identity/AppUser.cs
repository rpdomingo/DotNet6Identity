using Microsoft.AspNetCore.Identity;

namespace API.Entities.Identity
{ 
    public class AppUser : IdentityUser
    {
         public string DisplayName { get; set; }
    }
}