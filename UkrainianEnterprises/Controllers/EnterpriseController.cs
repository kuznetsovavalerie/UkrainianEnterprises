using System.Linq;
using System.Web.Mvc;
using UkrainianEnterprises.BLL;
using UkrainianEnterprises.Common;
using UkrainianEnterprises.Common.Entities;
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

        public ActionResult Create()
        {
            var model = new NewEnterpriseViewModel()
            {
                HeadOffice = new NewLocationViewModel()
                {
                    Level = LocationLevel.HeadOffice
                }
            };

            return View();
        }

        /// <summary>
        /// Creates the specified enterprise with common information.
        /// </summary>
        /// <param name="enterprise">The enterprise.</param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Create(NewEnterpriseViewModel enterprise)
        {
            var enterpriseEntity = AutoMapperConfiguration.Mapper.Map<NewEnterpriseViewModel, Enterprise>(enterprise);

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    if(enterprise.CategoryID <= 0)
                    {
                        var category = new EnterpriseCategory() { Title = enterprise.Category };

                        unitOfWork.EnterpriseCategoryManager.Create(category);
                        unitOfWork.Save();

                        enterpriseEntity.Category = category;
                    }

                    unitOfWork.EnterpriseManager.Create(enterpriseEntity);
                    unitOfWork.Save();

                    var nextAction = enterprise.IsContactPerson ? "ContactRepresentative" : "";

                    return RedirectToAction(nextAction, new { enterpriseID = enterpriseEntity.ID });
                }
                catch
                {

                }
            }

            return RedirectToAction("");
        }

        [HttpPut]
        public void AddHeadOffice()
        {

        }

        public ActionResult Complete(int enterpriseID)
        {
            return View();
        }
    }
}