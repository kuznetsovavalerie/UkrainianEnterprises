﻿using System.Collections.Generic;

namespace UkrainianEnterprises.Common
{
    public class Enterprise
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public EnterpriseCategory Category { get; set; }

        public string Website { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public ICollection<Location> Locations { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Document> Documents { get; set; }
    }
}
