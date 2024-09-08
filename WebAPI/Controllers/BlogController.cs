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

        [HttpPut("{id}")]
        public IActionResult UpdateBlog(int id, Blog model)
        {
            var item = _context.Blogs.FirstOrDefault(b => b.BlogId == id);

            if(item is null)
            {
                return BadRequest("No data found");
            }

            item.BlogTitle = model.BlogTitle;
            item.BlogAuthor = model.BlogAuthor;
            item.BlogContent = model.BlogContent;

            var result = _context.SaveChanges();

            string message = result > 0 ? "Update Successful!" : "Update Failed!";

            return Ok(message);
        }

        [HttpDelete]

        public IActionResult DeleteBlog() 
        {
            return Ok();
        }
    }
}
