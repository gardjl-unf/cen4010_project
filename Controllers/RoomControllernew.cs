using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OpenBed.Controllers
{
    public class RoomControllernew : Controller
    {
        // GET: RoomControllernew
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomControllernew/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomControllernew/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomControllernew/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomControllernew/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoomControllernew/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomControllernew/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomControllernew/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
