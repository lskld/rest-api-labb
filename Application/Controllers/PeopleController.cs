using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rest_api_labb.Application.Context;

namespace rest_api_labb.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase  
    {
        private readonly RestApiLabbDbContext _context;
        public PeopleController(RestApiLabbDbContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPeople()
        {
            var people = await _context.People.ToListAsync();
            return Ok(people);
        }
    }
}
