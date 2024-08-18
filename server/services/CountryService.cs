using interfaces;
using models;

namespace services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _iCountryRepository;

        public CountryService(ICountryRepository iCountryRepository)
        {
            _iCountryRepository = iCountryRepository;
        }

        public async Task<List<Country>> GetAsianCountries()
        {
            var countries = await _iCountryRepository.GetAsianCountries();
            return countries.Where(c => c.Region == "Asia").ToList();
        }
    }
}
