using models;

namespace interfaces
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAsianCountries();
    }
}