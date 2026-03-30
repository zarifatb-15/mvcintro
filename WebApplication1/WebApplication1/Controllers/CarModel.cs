using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CarModel : Controller
{
    // GET
    
    private List<Models.CarModel> _carModels = new List<Models.CarModel>
    {
        new Models.CarModel{Id=1,Name="X5",MarkaId=1},
        new Models.CarModel{Id=2,Name="C200",MarkaId=2},
        new Models.CarModel{Id=3,Name="A4",MarkaId=3}
    };
    public IActionResult Index(int markaId)
    {
        if(_carModels.Any(x=>x.MarkaId==markaId))
        {
            var carModels = _carModels.Where(x => x.MarkaId == markaId).ToList();
            return View(carModels);
        }
        return View(new List<Models.CarModel>());
    }
}