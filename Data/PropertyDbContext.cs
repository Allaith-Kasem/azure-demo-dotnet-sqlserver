using Microsoft.EntityFrameworkCore;
using PropertyDemo.Models;

namespace PropertyDemo.Data;

public class PropertyDbContext : DbContext
{
    public PropertyDbContext(
        DbContextOptions<PropertyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Property> Properties => Set<Property>();
}
