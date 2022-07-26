﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class EmployeeManager : IEmployeeService
{
    IEmployeeDal _employeeDal;

    public EmployeeManager(IEmployeeDal employeeDal)
    {
        _employeeDal = employeeDal;
    }

    public IDataResult<List<Employee>> GetAllByName(string name)
    {
        return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll().Where(e => e.Name.ToLower().Contains(name.ToLower())).ToList(), Messages.EmployeeListed);
    }

    public IResult Add(Employee employee)
    {
        _employeeDal.Add(employee);
        return new SuccessResult(Messages.EmployeeAdded);
    }

    public IResult Delete(Employee employee)
    {
        _employeeDal.Delete(employee);
        return new SuccessResult(Messages.EmployeeDeleted);
    }

    public IResult SoftDelete(int id)
    {
        _employeeDal.SoftDelete(id);
        return new SuccessResult(Messages.EmployeeDeleted);
    }

    public IDataResult<List<Employee>> GetAll()
    {
        return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll(), Messages.EmployeeListed);
    }

    public IResult Update(Employee employee)
    {
        _employeeDal.Update(employee);
        return new SuccessResult(Messages.EmployeeUpdated);
    }
}
