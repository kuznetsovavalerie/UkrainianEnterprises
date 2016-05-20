using System.Web.Mvc;
using UkrainianEnterprises.App_Code;
using UkrainianEnterprises.BLL;
using UkrainianEnterprises.Common.Entities;
using UkrainianEnterprises.Models.Employee;

namespace UkrainianEnterprises.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            using(var unitOfWork = new UnitOfWork())
            {
                var employee = unitOfWork.EmployeeManager.GetByID(id);

                if(employee == null)
                {
                    return RedirectToAction("Home");
                }

                var employeeViewModel = AutoMapperConfiguration.Mapper.Map<EmployeeProfileViewModel>(employee);

                return View("EmployeeProfile", employeeViewModel);
            }
        }

        // GET: Employee/Create
        [HttpPut]
        public ActionResult Create(NewEmployeeViewModel model)
        {
            using(var unitOfWork = new UnitOfWork())
            {
                var employee = AutoMapperConfiguration.Mapper.Map<Employee>(model);

                unitOfWork.EmployeeManager.Create(employee);
                unitOfWork.SaveChangesAsync();

                return View();
            }
        }

        /// <summary>
        /// Updates the employee position.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="newPositionId">The new position identifier.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateEmployeePosition(int employeeId, int newPositionId)
        {
            using(var unitOfWork = new UnitOfWork())
            {
                var employee = unitOfWork.EmployeeManager.GetByID(employeeId);
                var position = unitOfWork.PositionManager.GetByID(newPositionId);

                if (employee == null)
                {
                    return RedirectToAction("Home");
                }

                employee.Position = position;
                unitOfWork.EmployeeManager.Update(employee);
                unitOfWork.SaveChanges();

                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var employee = unitOfWork.EmployeeManager.GetByID(id);

                if (employee == null)
                {
                    return RedirectToAction("Home");
                }

                employee.Deleted = true;
                unitOfWork.EmployeeManager.Update(employee);
                unitOfWork.SaveChanges();

                return View();
            }
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Creates the position entity.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        [HttpPut]
        public JsonResult CreatePosition(NewPositionViewModel model)
        {
            using(var unitOfWork = new UnitOfWork())
            {
                var position = AutoMapperConfiguration.Mapper.Map<Position>(model);

                unitOfWork.PositionManager.Create(position);
                unitOfWork.SaveChangesAsync();

                return Json(position.ID);
            }
        }
    }
}
