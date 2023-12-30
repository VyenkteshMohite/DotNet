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


//all data is fetched
//url=http://localhost/5501/p
    [HttpGet]
    public IEnumerable<Hobby> Get()
    {
        CatalogManager mgr = new CatalogManager();
        List<Hobby> prod = mgr.GetAllProducts();
        return prod.ToArray();
    }

//here the perticular id data is fetched
//url=http://localhost/5501/p/id
    [Route("{id}")]
    [HttpGet]
    public  ActionResult<Hobby>  GetById(int id)
    {
        CatalogManager cm=new CatalogManager();
        
        Hobby h=cm.GetHobbyById(id);
        return h;
    }

//here

    
}
