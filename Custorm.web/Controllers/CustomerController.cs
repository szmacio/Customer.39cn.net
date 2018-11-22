using CustomerManager.Data;
using CustomerManager.Service;
using System.Web.Mvc;

namespace CustomerManager.Web.Controllers
{
    public class CustomerController : Controller
    {
      //  private readonly ICustomerService customerService = new CustomerService( new CustomerRepository());
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService _customerService)
        {
            this.customerService = _customerService;
        }
        // GET: Customer
        public ActionResult Customer()
        {

            var customer = customerService.GetCustomers();
            return View(customer);
        }
    }
}