using UkrainianEnterprises.Common;

namespace UkrainianEnterprises.Models
{
    public class NewLocationViewModel
    {
        public string Title { get; set; }

        public string Region { get; set; }

        public string Locality { get; set; }

        public string Street { get; set; }

        public string Building { get; set; }

        public string Housing { get; set; }

        public string PhoneNumber { get; set; }

        public LocationLevel Level { get; set; }
    }
}