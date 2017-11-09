using Absa.Bll.Interfaces.Services.Customers;
using Absa.Dal.Interfaces.Repositories;
using Absa.Models;

namespace Absa.Bll.Services.Customers
{
    /// <summary>
    /// Represent the customer service class. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Absa.Bll.Services.ServiceBase{Absa.Dal.Interfaces.Repositories.ICustomerRepository}" />
    /// <seealso cref="Interfaces.Services.Customers.ICustomerService" />
    public sealed class CustomerService : ServiceBase<ICustomerRepository>, ICustomerService
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerService"/> class.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        public CustomerService(ICustomerRepository customerRepository)
            :base(customerRepository)
        {
                    
        }

        /// <summary>
        /// Gets the customer.
        /// </summary>
        /// <returns>Customer.</returns>
        public Customer GetCustomer()
        {
            return Repository.SelectCustomer();
        }
        
        /// <summary>
        /// Saves the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>System.Int32.</returns>
        public Customer SaveCustomer(Customer customer)
        {
            return Repository.UpdateCustomer(customer);
        }
    }
}
