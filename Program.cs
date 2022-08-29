using dotnet_graphql.Data;
using dotnet_graphql.GraphQL;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AppDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<AppDbContext>(DbContextKind.Pooled)
    .InitializeOnStartup()
    .AddQueryType<Query>()
    ;

WebApplication app = builder.Build();

app.UseRouting();

app.MapGraphQL("/graphql");
app.MapGraphQLVoyager("/ui/voyager");

app.Run();