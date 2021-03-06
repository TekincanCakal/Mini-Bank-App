using MiniBank.DataAcces.Abstract;
using MiniBank.DataAccess.Concrete.EntityFramework;
using MiniBank.Entities.Concrete;

namespace MiniBank.DataAcces.Concrete.EntityFramework
{
    public class EfCreditCardDal : EfEntityRepositoryBase<CreditCard, MiniBankContext>, ICreditCardDal
    {
    }
}
