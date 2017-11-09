using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using Absa.Bll.Interfaces.Services.Customers;
using Absa.Dal.Interfaces.Repositories;
using Absa.Dal.Repositories.Customers;
using Absa.Bll.Services.Customers;

namespace Absa.Portal
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
 
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            // Register Services
            container.RegisterType<ICustomerService, CustomerService>();

            //Register Repositories
            container.RegisterType<ICustomerRepository, CustomerRepository>();
        }
    }
}