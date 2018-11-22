using CustomerManager.Service;
using System.Web.Mvc;

namespace CustomerManager.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService _customerService)
        {
            this.customerService = _customerService;
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customer = customerService.GetCustomers();
            return View(customer);
        }
    }
}