using EMSAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSAPI.Data
{
    public class EMSAPIDbContext : DbContext
    {
        public EMSAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
