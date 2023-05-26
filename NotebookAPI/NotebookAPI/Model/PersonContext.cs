using Microsoft.EntityFrameworkCore;

namespace NotebookAPI.Model;

public class PersonContext : DbContext
{
    public DbSet<Person> People { get; set; }
    
    public PersonContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

}