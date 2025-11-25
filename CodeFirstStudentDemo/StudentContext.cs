using System.Data.Entity;

namespace CodeFirstStudentDemo
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentContext")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
