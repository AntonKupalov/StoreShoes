using Microsoft.AspNetCore.Mvc;

namespace AddDataBaseForProject.Controllers;

public class AuthController: Controller
{
    public IActionResult Login()
    {
        return View();
    }
    
}