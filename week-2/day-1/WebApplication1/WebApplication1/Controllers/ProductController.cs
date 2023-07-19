using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;


[Route("products")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {

        return Content("get method");
    }
    [HttpGet("{id}")]
    public IActionResult Details(int id)
    {
        var product = $"<h1>Product with this id is unavaliabe<h1>";
        
            return Content(product);
    }
}
