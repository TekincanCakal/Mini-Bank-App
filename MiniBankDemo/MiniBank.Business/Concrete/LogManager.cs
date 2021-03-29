using System.Collections.Generic;
using MiniBank.Business.Abstract;
using MiniBank.DataAcces.Abstract;
using MiniBank.Entities.Concrete;

namespace MiniBank.Business.Concrete
{
    public class LogManager : ILogService
    {
        private ILogDal _logDal;
        public LogManager(ILogDal logDal)
        {
            _logDal = logDal;
        }
        public List<Log> GetAll()
        {
            return _logDal.GetAll();
        }
        public void Log(Log log)
        {
            _logDal.Add(log);
        }
    }
}
