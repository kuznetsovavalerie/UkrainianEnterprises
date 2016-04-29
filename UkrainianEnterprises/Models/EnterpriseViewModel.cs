using System.Collections.Generic;
using UkrainianEnterprises.App_Code;

namespace UkrainianEnterprises.Models
{
    public class EnterpriseViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string GoogleMapsAPIUrl
        {
            get
            {
                return string.Format(UIConfiguration.GoogleMapsAPIUrl, this.Address);
            }
        }

        public string Website { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public ICollection<LocationPreviewViewModel> TopLocations { get; set; }

        public ICollection<EmployeePreviewViewModel> TopEmployees { get; set; }
    }
}