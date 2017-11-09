using Absa.Dal.Interfaces.Repositories;
using Absa.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Absa.Dal.Repositories.Customers
{
    /// <summary>
    /// Represents the customer repository class. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Absa.Dal.Repositories.IRepositoryBase" />
    /// <seealso cref="Absa.Dal.Interfaces.Repositories.ICustomerRepository" />
    public sealed class CustomerRepository : IRepositoryBase, ICustomerRepository
    {

        /// <summary>
        /// The file data path.
        /// </summary>
        private string _dataPath = AppDomain.CurrentDomain.BaseDirectory + $"App_Data\\Customer.json";

        /// <summary>
        /// Selects the customer.
        /// </summary>
        /// <returns>Customer.</returns>
        public Customer SelectCustomer()
        {
            Customer customer = null;

            try
            {
                customer = JsonConvert.DeserializeObject<Customer>(File.ReadAllText(_dataPath));
            }
            catch (Exception)
            {
                throw;
            }           

            return customer;
        }

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>System.Int32.</returns>
        public Customer UpdateCustomer(Customer customer)
        {            
            try
            {
                File.WriteAllText(_dataPath, JsonConvert.SerializeObject(customer));

                return customer;
            }
            catch
            {
                throw;
            }                       
        }
    }
}
