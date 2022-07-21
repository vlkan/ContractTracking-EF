using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICustomerService
{
    List<Customer> GetAll();
    Customer GetAllByName(string name);
    Customer GetAllByEmail(string email);
    List<CustomerDetailDto> GetCustomerDetails();
    Customer GetById(int id);
    void Add(Customer customer);
}
