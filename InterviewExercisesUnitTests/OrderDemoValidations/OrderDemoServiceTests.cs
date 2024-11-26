using FluentAssertions;
using InterviewExercises.OrderDemoValidations;
using Moq;

namespace InterviewExercisesUnitTests.OrderDemoValidations
{
    public class OrderDemoServiceTests
    {
        private MockRepository mockRepository;

        private Mock<IOrderDemoRepository> mockOrderDemoRepository;

        public OrderDemoServiceTests()
        {
            mockRepository = new MockRepository(MockBehavior.Strict);

            mockOrderDemoRepository = mockRepository.Create<IOrderDemoRepository>();
        }

        private OrderDemoService CreateService()
        {
            mockOrderDemoRepository.Setup(obj => obj.CreateAsync(It.IsAny<OrderDemoModel>())).Returns(Task.CompletedTask);
            return new OrderDemoService(
                mockOrderDemoRepository.Object);
        }

        [Fact]
        public async Task CreateAsync_SubtotalIsValid_ReturnsSuccess()
        {
            // Arrange
            var service = this.CreateService();
            var model = new OrderDemoModel
            {
                OrderId = "Ord123",
                UserId = "User987",
                Subtotal = 10.50M
            };

            // Act
            var result = await service.CreateAsync(
                model);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public async Task CreateAsync_SubtotalIsNegativeThrowsArgumentException()
        {
            // Arrange
            var service = this.CreateService();
            var model = new OrderDemoModel
            {
                OrderId = "Ord123",
                UserId = "User987",
                Subtotal = -10.50M
            };

            await Assert.ThrowsAsync<ArgumentException>(() => service.CreateAsync(model));
        }
    }
}
