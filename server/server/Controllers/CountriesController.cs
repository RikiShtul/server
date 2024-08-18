using interfaces;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _iCountryService;

        public CountriesController(ICountryService iCountryService)
        {
            _iCountryService = iCountryService;
        }

        [HttpGet("GetAsianCountries")]
        public async Task<IActionResult> Get()
        {
            var countries = await _iCountryService.GetAsianCountries();
            return Ok(countries);
        }

    }
}
