using academyems.dbcontext.Entities;
using Microsoft.EntityFrameworkCore;

namespace academyems.dbcontext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserType> UserType { get; set; }
        public DbSet<CourseType> CourseType { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }
    }
}
