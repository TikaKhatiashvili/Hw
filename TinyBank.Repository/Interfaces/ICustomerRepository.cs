using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyBank.Repository.Models;

namespace TinyBank.Repository.Interfaces;

public interface ICustomerRepository
{
    List<Customer> GetCustomers();
    Customer GetSingleCustomer(int id);
    int AddCustomer(Customer customer);
    int UpdateCustomer(Customer customer);
    int DeleteCustomer(int id);
}
