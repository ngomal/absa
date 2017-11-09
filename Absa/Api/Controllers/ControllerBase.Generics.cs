using Absa.Bll.Services;

namespace Absa.Api.Controllers
{
    public abstract class ControllerBase<TService> : ControllerBase, IControllerBase<TService>
        where TService : IServiceBase
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ControllerBase{TService}"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        protected ControllerBase(TService service)
        {
            Service = service;
        }

        /// <summary>
        /// Gets the service.
        /// </summary>
        /// <value>The service.</value>
        protected TService Service
        {
            get;
            private set;
        }
    }
}
