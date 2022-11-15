using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Domain.Contracts.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersAsync();
    }
}
