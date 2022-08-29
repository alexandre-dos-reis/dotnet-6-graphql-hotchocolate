using dotnet_graphql.Data;
using dotnet_graphql.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet_graphql.GraphQL;

public class Query
{
    public IQueryable<Product> GetProduct(AppDbContext ctx)
    {
        return ctx.Products.Include(p => p.Category);
    }

    public IQueryable<Category> GetCategory(AppDbContext ctx)
    {
        return ctx.Categories.Include(c => c.Products);
    }
}