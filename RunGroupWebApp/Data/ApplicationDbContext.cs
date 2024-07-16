using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>//burda da indentity formasinda miras aliriq
                                                                  //eger App ucun bizde Role da olsaydi, vergul qoyub
                                                                  //<AppUser>'in yaninda onu da yazardiq ama yoxdu
    {
        //asagidaki code'un basqa bir menasida model'de olan butun classlarda melumatin goturulmesi,
        //base mene gore o menani verir
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Club> Clubs { get; set; }
    }
}
