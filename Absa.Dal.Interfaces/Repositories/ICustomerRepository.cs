using Absa.Dal.Repositories;
using Absa.Models;

namespace Absa.Dal.Interfaces.Repositories
{
    /// <summary>
    /// Represents the customer repository interface.
    /// </summary>
    public interface ICustomerRepository : IRepositoryBase
    {
        /// <summary>
        /// Selects the customer.
        /// </summary>
        /// <returns>Customer.</returns>
        Customer SelectCustomer();

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>System.Int32.</returns>
        Customer UpdateCustomer(Customer customer);
    }
}
