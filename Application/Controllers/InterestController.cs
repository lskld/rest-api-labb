using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rest_api_labb.Application.Context;
using rest_api_labb.Application.Models;
using rest_api_labb.Application.Models.DTOs;

namespace rest_api_labb.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterestController : ControllerBase
    {
        private readonly RestApiLabbDbContext _context;
        public InterestController(RestApiLabbDbContext context)
        {
            _context = context;
        }

        [HttpPost("{personId}/links/{interestId}")]
        public async Task<IActionResult> ConnectNewLink(int personId, int interestId, [FromBody] LinkCreateDto dto)
        {
            var newLink = new Link
            {
                LinkUrl = dto.LinkUrl,
                PersonId = personId,
                InterestId = interestId
            };

            _context.Links.Add(newLink);
            await _context.SaveChangesAsync();

            return Ok($"Link added successfully");
        }
    }
}
