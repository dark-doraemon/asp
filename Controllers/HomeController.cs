using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using WebEmpty.Models;

namespace WebEmpty.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repo;
        public HomeController(IRepository repository)
        {
            this.repo = repository;
        }
        public IActionResult Index(int id = 1)
        {
            return View(repo[id]);
        }
    }
}
