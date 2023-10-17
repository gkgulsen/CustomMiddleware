using CustomMiddleware.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Comment(CommentDetail? commentDetail)
        {
            _logger.LogInformation("OK");
            return Ok(commentDetail);
        }
    }
}
