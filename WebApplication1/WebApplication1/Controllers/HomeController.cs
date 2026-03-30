using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HomeController : Controller
 {
     // public IActionResult Index()
     // {
     //     return View();
     // }
     
    // GET:5276 /Home/Index
    // public JsonResult Index()
    // {
    //     var data=new
    //     {
    //         Message="Hello World",
    //         Time =DateTime.Now,
    //         StatusCode=200
    //         
    //     };
    //     return Json(data);
    // }
    // public ContentResult Index()
    // {
    //     return Content("Hello World");
    // }

    // public ViewResult Index()
    // {
    //     return View();
    // }

    // public FileResult Index()
    // {
    //     return  File ("~/image/download.jpeg", "image/jpeg");
    // }

    public IActionResult Index(int id)
    {
        return Content($"id:{id}");
    }
}