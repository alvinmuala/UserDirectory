using Microsoft.AspNetCore.Mvc;
using UserDirectory.Domain.Contracts.Services;
using UserDirectory.Domain.Models.Entities;

namespace UserDirectory.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public UsersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            var result = await _customerService.GetCustomersAsync();

            return Ok(result.ToList());
        }
    }
}
