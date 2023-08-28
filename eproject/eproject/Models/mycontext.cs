using Microsoft.EntityFrameworkCore;

namespace eproject.Models
{
    public class mycontext : DbContext
    {
        public mycontext(DbContextOptions<mycontext> options) : base(options)
        {
        }
        public DbSet<user> tbl_user { get; set; }
        public DbSet<friends> tbl_friends { get; set; }
      
        public DbSet<Friendrequest> tbl_friendrequest { get; set; }

    }
    
}
