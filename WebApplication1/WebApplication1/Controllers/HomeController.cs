using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

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
    public IActionResult Index()
    {
        List<Student> _students = new List<Student>()
        {
            new Student() { Id = 1, Name = "John", Age = 20 },
            new Student() { Id = 2, Name = "Jane", Age = 22 },
            new Student() { Id = 3, Name = "Bob", Age = 21 }
        };
        string message = "Welcome to the Home Page";
        HomeVm homeVm = new HomeVm()
        {
            Students = _students,
            Message = message
        };

        return View(homeVm);
        // return View(_students);
    }  
    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}