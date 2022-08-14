using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IInvoicingService
{
    IDataResult<List<Invoice>> GetAll();
    IResult Add(Invoice payment);
    IResult Update(Invoice payment);
    IResult Delete(Invoice payment);
    IResult SoftDelete(int id);

    IDataResult<List<Invoice>> GetByProjectId(int projectId);
    IDataResult<List<InvoiceDetailDto>> GetInvoiceDetails();
    IDataResult<List<InvoiceDetailDto>> SearchDateRange(DateTime start, DateTime end);
}
