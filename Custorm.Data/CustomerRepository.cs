using CustomerManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManager.Core.Domain;

namespace CustomerManager.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            // 访问数据库
            List<Customer> list = new List<Customer>();
            list.Add(new Customer { ID = 1, Age = 30, Name = "TOM" });
            return list;
        }
    }
}
