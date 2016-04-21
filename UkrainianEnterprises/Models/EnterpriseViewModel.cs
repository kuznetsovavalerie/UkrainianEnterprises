using System.Collections.Generic;

namespace UkrainianEnterprises.Models
{
    public class EnterpriseViewModel
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<LocationPreviewViewModel> TopLocations { get; set; }

        public ICollection<EmployeePreviewViewModel> TopEmployees { get; set; }
    }
}