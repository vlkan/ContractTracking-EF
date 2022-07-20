using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

    public List<Customer> GetAll()
    {
        return _customerDal.GetAll();
    }

    public List<Customer> GetAllByEmail(string email)
    {
        return _customerDal.GetAll(c => c.Email == email);
    }

    public List<Customer> GetAllById(int id)
    {
        return _customerDal.GetAll(c => c.Id == id);
    }

    public List<Customer> GetAllByName(string name)
    {
        return _customerDal.GetAll(c => c.Name == name);
    }
}
