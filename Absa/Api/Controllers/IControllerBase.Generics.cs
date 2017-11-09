using Absa.Bll.Services;

namespace Absa.Api.Controllers
{
    /// <summary>
    /// Represents the base interface of all controllers in the Absa assessment framework.
    /// </summary>
    /// <typeparam name="TService">The type of the t service.</typeparam>
    /// <seealso cref="Absa.Api.Controllers.IControllerBase" />
    public interface IControllerBase<TService> : IControllerBase
        where TService : IServiceBase
    {

    }
}
