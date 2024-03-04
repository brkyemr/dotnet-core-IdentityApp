using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Models
{
    public class IdentityContext : IdentityDbContext<IdentityUser>  //IdentityUser User bilgilerini tutacak tablo yapılarını barındırır.
    {  //DBContext de olabilirdi fakat daha üst seviyede auth yapılarını da barındıran bir context oluyor.
        public IdentityContext(DbContextOptions<IdentityContext> options):base(options)
        {
             
        }
    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["IdentityDatabase"].ConnectionString);
    }*/
    }
}