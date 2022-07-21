using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CustomerManager : ICustomerService
{
    ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public IResult Add(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerAdded);
    }

    public IDataResult<List<Customer>> GetAll()
    {
        return new DataResult<List<Customer>>(_customerDal.GetAll(), true, Messages.CustomerListed);
    }

    public IDataResult<Customer> GetAllByEmail(string email)
    {
        return _customerDal.Get(c => c.Email == email);
    }

    public IDataResult<Customer> GetAllByName(string name)
    {
        return _customerDal.Get(c => c.Name == name);
    }

    public IDataResult<Customer> GetById(int id)
    {
        return _customerDal.Get(c => c.Id == id);
    }

    public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
    {
        return _customerDal.GetCustomerDetails();
    }
}
