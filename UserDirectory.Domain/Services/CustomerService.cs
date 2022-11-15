using UserDirectory.Domain.Contracts.Repositories;
using UserDirectory.Domain.Contracts.Services;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _customerRepository.GetAll();
        }
    }
}
