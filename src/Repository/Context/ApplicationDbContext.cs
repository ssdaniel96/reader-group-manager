using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Group> Groups { get; init; }
    public DbSet<Book> Books { get; init; }
    public DbSet<Member> Members { get; init; }
    public DbSet<ReadingPlan> ReadingPlans { get; init; }
    public DbSet<Reminder> Reminders { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}