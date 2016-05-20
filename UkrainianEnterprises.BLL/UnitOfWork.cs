using System;
using System.Threading.Tasks;
using UkrainianEnterprises.BLL.Service;
using UkrainianEnterprises.Common.Entities;
using UkrainianEnterprises.Common.Service;
using UkrainianEnterprises.DAL;
using UkrainianEnterprises.DAL.Repositories;

namespace UkrainianEnterprises.BLL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private EnterpriseContext context = new EnterpriseContext();
        private ManagerBase<Enterprise> enterpriseManager;
        private ManagerBase<Location> locationManager;
        private ManagerBase<Department> departmentManager;
        private ManagerBase<Office> officeManager;
        private ManagerBase<Employee> employeeManager;
        private ManagerBase<Position> positionManager;
        private ManagerBase<Document> documentManager;
        private EnterpriseCategoryManager enterpriseCategoryManager;
        private UserManager userManager;
        private ExternalLoginManager loginManager;
        private RoleManager roleManager;

        public ManagerBase<Enterprise> EnterpriseManager
        {
            get
            {
                if(this.enterpriseManager == null)
                {
                    var repository = new Repository<Enterprise>(context);
                    this.enterpriseManager = new ManagerBase<Enterprise>(repository);
                }

                return this.enterpriseManager;
            }
        }

        public ManagerBase<Location> LocationManager
        {
            get
            {
                if (this.locationManager == null)
                {
                    var repository = new Repository<Location>(context);
                    this.locationManager = new ManagerBase<Location>(repository);
                }

                return this.locationManager;
            }
        }

        public ManagerBase<Department> DepartmentManager
        {
            get
            {
                if (this.departmentManager == null)
                {
                    var repository = new Repository<Department>(context);
                    this.departmentManager = new ManagerBase<Department>(repository);
                }

                return this.departmentManager;
            }
        }

        public ManagerBase<Office> OfficeManager
        {
            get
            {
                if (this.officeManager == null)
                {
                    var repository = new Repository<Office>(context);
                    this.officeManager = new ManagerBase<Office>(repository);
                }

                return this.officeManager;
            }
        }

        public ManagerBase<Employee> EmployeeManager
        {
            get
            {
                if (this.employeeManager == null)
                {
                    var repository = new Repository<Employee>(context);
                    this.employeeManager = new ManagerBase<Employee>(repository);
                }

                return this.employeeManager;
            }
        }

        public ManagerBase<Position> PositionManager
        {
            get
            {
                if (this.positionManager == null)
                {
                    var repository = new Repository<Position>(context);
                    this.positionManager = new ManagerBase<Position>(repository);
                }

                return this.positionManager;
            }
        }

        public ManagerBase<Document> DocumentManager
        {
            get
            {
                if (this.documentManager == null)
                {
                    var repository = new Repository<Document>(context);
                    this.documentManager = new ManagerBase<Document>(repository);
                }

                return this.documentManager;
            }
        }

        public EnterpriseCategoryManager EnterpriseCategoryManager
        {
            get
            {
                if (this.enterpriseCategoryManager == null)
                {
                    var repository = new Repository<EnterpriseCategory>(context);
                    this.enterpriseCategoryManager = new EnterpriseCategoryManager(repository);
                }

                return this.enterpriseCategoryManager;
            }
        }

        public UserManager UserManager
        {
            get
            {
                if (this.userManager == null)
                {
                    var repository = new UserRepository(context);
                    this.userManager = new UserManager(repository);
                }

                return this.userManager;
            }
        }

        public ExternalLoginManager LoginManager
        {
            get
            {
                if (this.loginManager == null)
                {
                    var repository = new ExternalLoginRepository(context);
                    this.loginManager = new ExternalLoginManager(repository);
                }

                return this.loginManager;
            }
        }

        public RoleManager RoleManager
        {
            get
            {
                if (this.roleManager == null)
                {
                    var repository = new RoleRepository(context);
                    this.roleManager = new RoleManager(repository);
                }

                return this.roleManager;
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
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
