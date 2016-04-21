using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UkrainianEnterprises.Models
{
    public class NewEnterpriseViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int TypeID { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}