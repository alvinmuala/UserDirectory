using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UserDirectory.Domain.Contracts.Repositories;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Data.SqlServer.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Storage _storage;
        private readonly ILogger<CustomerRepository> _logger;

        public CustomerRepository(Storage storage, ILogger<CustomerRepository> logger)
        {
            _storage = storage;
            _logger = logger;
        }

        public async Task<Customer> Get(int id)
        {

            var customer = await _storage.Customers.FirstOrDefaultAsync(_ => _.Id == id);

            if (customer == null)
            {
                throw new ArgumentException($"No Customer found with Id '{id}'");
            }

            return customer;
        }
        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _storage.Customers.ToListAsync();
        }

        public async Task<Customer> Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));
            try
            {
                _storage.Add(customer);
                await _storage.SaveChangesAsync();

                return customer;
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message);
                throw;
            }

        }
        public async Task<Customer> Update(int id, Customer item)
        {
            var exisitingCustomer = _storage.Customers.FirstOrDefault(_ => _.Id == id);

            if (exisitingCustomer == null)
                throw new ArgumentNullException(nameof(exisitingCustomer));

            try
            {
                _storage.Update(item);
                await _storage.SaveChangesAsync();

                return item;
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public async Task Delete(int id)
        {
            var customer = _storage.Customers.FirstOrDefault(_ => _.Id == id);

            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            _storage.Customers.Remove(customer);
            await _storage.SaveChangesAsync();
        }
    }
}
