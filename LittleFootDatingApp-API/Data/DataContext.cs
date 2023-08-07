using Microsoft.EntityFrameworkCore;

namespace LittleFootDatingApp_API
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users {get; set;}
    }
}
