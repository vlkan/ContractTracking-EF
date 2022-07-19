﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        List<Customer> GetAllById(int id);
        List<Customer> GetAllByName(string name);
        List<Customer> GetAllByPhone(string number);

        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
