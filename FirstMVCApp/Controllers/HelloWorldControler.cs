using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldControler : Controller
    {
        private static List<DogViewModul> dogs = new List<DogViewModul>();
        public IActionResult Index()
        {
            DogViewModul doggo = new DogViewModul();


            return View(dogs);
        }


        public IActionResult Create()
        {
            var dogVm = new DogViewModul();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModul dogViewModul)
        {
            dogs.Add(dogViewModul);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who is there?";
        }

    }
}
