using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBlogs() 
        {
            var list = _context.Blogs.ToList();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult CreateBlog(Blog model)
        {
            _context.Blogs.Add(model);
            var result = _context.SaveChanges();

            string message = result > 0 ? "Saving Successful!" : "Saving Failed!";
            return Ok(message);
        }

        [HttpPut]
        public IActionResult UpdateBlog()
        {
            return Ok();
        }

        [HttpDelete]

        public IActionResult DeleteBlog() 
        {
            return Ok();
        }
    }
}
