using Containers.Data;
using Containers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Containers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly ILogger<DriversController> _logger;
        private readonly ApiDbContext _dbContext;

        public DriversController(ILogger<DriversController> logger, ApiDbContext apiDbContext)
        {
            _logger = logger;
            _dbContext = apiDbContext;
        }

        [HttpGet(Name = "GetAllDrivers")]
        public async Task<IActionResult> Get()
        {
            var driver = new Driver
            {
                Name = "Lewis Hamilton",
                DriverNumber = 44
            };

            _dbContext.Drivers.Add(driver);
            await _dbContext.SaveChangesAsync();

            var allDrivers = await _dbContext.Drivers.ToListAsync();
            return Ok(allDrivers);
        }
    }
}
