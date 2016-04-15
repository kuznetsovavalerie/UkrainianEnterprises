using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UkrainianEnterprises.BLL;
using UkrainianEnterprises.DAL;
using UkrainianEnterprises.Models;

namespace UkrainianEnterprises.Controllers
{
    public class EnterpriseController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        // GET: Enterprise
        public ActionResult Index()
        {
            //var enterpriseQuery = unitOfWork.EnterpriseRepository.Get();
            var enterprises = from e in unitOfWork.EnterpriseRepository.Get()
                              select new EnterpriseViewModel() { ID = e.ID, Title = e.Title };
            
            var documents = unitOfWork.DocumentRepository.Get();

            //var employees = unitOfWork.EmployeeRepository.Get();

            return View("EnterpriseList", enterprises);
        }


    }
}