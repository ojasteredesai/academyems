using Academyems.CoreDbContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academyems.CoreDbContext
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
        public DbSet<Course> Course { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<BatchDetail> BatchDetail { get; set; }
    }
}
