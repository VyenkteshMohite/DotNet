using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;
namespace ReactWithWebAPIApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Hobby> Get()
    {
        CatalogManager mgr = new CatalogManager();
        List<Hobby> products = mgr.GetAllProducts();
        return products.ToArray();
    }

    
}
