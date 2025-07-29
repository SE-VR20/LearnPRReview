using Microsoft.EntityFrameworkCore;
using PRReviewProject.Models;

namespace PRReviewProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Staff> Staff { get; set; }
    }
}