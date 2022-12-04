using Microsoft.AspNetCore.Mvc;

namespace OpenBed.Controllers
{
    public class ShelterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
