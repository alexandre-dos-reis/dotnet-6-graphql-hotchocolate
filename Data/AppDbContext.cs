using dotnet_graphql.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet_graphql.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}

