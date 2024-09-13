namespace Ec2WebApi.Models
{
    public record CreateProductRequest(string Name, string Description, decimal Price);
}
