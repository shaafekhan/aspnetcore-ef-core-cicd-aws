using corewebapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using corewebapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace corewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public WeatherController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        [HttpGet]
        public async Task<ActionResult<List<WeatherForecast>>> GetAll()
        {
            var weather = await _appDbContext.WeatherForecasts.ToListAsync();
            return Ok(weather);
        }
    }
}
