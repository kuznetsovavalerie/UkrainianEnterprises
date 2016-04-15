﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkrainianEnterprises.BLL;

namespace UkrainianEnterprises.DAL
{
    public class EnterpriseContext : DbContext
    {
        public EnterpriseContext() : base("EnterpriseContext") { }

        public DbSet<Enterprise> Enterprises { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Office> Offices { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<EnterpriseType> EnterpriseTypes { get; set; }

        public DbSet<Education> Educations { get; set; }
    }
}
