using System.Collections.Generic;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Abstract
{
    public interface ILogService
    {
        List<Log> GetAll();
        void Log(Log log);
    }
}
