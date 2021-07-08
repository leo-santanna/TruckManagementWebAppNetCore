using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace TruckManagementWebAppTest
{
    public class TruckControllerTest
    {
        [Fact]
        public void Index_ReturnsAViewResult_WithAListOfTrucks()
        {
            // Arrange
            var mockRepo = new Mock<IDataRepository<Truck>>();
            mockRepo.Setup(repo => repo.GetAll())
                .Returns(GetTestTrucks());
            var controller = new TrucksController(mockRepo.Object);
            // Act
            var result = controller.Index();
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<Employee>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }
        private IEnumerable<Truck> GetTestTrucks()
        {
            return new List<Truck>()
    {
        new Truck()
        {
            Id = 1,
            Name = "John"
        },
        new Truck()
        {
            Id = 2,
            Name = "Doe"
        }
    };
        }
    }
}
