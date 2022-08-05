using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicingController : ControllerBase
    {
        IInvoicingService _invoicingService;

        public InvoicingController(IInvoicingService invoicingService)
        {
            _invoicingService = invoicingService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _invoicingService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyemployee")]
        public IActionResult GetByCustomer(int employeeId)
        {
            var result = _invoicingService.GetByProjectId(employeeId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Invoicing invoice)
        {
            var result = _invoicingService.Add(invoice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Invoicing invoice)
        {
            var result = _invoicingService.Update(invoice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Invoicing invoice)
        {
            var result = _invoicingService.Delete(invoice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
