using IAUFinal.BLL.Models;

using Microsoft.EntityFrameworkCore;




namespace IAUFinal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}





