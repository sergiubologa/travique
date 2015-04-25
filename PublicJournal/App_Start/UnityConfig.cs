using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using PublicJournal.Bll.Contracts;
using PublicJournal.Bll.Bus;
using System.Web.Http;
using PublicJournal.Dal;
using PublicJournal.Dal.Contracts;
using PublicJournal.Dal.Dao;

namespace PublicJournal
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IObjectContext, PublicJournalDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserBus, UserBus>();
            container.RegisterType<IUserDao, UserDao>();
            container.RegisterType<IEventBus, EventBus>();
            container.RegisterType<IEventDao, EventDao>();
            container.RegisterType<ICategoryBus, CategoryBus>();
            container.RegisterType<ICategoryDao, CategoryDao>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }
    }
}