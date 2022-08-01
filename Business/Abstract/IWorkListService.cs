using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IWorkListService
{
    IDataResult<List<WorkList>> GetAll();
    IResult Add(WorkList workList);
    IResult Update(WorkList workList);
    IResult Delete(WorkList workList);
}
