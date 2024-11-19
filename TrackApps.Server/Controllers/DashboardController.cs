using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackApps.Server.Data;

namespace TrackApps.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ApplicationDbContext context, ILogger<DashboardController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInterviews()
        {
            _logger.IsEnabled(LogLevel.Debug);
            var interviewList = await _context.Interviews.ToListAsync();
            return Ok(interviewList);
        }
    }
}
