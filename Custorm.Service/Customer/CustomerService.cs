using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManager.Core.Domain;
using CustomerManager.Data;

namespace CustomerManager.Service
{
  public  class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }  

        public List<Customer> GetCustomers()
        {
            return customerRepository.GetCustomers();
         
        }
    }
}
