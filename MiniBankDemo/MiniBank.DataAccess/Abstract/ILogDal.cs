using MiniBank.DataAccess.Abstract;
using MiniBank.Entities.Concrete;

namespace MiniBank.DataAcces.Abstract
{
    public interface ILogDal : IEntityRepository<Log>
    {
    }
}
