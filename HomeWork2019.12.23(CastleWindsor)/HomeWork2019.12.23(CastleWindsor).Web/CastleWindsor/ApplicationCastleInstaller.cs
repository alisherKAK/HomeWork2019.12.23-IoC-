using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using HomeWork2019._12._23_CastleWindsor_.AbstractModels;
using HomeWork2019._12._23_1_.Models;
using HomeWork2019._12._23_1_.Services;
using HomeWork2019._12._23_CastleWindsor_.DataAccess;

namespace HomeWork2019._12._23_CastleWindsor_.Web.CastleWindsor
{
    public class ApplicationCastleInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IRepository<User>>().ImplementedBy<DbRepository<User>>()
                .DynamicParameters( (r, k) => k["context"] = new UserContext() ));
            container.Register(Component.For<IRepository<User>>().ImplementedBy<JsonRepository<User>>());

            var controllers = Assembly.GetExecutingAssembly()
                .GetTypes().Where(x => x.BaseType == typeof(Controller)).ToList();
            foreach (var controller in controllers)
            {
                container.Register(Component.For(controller).LifestyleTransient());
            }
        }
    }
}