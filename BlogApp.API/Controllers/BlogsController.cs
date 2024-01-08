using BlogApp.Business.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        IBlogService _service;

        public BlogsController(IBlogService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var blogs = await _service.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK, blogs);
        }
    }
}
