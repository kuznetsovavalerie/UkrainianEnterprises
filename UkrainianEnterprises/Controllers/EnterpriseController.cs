using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UkrainianEnterprises.BLL;
using UkrainianEnterprises.Model;
using UkrainianEnterprises.Models;

namespace UkrainianEnterprises.Controllers
{
    public class EnterpriseController : Controller
    {
        // GET: Enterprise
        public ActionResult Index()
        {

            //var enterpriseQuery = unitOfWork.EnterpriseRepository.Get();
            using (var unitOfWork = new UnitOfWork())
            {
                var enterprises = from e in unitOfWork.EnterpriseManager.GetAll()
                                  select AutoMapperConfiguration.Mapper.Map<Enterprise, EnterpriseViewModel>(e);

                //var enterpriseViewModels = 

                //var documents = unitOfWork.DocumentManager.Get();
                //var employees = unitOfWork.EmployeeRepository.Get();

                return View("EnterpriseList", enterprises);
            }
        }

        /// <summary>
        /// Views the specified enterprise identifier.
        /// </summary>
        /// <param name="enterpriseId">The enterprise identifier.</param>
        /// <returns></returns>
        public ActionResult View(int enterpriseId)
        {
            return View();
        }

        public ActionResult Create(NewEnterpriseViewModel enterprise)
        {
            var enterpriseEntity = AutoMapperConfiguration.Mapper.Map<NewEnterpriseViewModel, Enterprise>(enterprise);

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    unitOfWork.EnterpriseManager.Create(enterpriseEntity);
                }
                catch
                {

                }
            }

            return RedirectToAction("");
        }
    }
}