using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MovieMVC.Models;
using System.Net.Mail;


public class ProductsController : Controller
{
    public static List<ProductViewModel> products = new List<ProductViewModel>();
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Show(string productName, int noOfTimes)
    {
        ViewData["name"] = productName;
        ViewData["noOfTimes"] = noOfTimes;
        return View();
    }
    public IActionResult Details()
    {
        return View();
    }
   
    //}
    public ActionResult Create()
    {
        return View(new ProductViewModel());
    }
    [HttpPost]
    public ActionResult Create(ProductViewModel p)
    {
        try
        {
            if(p.Name == null)
            {
                throw new productsException();
            }

        }catch (productsException ex)
        {
            //ViewData["error"] = ex.Message;
            return Content(ex.Message);
        }
        /*return Json(p)*/;
        return Content(p.Id+"\t"+p.Name+"\t"+p.Price);
    }
    //void AddProductTOList(string pid, string pname, string pprice)
    //{
    //    products.add(new Product(int.Parse(pid), pname, decimal.Parse(pprice));
    //}
    public IActionResult Edit()
    {
        return View();
    }
    public IActionResult Delete()
    {
        return View();
    }
}
//public string Welcome()
//{
//    return "This is the Welcome action method...";
//}
//public string Welcome(string name)
//{
//    return "Good Morning, " + name;
//}

/*
*  public string Index()
    {
        return "This is returned form Index method..";
    }
    public string Details()
    {
        return "Details method working";
    }
    public string Create()
    {
        return "Create method working";
    }
    public string Edit()
    {
        return "Edit method working";
    }
    public string Delete()
    {
        return "Oopss, Item is deleted";
    }
*/
