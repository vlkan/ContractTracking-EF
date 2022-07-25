﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IProjectService
{
    IDataResult<List<Project>> GetAll();
    IDataResult<Project> GetById(int id);
}
