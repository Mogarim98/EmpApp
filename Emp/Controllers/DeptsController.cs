using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emp.Controllers
{
    public class DeptsController : Controller
    {
        // GET: DeptsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DeptsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeptsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeptsController/Create
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

        // GET: DeptsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeptsController/Edit/5
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

        // GET: DeptsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeptsController/Delete/5
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
