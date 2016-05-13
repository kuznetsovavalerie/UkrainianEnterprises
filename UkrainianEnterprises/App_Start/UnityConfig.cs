using Microsoft.AspNet.Identity;
using Microsoft.Practices.Unity;
using System;
using System.Web.Mvc;
using UkrainianEnterprises.BLL;
using UkrainianEnterprises.Common.Service;
using UkrainianEnterprises.Controllers;
using UkrainianEnterprises.Identity;
using Unity.Mvc5;

namespace UkrainianEnterprises
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager(), new InjectionConstructor());
            container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
            container.RegisterType<RoleStore>(new TransientLifetimeManager());
            container.RegisterType<AccountController>(new InjectionFactory(c => new AccountController(new UserManager<IdentityUser, Guid>(new UserStore(new UnitOfWork())))));
            //container.register

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}