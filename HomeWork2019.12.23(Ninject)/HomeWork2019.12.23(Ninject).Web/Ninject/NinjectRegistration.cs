using HomeWork2019._12._23_1_.Models;
using HomeWork2019._12._23_1_.Services;
using HomeWork2019._12._23_Ninject_.AbstractModels;
using HomeWork2019._12._23_Ninject_.DataAccess;
using Ninject.Modules;

namespace HomeWork2019._12._23_Ninject_.Web.Ninject
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository<User>>().To<DbRepository<User>>().WithConstructorArgument("context", new UserContext());
            this.Bind<IRepository<User>>().To<DbRepository<User>>();
        }
    }
}