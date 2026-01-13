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

        [HttpGet("{personId}/interests")]
        public async Task<IActionResult> GetInterestsByPerson(int personId)
        {
            var interests = await _context.People
                .Where(p => p.PersonId == personId)
                .SelectMany(p => p.Interests)
                .Select(i => new
                {
                    i.InterestId,
                    i.InterestName,
                    i.InterestDescription
                })
                .ToListAsync();

            return Ok(interests);
        }

        [HttpGet("{personId}/interests/links")]
        public async Task<IActionResult> GetLinksByPerson(int personId)
        {
            var links = await _context.People
                .Where(p => p.PersonId == personId)
                .SelectMany(p => p.Links)
                .Select(l => l.LinkUrl)
                .ToListAsync();

            return Ok(links);
        }
    }
}
