using Absa.Bll.Interfaces.Services.Customers;
using Absa.Models;
using System.Web.Mvc;

namespace Absa.Portal.Web.Controllers
{
    public class HomeController : Controller
    {
        private Customer _customer;

        private ICustomerService _service;

        public HomeController(ICustomerService service)
        {
            _service = service;

            _customer = _service.GetCustomer();
        }

        public ActionResult Index()
        {
            return View(_customer);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}