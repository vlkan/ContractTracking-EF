using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkListsController : ControllerBase
    {
        IWorkListService _workListService;

        public WorkListsController(IWorkListService workListService)
        {
            _workListService = workListService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _workListService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(WorkList workList)
        {
            var result = _workListService.Add(workList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(WorkList workList)
        {
            var result = _workListService.Update(workList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(WorkList workList)
        {
            var result = _workListService.Delete(workList);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
