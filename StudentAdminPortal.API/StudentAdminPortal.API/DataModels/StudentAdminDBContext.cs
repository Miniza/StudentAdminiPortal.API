using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminDBContext : DbContext
    {
        public StudentAdminDBContext(DbContextOptions<StudentAdminDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Student{ get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
