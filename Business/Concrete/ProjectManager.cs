using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Concrete;

public class ProjectManager : IProjectService
{
    IProjectDal _projectDal;
    //IServiceRepository<Project> _projectDal;
    public ProjectManager(IProjectDal projectDal)
    {
        _projectDal = projectDal;
    }

    public IResult Add(Project project)
    {
        _projectDal.Add(project);
        return new SuccessResult(Messages.ProjectAdded);
    }

    public IResult Delete(Project project)
    {
        _projectDal.Delete(project);
        return new SuccessResult(Messages.ProjectDeleted);
    }

    public IResult SoftDelete(int id)
    {
        _projectDal.SoftDelete(id);
        return new SuccessResult(Messages.ProjectDeleted);
    }

    public IDataResult<List<Project>> GetAll()
    {
        return new SuccessDataResult<List<Project>>(_projectDal.GetAll(), Messages.ProjectListed);
    }

    public IDataResult<List<ProjectDetailDto>> GetAllByCustomerAndProjectName(string text)
    {
        return new SuccessDataResult<List<ProjectDetailDto>>(_projectDal.GetProjectDetails().Where(c => c.Name.ToLower().Contains(text.ToLower()) ||
            c.CustomerOwnerName.ToLower().Contains(text.ToLower())).ToList(), Messages.ProjectListed);
    }

    public IDataResult<List<Project>> GetByCustomerId(int customerId)
    {
        return new SuccessDataResult<List<Project>>(_projectDal.GetAll(p => p.CustomerOwnerId == customerId), Messages.CustomerListed);
    }
    public IDataResult<Project> GetById(int id)
    {
        return new SuccessDataResult<Project>(_projectDal.Get(p => p.Id == id));
    }

    public IDataResult<List<ProjectDetailDto>> GetProjectDetails()
    {
        return new SuccessDataResult<List<ProjectDetailDto>>(_projectDal.GetProjectDetails(), Messages.ProjectListed);
    }

    public IDataResult<List<ProjectDetailDto>> GetProjectDetailsByCustomerId(int customerId)
    {
        return new SuccessDataResult<List<ProjectDetailDto>>(_projectDal.GetProjectDetailsByCustomerId(customerId), Messages.ProjectListed);
    }

    public IResult Update(Project project)
    {
        _projectDal.Update(project);
        return new SuccessResult(Messages.ProjectUpdated);
    }
}
