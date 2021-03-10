using BlazorBlog.Server.Data;
using BlazorBlog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Category>> GetAllCategories()
        {
            return Ok(_context.Categories.OrderByDescending(cat => cat.Name));
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetSingleCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(cat => cat.Id == id);
            if (category == null)
            {
                return NotFound("This category does not exist.");
            }

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateNewCategory(Category request)
        {
            _context.Add(request);
            await _context.SaveChangesAsync();

            return request;
        }
    }
}
