using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TakeBackTheCourt.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TakeBackTheCourt.Controllers
{
    [Route("api/[controller]")]
    public class ResourceController : ControllerBase
    {
        private readonly CourtContext _context;

        public ResourceController(CourtContext context)
        {
            _context = context;
            if (_context.Resources.Count() == 0)
            {
                _context.Resources.Add(new Resource
                {
                    Title = "Test Resource"
                });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Resource> GetAll()
        {
            return _context.Resources.ToList();
        }

        [HttpGet("{id}", Name = "GetResource")]
        public IActionResult GetById(long id)
        {
            var item = _context.Resources.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
