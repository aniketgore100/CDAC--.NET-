using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {

            List<Employee> list = new List<Employee>();
            list.Add(new Employee { EmpNo=1, Name="sanket", DeptNo=10, Basic = 12345 });
            list.Add(new Employee { EmpNo=2, Name="kishore", DeptNo=10, Basic = 12345 });
            list.Add(new Employee { EmpNo=3, Name="manya", DeptNo=10, Basic = 12345 });
            return View(list);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id=1)
        {

            Employee obj = new Employee();
            obj.EmpNo  = id;
            obj.Name = "sanket";
            obj.Basic = 12345;
            obj.DeptNo = 10;

            return View(obj);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee obj)
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

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee obj = new Employee();
            obj.EmpNo  = id;
            obj.Name = "kishore";
            obj.Basic = 12345;
            obj.DeptNo = 10;

            return View(obj);
           
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
            Employee obj = new Employee();
            obj.EmpNo  = id;
            obj.Name = "manya";
            obj.Basic = 12345;
            obj.DeptNo = 10;

            return View(obj);
           
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
