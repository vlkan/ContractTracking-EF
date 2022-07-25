﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ProjectManager : IProjectService
{
    IProjectDal _projectDal;
    public ProjectManager(IProjectDal projectDal)
    {
        _projectDal = projectDal;
    }

    public IDataResult<List<Project>> GetAll()
    {
        return new SuccessDataResult<List<Project>>(_projectDal.GetAll());
    }

    public IDataResult<Project> GetById(int id)
    {
        return new SuccessDataResult<Project>(_projectDal.Get(p => p.ProjectId == id));
    }
}
