using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UkrainianEnterprises.Models
{
    public class NewEmployeeViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public int PositionID { get; set; }

        public int EnterpriseID { get; set; }

        public int LocationID { get; set; }

        public int OfficeID { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Education { get; set; }
    }
}