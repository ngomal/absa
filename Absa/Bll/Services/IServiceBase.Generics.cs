using Absa.Dal.Repositories;

namespace Absa.Bll.Services
{
    public interface IServiceBase<TRepository> : IServiceBase
        where TRepository : IRepositoryBase
    {

    }
}
