// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
// using IdentityServer.Models;

// namespace IdentityServer.Data
// {
//     public class AspNetIdentityDbContext : IdentityDbContext<AspNetUser>
//     {
//         public AspNetIdentityDbContext(DbContextOptions<AspNetIdentityDbContext> options)
//             : base(options)
//         {
//         }

//         protected override void OnModelCreating(ModelBuilder builder)
//         {
//             base.OnModelCreating(builder);
//             // Customize the ASP.NET Identity model and override the defaults if needed.
//             // For example, you can rename the ASP.NET Identity table names and more.
//             // Add your customizations after calling base.OnModelCreating(builder);
//         }
//     }
// }


using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityServer.Models;

namespace IdentityServer.Data {
    public class AspNetIdentityDbContext : IdentityDbContext<AspNetUser> {

        public AspNetIdentityDbContext(DbContextOptions<AspNetIdentityDbContext> options)
            : base(options)
        {
        }
    }
}