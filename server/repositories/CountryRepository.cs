using interfaces;
using models;
using Newtonsoft.Json;

namespace repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly HttpClient _httpClient;

        public CountryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Country>> GetAsianCountries()
        {
            var response = await _httpClient.GetStringAsync("https://restcountries.com/v2/all");
            return JsonConvert.DeserializeObject<List<Country>>(response);
        }
    }
}
