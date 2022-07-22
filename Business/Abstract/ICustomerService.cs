using Core.Utilities.Results;
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
    IDataResult<List<Customer>> GetAll();
    IDataResult<Customer> GetAllByName(string name);
    IDataResult<Customer> GetAllByEmail(string email);
    IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    IDataResult<Customer> GetById(int id);
    IResult Add(Customer customer);
    IResult Update(Customer customer);
}
