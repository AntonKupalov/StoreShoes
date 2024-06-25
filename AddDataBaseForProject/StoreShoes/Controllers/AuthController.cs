using Microsoft.AspNetCore.Mvc;

namespace StoreShoes.Controllers;

public class AuthController: Controller
{
    public IActionResult Login()
    {
        return View();
    }
    
}