using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AddDataBaseForProject.Models;
using AddDataBaseForProject.Models.SneackersStore;

namespace AddDataBaseForProject.Controllers;

public class SneackersStoreController : Controller
{
    private List<ShoesModel> ShoesModels = new();
    private List<UserViewModel> UserViewModels = new();

    public IActionResult Store()
    {
        ShoesModels.Add(new ShoesModel
        {
            Name = "New Balance",
            Size = 43,
            Price = 400
        });

        ShoesModels.Add(new ShoesModel
        {
            Name = "Nike",
            Size = 43,
            Price = 400
        });

        return View(ShoesModels);
    }

    [HttpGet]
    public IActionResult AddUser()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddUser(AddUserViewModel addUserViewModel)
    {
        UserViewModels.Add(new UserViewModel
        {
            Name = addUserViewModel.Name,
            SurName = addUserViewModel.SurName,
            Age = addUserViewModel.Age
        });
        
        return RedirectToAction("Store");
    }
}