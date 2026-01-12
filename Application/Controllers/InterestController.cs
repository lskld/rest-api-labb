using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rest_api_labb.Application.Context;

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
    }
}
