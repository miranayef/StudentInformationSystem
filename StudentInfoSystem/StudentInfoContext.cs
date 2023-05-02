using System.Data.Entity;
using UserLogin;

namespace StudentInfoSystem_
{
    class StudentInfoContext : DbContext
    {
        public StudentInfoContext()
            : base(Properties.Settings.Default.DbConnect)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
