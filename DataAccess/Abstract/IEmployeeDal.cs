using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal
    {
        List<Employee> GetAll();
        List<Employee> GetAllById(int id);
        List<Employee> GetAllByNameSurname(string name);
        List<Employee> GetAllByJobTitle(string title);

        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
