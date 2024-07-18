using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Group> Groups { get; set; }
    
}