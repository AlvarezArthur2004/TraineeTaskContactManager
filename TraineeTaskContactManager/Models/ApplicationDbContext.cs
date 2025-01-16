using Microsoft.EntityFrameworkCore;

namespace TraineeTaskContactManager.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalInfo> PersonalInfo { get; set; }
    }
}
