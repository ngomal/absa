using Absa.Bll.Interfaces.Services.Customers;
using Absa.Models;
using System;
using System.Web.Mvc;

namespace Absa.Portal.Web.Controllers
{
    public class CustomerController : Controller
    {
        private Customer _customer;

        private ICustomerService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        /// <summary>
        /// Gets the customer record.
        /// </summary>
        /// <returns>JsonResult.</returns>
        [HttpGet]
        public JsonResult GetCustomer()
        {
            try
            {
                var customer = _service.GetCustomer();

                return Json(customer, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

                throw;
            }
        }

        /// <summary>
        /// Saves the customer record.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>JsonResult.</returns>
        [HttpPost]
        public JsonResult SaveCustomer(Customer customer)
        {
            try
            {
                customer.ModifiedDate = DateTime.Now;
                var updatedCustomer = _service.SaveCustomer(customer);

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

                throw;
            }

        }
     
    }
}