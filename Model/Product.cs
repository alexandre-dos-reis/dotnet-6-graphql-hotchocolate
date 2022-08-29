using System.ComponentModel.DataAnnotations;

namespace dotnet_graphql.Model;

[GraphQLDescription("Représente un produit de la boutique")]
public class Product
{
    [GraphQLDescription("Id unique")]
    public int Id { get; set; }

    [StringLength(200)]
    [GraphQLDescription("intitulé du produit")]
    public string? Name { get; set; }

    [GraphQLDescription("Prix en euros")]
    public int Price { get; set; }

    public Category Category { get; set; } = new Category();
}

