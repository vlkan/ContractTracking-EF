using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class InvoicingManager : IInvoicingService
{
    IInvoicingDal _invoicingDal;

    public InvoicingManager(IInvoicingDal paymentDal)
    {
        this._invoicingDal = paymentDal;
    }

    public IResult Add(Invoice payment)
    {
        _invoicingDal.Add(payment);
        return new SuccessResult(Messages.PaymentAdded);
    }

    public IResult Delete(Invoice invoice)
    {
        _invoicingDal.Delete(invoice);
        return new SuccessResult(Messages.PaymentDeleted);
    }

    public IDataResult<List<Invoice>> GetAll()
    {
        return new SuccessDataResult<List<Invoice>>(_invoicingDal.GetAll(), Messages.PaymentListed);
    }

    public IDataResult<List<Invoice>> GetByProjectId(int projectId)
    {
        return new SuccessDataResult<List<Invoice>>(_invoicingDal.GetAll(p => p.ProjectId == projectId), Messages.PaymentListed);
    }

    public IDataResult<List<InvoiceDetailDto>> GetInvoiceDetails()
    {
        return new SuccessDataResult<List<InvoiceDetailDto>>(_invoicingDal.GetInvoiceDetails(), Messages.PaymentListed);
    }

    public IResult Update(Invoice invoice)
    {
        _invoicingDal.Update(invoice);
        return new SuccessResult(Messages.PaymentUpdated);
    }
}
