using System.Collections.Generic;
using UkrainianEnterprises.BLL.Enums;

namespace UkrainianEnterprises.BLL
{
    public class Location
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public LocationLevel Level { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}