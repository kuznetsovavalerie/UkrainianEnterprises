using System.Data.Entity;
using UkrainianEnterprises.Common;
using UkrainianEnterprises.DAL.EntityFrameworkConfiguration;

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

        public DbSet<EnterpriseCategory> EnterpriseTypes { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<ExternalLogin> Logins { get; set; }

        public DbSet<Claim> Claims { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClaimConfiguration());
            modelBuilder.Configurations.Add(new ExternalLoginConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}
