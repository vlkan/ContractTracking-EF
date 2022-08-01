using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class WorkListManager : IWorkListService
{
    IWorkListDal _workListDal;

    public WorkListManager(IWorkListDal workListDal)
    {
        _workListDal = workListDal;
    }

    public IResult Add(WorkList workList)
    {
        _workListDal.Add(workList);
        return new SuccessResult(Messages.WorkListAdded);
    }

    public IResult Delete(WorkList workList)
    {
        _workListDal.Delete(workList);
        return new SuccessResult(Messages.WorkListDeleted);
    }

    public IDataResult<List<WorkList>> GetAll()
    {
        return new SuccessDataResult<List<WorkList>>(_workListDal.GetAll(), Messages.WorkListListed);
    }

    public IResult Update(WorkList workList)
    {
        _workListDal.Update(workList);
        return new SuccessResult(Messages.WorkListUpdated);
    }
}
