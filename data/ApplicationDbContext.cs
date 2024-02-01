using Microsoft.EntityFrameworkCore;
using studentWebPage.Models.Entities;

namespace studentWebPage.data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

    }

  
}
