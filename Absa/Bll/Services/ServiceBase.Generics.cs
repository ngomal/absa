using Absa.Dal.Repositories;

namespace Absa.Bll.Services
{
    /// <summary>
    /// Represents the base class for all services in the Absa assessments framework.
    /// </summary>
    /// <typeparam name="TRepository">The type of the t repository.</typeparam>
    /// <seealso cref="Absa.Bll.Services.ServiceBase" />
    /// <seealso cref="Absa.Bll.Services.IServiceBase{TRepository}" />
    public abstract class ServiceBase<TRepository> : ServiceBase, IServiceBase<TRepository>
        where TRepository : IRepositoryBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceBase{TRepository}"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        protected ServiceBase(TRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Gets the service repository.
        /// </summary>
        /// <value>The repository.</value>
        protected TRepository Repository
        {
            get;
            private set;
        }
    }
}
