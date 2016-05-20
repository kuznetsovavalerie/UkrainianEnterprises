using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UkrainianEnterprises.Models.Employee;

namespace UkrainianEnterprises.Models
{
    public class NewEnterpriseViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public int CategoryID { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public bool IsContactPerson { get; set; }

        public NewLocationViewModel HeadOffice { get; set; }

        public NewEmployeeViewModel Director { get; set; }
    }
}