using Application.Dto;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecuestController : Controller
    {
        private readonly IRecuestApplication _recuestApplication;
        public RecuestController(IRecuestApplication recuestApplication)
        {
            _recuestApplication = recuestApplication;
        }

        [HttpPost("post")]
        public async Task<IActionResult> Post([FromBody] RecuestDto recuestDto)
        {
                if (recuestDto == null)
                    return BadRequest();

                var response = await _recuestApplication.Add(recuestDto);

                if (response.IsSuccess)
                    return Ok(response);

                return BadRequest(response.Message);           
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] RecuestDto RecuestDto)
        {
                if (RecuestDto == null)
                    return BadRequest();

                var response = await _recuestApplication.Update(RecuestDto);

                if (response.IsSuccess)
                    return Ok(response);

                return BadRequest(response.Message);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _recuestApplication.Delete(id);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {            
            var response = await _recuestApplication.Get(id);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response.Message);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {            
             var response = await _recuestApplication.GetAll();
             if (response.IsSuccess)
                    return Ok(response);
             return BadRequest(response.Message);         
        }
    }
}
