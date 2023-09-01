using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebEmpty.Models;
using static WebEmpty.Models.Repository;

namespace WebEmpty.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;   
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Name = new SelectList(repository.Products.Select(c => c.Name).Distinct());
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            repository.AddProduct(p);
            return RedirectToAction("Index");
        }
        public ViewResult Edit()
        {
            ViewBag.Quantity = new SelectList(repository.Products
                                              .Select(c => c.Quantity).Distinct());
            return View("Create");
        }
    }
}
