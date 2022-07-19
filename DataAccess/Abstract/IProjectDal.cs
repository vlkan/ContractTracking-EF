using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProjectDal
    {
        List<Project> GetAll();
        List<Project> GetAllById(int id);
        List<Project> GetAllByName(string name);
        List<Project> GetAllByType(string type);
        void Add(Project project);
        void Update(Project project);
        void Delete(Project project);
    }
}
