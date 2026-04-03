using WebApplication1.Models;

namespace WebApplication1.ViewModels;

public class HomeVm
{
    public List<Student> Students { get; set; } = null!;
    
    public string Message { get; set; } = null!;
}