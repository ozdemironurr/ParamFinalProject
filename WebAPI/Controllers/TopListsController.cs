using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopListsController : ControllerBase
    {
        private readonly ITopListService _topListService;
        public TopListsController(ITopListService topListService)
        {

            _topListService = topListService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] TopList topList)
        {
            var result = _topListService.Add(topList);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] TopList topList)
        {
            var result = _topListService.Delete(topList);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _topListService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int topListId)
        {
            var result = _topListService.GetById(topListId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserbylists")]
        public IActionResult GetUserByLists(int userId)
        {
            var result = _topListService.GetUserByLists(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
