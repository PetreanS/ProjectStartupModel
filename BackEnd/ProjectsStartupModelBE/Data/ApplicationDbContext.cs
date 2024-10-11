using Microsoft.EntityFrameworkCore;

namespace ProjectsStartupModelBE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Here you must add the name of the classes which goes into the database. Switch "Example" with your class name
        //public DbSet<Example> Examples {get; set;} 
    }


}
