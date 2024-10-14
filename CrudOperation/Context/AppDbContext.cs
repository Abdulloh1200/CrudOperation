using CrudOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Context;

public class AppDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Subject> Subjects { get; set; }

    string connectionString = "Host=localhost; Port=5432;" +
        "Database=postgres; Username=postgres; Password=1200;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Subject)
            .WithMany(s => s.Persons)
            .HasForeignKey(p => p.subject_id);
    }
}
