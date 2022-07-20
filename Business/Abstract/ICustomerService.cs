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
    List<Customer> GetAllById(int id);
    List<Customer> GetAllByName(string name);
    List<Customer> GetAllByEmail(string email);
    List<CustomerDetailDto> GetCustomerDetails();
}
