using System.Text.Json;
using UserDirectory.Domain.Models.Dtos;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Domain.Config
{
    public class DefaultConfig
    {
        public List<Customer> Customers { get; set; }

        public DefaultConfig()
        {
            Customers = GetCustomerData();
        }

        private List<Customer> GetCustomerData()
        {
            try
            {
                var customerDto = new List<CustomerDto>();
                var result = new List<Customer>();

                using (StreamReader r = new StreamReader("data.json"))
                {
                    string json = r.ReadToEnd();
                    customerDto = JsonSerializer.Deserialize<List<CustomerDto>>(json);
                }

                if (customerDto != null)
                {
                    var i = 1;
                    result = customerDto.Select(_ => new Customer
                    {
                        Id = i++,
                        FirstName = _.first_name,
                        LastName = _.last_name,
                        EmailAddress = _.email_address,
                        Address = _.address,
                        City = _.city,
                        Country = _.country,
                        ZipCode = _.zip_code

                    }).ToList();
                }

                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to deserialize and map 'data.json'file. + {e.Message}");
            }
        }
    }
}
