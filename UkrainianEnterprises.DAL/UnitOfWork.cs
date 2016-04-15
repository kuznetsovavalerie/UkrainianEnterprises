using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UkrainianEnterprises.BLL;

namespace UkrainianEnterprises.DAL
{
    public class UnitOfWork : IDisposable
    {
        private EnterpriseContext context = new EnterpriseContext();
        private Repository<Enterprise> enterpriseRepository;
        private Repository<Location> locationRepository;
        private Repository<Department> departmentRepository;
        private Repository<Office> officeRepository;
        private Repository<Employee> employeeRepository;
        private Repository<Document> documentRepository;

        public Repository<Enterprise> EnterpriseRepository
        {
            get
            {
                if(this.enterpriseRepository == null)
                {
                    this.enterpriseRepository = new Repository<Enterprise>(context);
                }

                return this.enterpriseRepository;
            }
        }

        public Repository<Location> LocationRepository
        {
            get
            {
                if (this.locationRepository == null)
                {
                    this.locationRepository = new Repository<Location>(context);
                }

                return this.locationRepository;
            }
        }

        public Repository<Department> DepartmentRepository
        {
            get
            {
                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new Repository<Department>(context);
                }

                return this.departmentRepository;
            }
        }

        public Repository<Office> OfficeRepository
        {
            get
            {
                if (this.officeRepository == null)
                {
                    this.officeRepository = new Repository<Office>(context);
                }

                return this.officeRepository;
            }
        }

        public Repository<Employee> EmployeeRepository
        {
            get
            {
                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new Repository<Employee>(context);
                }

                return this.employeeRepository;
            }
        }

        public Repository<Document> DocumentRepository
        {
            get
            {
                if (this.documentRepository == null)
                {
                    this.documentRepository = new Repository<Document>(context);
                }

                return this.documentRepository;
            }
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
