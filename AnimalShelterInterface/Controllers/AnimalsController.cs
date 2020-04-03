using AnimalShelterInterface.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AnimalShelterInterface.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

    public ActionResult Details(int id)
    {
      Animal animal = Animal.GetAnimal(id);
      return View(animal);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      Animal.CreateAnimal(animal);
      return RedirectToAction("Index");
    }

    public ActionResult Update(int id)
    {
      Animal animal = Animal.GetAnimal(id);
      return View(animal);
    }

    [HttpPost]
    public ActionResult Update(Animal animal)
    {
      Animal.EditAnimal(animal);
      return RedirectToAction("Details", new {id = animal.AnimalId});
    }

    public ActionResult Delete(int id)
    {
      Animal animal = Animal.GetAnimal(id);
      return View(animal);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Animal.DeleteAnimal(id);
      return RedirectToAction("Index");
    }
  }
}