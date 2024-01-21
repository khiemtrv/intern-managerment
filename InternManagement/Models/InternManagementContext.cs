using Microsoft.EntityFrameworkCore;

namespace InternManagement.Models
{
    public class InternManagementContext : DbContext
    {
        public InternManagementContext(DbContextOptions options) : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }
    }
}
