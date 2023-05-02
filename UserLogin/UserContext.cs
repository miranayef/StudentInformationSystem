using System.Data.Entity;

namespace UserLogin
{
    class UserContext : DbContext
    {
        public UserContext()
            : base(Properties.Settings.Default.DbConnect)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
