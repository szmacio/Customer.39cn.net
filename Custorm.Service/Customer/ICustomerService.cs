using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManager.Core.Domain;

namespace CustomerManager.Service
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
