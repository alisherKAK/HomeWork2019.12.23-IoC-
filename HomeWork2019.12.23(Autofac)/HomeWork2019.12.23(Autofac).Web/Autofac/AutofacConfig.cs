using Autofac;
using Autofac.Integration.Mvc;
using HomeWork2019._12._23_1_.Models;
using HomeWork2019._12._23_1_.Services;
using HomeWork2019._12._23_Autofac_.AbstractModels;
using HomeWork2019._12._23_Autofac_.DataAccess;
using System.Web.Mvc;

namespace HomeWork2019._12._23_Autofac_.Web.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<DbRepository<User>>().As<IRepository<User>>().WithParameter("context", new UserContext());
            builder.RegisterType<JsonRepository<User>>().As<IRepository<User>>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}