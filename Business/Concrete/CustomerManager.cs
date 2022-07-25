using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

    [ValidationAspect(typeof(CustomerValidator))]
    public IResult Add(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerAdded);
    }

    public IDataResult<List<Customer>> GetAll()
    {
        return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
    }

    public IDataResult<Customer> GetAllByEmail(string email)
    {
        return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Email == email), Messages.CustomerListed);
    }

    public IDataResult<Customer> GetAllByName(string name)
    {
        return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Name == name), Messages.CustomerListed);
    }

    public IDataResult<Customer> GetById(int id)
    {
        return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id), Messages.CustomerListed);
    }

    public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
    {
        return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails(), Messages.CustomerListed);
    }

    public IResult Update(Customer customer)
    {
        _customerDal.Update(customer);
        return new SuccessResult(Messages.CustomerUpdated);
    }

    private IResult CheckIfCustomerExists(string customerName)
    {
        var result = _customerDal.GetAll(c => c.Name == customerName).Any();
        if (!result)
        {
            return new SuccessResult();
        }
        return new ErrorResult(Messages.CustomerAlreadyExist);
    }
}
