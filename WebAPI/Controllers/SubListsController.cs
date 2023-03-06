using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubListsController : ControllerBase
    {
        private readonly ISubListService _subListService;

        public SubListsController(ISubListService subListService)
        {
            _subListService = subListService;


        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] SubList subList)
        {
            var result = _subListService.Add(subList);

            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] SubList subList)
        {
            var result = _subListService.Delete(subList);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _subListService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int subListId)
        {
            var result = _subListService.GetById(subListId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserbylistsdetails")]
        public IActionResult GetUserByListsDetails(int subListId)
        {
            var result = _subListService.GetUserByListsDetails(subListId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
