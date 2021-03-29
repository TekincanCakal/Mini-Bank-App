using MiniBank.Business.Abstract;
using MiniBank.Business.Concrete;
using MiniBank.DataAcces.Abstract;
using MiniBank.DataAcces.Concrete.EntityFramework;
using Ninject.Modules;

namespace MiniBank.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            Bind<IBankAccountService>().To<BankAccountManager>().InSingletonScope();
            Bind<IBankAccountDal>().To<EfBankAccountDal>().InSingletonScope();

            Bind<ICreditCardService>().To<CreditCardManager>().InSingletonScope();
            Bind<ICreditCardDal>().To<EfCreditCardDal>().InSingletonScope();

            Bind<ILogService>().To<LogManager>().InSingletonScope();
            Bind<ILogDal>().To<EfLogDal>().InSingletonScope();
        }
    }
}
