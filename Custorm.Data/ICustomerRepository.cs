using CustomerManager.Core.Domain;
using System.Collections.Generic;

namespace CustomerManager.Data
{
    public  interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
