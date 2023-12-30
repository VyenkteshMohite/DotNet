using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;
namespace ReactWithWebAPIApp.Controllers;

[ApiController]
[Route("[controller]")]
public class PController : ControllerBase
{
    private readonly ILogger<PController> _logger;
    public PController(ILogger<PController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Hobby> Get()
    {
        CatalogManager mgr = new CatalogManager();
        List<Hobby> prod = mgr.GetAllProducts();
        return prod.ToArray();
    }

    
}
