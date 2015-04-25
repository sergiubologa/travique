using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using PublicJournal.Bll.Bus;
using PublicJournal.Bll.Contracts;

namespace PublicJournal.Bll
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
           
        }
    }
}