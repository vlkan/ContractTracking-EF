using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IInvoicingService
{
    IDataResult<List<Invoicing>> GetAll();
    IResult Add(Invoicing payment);
    IResult Update(Invoicing payment);
    IResult Delete(Invoicing payment);

    IDataResult<List<Invoicing>> GetByProjectId(int projectId);
}
