using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StoreShoes.Models;
using StoreShoes.DbStuff.Repositories;
using StoreShoes.Models.SneackersStore;

namespace StoreShoes.Controllers;

public class SneackersStoreController : Controller
{
    private ShoesRepositories _shoesRepositories;
    private List<ShoesModel> ShoesModels = new();
    private List<UserViewModel> UserViewModels = new();

    public SneackersStoreController(ShoesRepositories shoesRepositories)
    {
        _shoesRepositories = shoesRepositories;
    }

    public IActionResult Store()
    {
        var dbModel = _shoesRepositories.GetAll();

        var viewModel = dbModel.Select(dbModel =>
            new ShoesModel()
            {
                Id = dbModel.Id,
                Name = dbModel.Name,
                Size = dbModel.Size,
                Price = dbModel.Price
            }).ToList();
            
        
        
        return View(viewModel);
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