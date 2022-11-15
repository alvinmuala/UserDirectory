using UserDirectory.Api.Controllers;

namespace UserDirectory.Tests
{
    public class UsersControllerTest
    {
        private readonly UsersController _controller;
        private readonly CustomerServiceFake _service;

        public UsersControllerTest()
        {
            _service = new CustomerServiceFake();
            _controller = new UsersController(_service);
        }

        [Fact]
        public async Task Get_WhenCalled_ReturnsItems()
        {
            // Act
            var result = await _controller.GetCustomers();
            // Assert
            Assert.NotNull(result);
        }
    }
}