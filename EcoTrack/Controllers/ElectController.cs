using EcoTrack.Data;
using Microsoft.AspNetCore.Mvc;

namespace EcoTrack.Controllers
{
    public class ElectController : Controller
    {
        private readonly ApplicationDbContext context;
        public ElectController(ApplicationDbContext context) 
        {
            this.context = context;
        }
        public IActionResult Analysis()
        {
            var electric = context.electrates.ToList();
            return View(electric);
        }
    }
}
