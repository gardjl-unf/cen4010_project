using Microsoft.AspNetCore.Mvc;

namespace OpenBed.Models
{
    public class EFRoomRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
