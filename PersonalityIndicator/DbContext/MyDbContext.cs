using System.Data.Entity;
using PersonalityIndicator.Models;

namespace PersonalityIndicator.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }

        public DbSet<Question> Customers { get; set; }
        public DbSet<Answer> Movies { get; set; }
    }
}