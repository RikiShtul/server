using models;

namespace interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> GetAsianCountries();
    }
}