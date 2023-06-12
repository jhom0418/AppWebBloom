using Microsoft.AspNetCore.Mvc;


namespace AppWebBloom.Controllers;
public class HomeController : Controller{

    public IActionResult Index(){
        return View();
    }
    
}