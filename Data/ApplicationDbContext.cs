using EntityExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityExample.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<StudentModel> Students { get; set; }
    }
}
