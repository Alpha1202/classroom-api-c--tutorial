using Microsoft.EntityFrameworkCore;
using classroom_api_c__tutorial.Models;

namespace classroom_api_c__tutorial.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
