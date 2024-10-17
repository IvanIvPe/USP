namespace USP.API.Services;

public class ProductService : IProductService
{
    public async Task<string>Get() => "Ivan";

    public async Task<string> Create() => "Created!";
}