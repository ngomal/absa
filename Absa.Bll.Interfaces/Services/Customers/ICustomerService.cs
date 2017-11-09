using Absa.Bll.Services;
using Absa.Dal.Interfaces.Repositories;
using Absa.Models;

namespace Absa.Bll.Interfaces.Services.Customers
{
    /// <summary>
    /// Represents the interface for customer service
    /// </summary>
    /// <seealso cref="Absa.Bll.Services.IServiceBase{Absa.Dal.Interfaces.Repositories.ICustomerRepository}" />
    public interface ICustomerService : IServiceBase<ICustomerRepository>
    {
        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <returns>Customer.</returns>
        Customer GetCustomer();


        /// <summary>
        /// Saves the customer.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.Int32.</returns>
        Customer SaveCustomer(Customer customer);
    }
}
