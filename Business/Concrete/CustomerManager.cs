using Business.Abstract;
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

    public void Add(Customer customer)
    {
        _customerDal.Add(customer);
    }

    public List<Customer> GetAll()
    {
        return _customerDal.GetAll();
    }

    public Customer GetAllByEmail(string email)
    {
        return _customerDal.Get(c => c.Email == email);
    }

    public Customer GetAllByName(string name)
    {
        return _customerDal.Get(c => c.Name == name);
    }

    public Customer GetById(int id)
    {
        return _customerDal.Get(c => c.Id == id);
    }

    public List<CustomerDetailDto> GetCustomerDetails()
    {
        return _customerDal.GetCustomerDetails();
    }
}
