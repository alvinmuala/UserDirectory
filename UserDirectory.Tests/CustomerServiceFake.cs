using UserDirectory.Domain.Contracts.Services;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Tests
{
    public class CustomerServiceFake : ICustomerService
    {
        public readonly IEnumerable<Customer> _customers;

        public CustomerServiceFake()
        {
            _customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1,
                    FirstName = "Emma",
                    LastName = "Dunham",
                    City = "emma.dunham@vtgrafix.gov",
                    Address = "76 Sherman Road",
                    Country = "Aruba",
                    ZipCode = "06830"
                },
                 new Customer()
                {
                    Id = 2,
                    FirstName = "Ivan",
                    LastName = "Risley",
                    City = "ivan.risley@nitrosystems.co",
                    Address = "18 Hartswood Road",
                    Country = "Stanford",
                    ZipCode = "04346"
                },
                  new Customer()
                {
                    Id = 3,
                    FirstName = "Rikki",
                    LastName = "Paquette",
                    City = "rikki.paquette@anaplex.xyz",
                    Address = "56 Canal Street",
                    Country = "Iceland",
                    ZipCode = "16935"
                },

            };
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return _customers.ToList();
        }
    }
}
