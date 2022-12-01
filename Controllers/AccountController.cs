using Microsoft.AspNetCore.Mvc;

namespace cen4010_project.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
