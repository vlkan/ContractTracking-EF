﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IProjectService
{
    IDataResult<List<Project>> GetAll();
    IDataResult<List<ProjectDetailDto>> GetAllByCustomerAndProjectName(string text);
    IDataResult<Project> GetById(int id);
    IResult Add(Project project);
    IResult Update(Project project);
    IResult Delete(Project project);
    IResult SoftDelete(int id);

    IDataResult<List<Project>> GetByCustomerId(int customerId);
    IDataResult<List<ProjectDetailDto>> GetProjectDetails();
    IDataResult<List<ProjectDetailDto>> GetProjectDetailsByCustomerId(int customerId);
}
