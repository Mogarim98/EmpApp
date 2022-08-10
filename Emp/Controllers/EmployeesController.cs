using Emp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Emp.Models;

namespace Emp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicaeionDbContext _contextDB;
        public EmployeesController(ApplicaeionDbContext context)
        {
            _contextDB = context;
        }

        // GET: EmployeesController
        public ActionResult Index()
        {
            var Result =_contextDB.Employees.Include(x=>x.Department)
                .OrderBy(x=>x.EmployeeName).ToList();
            return View(Result);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
          ViewBag.Departments =  _contextDB.Departments.OrderBy(x => x.DepartmentName).ToList();
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
    //  _contextDB.Add(collection);
                _contextDB.Add(collection);
                _contextDB.SaveChanges();
                return RedirectToAction(nameof(Index));

                }

                ViewBag.Departments = _contextDB.Departments.OrderBy(x => x.DepartmentName).ToList();

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
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

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
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
