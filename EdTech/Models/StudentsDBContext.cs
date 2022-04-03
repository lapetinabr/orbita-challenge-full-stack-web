using Microsoft.EntityFrameworkCore;

namespace EdTech.Models
{
    public class StudentsDBContext:DbContext
    {
        public StudentsDBContext(DbContextOptions<StudentsDBContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }
    }
}
