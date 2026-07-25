using CiCdDemo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CiCdDemo.Tests
{
    public class HomeControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.That(result, Is.InstanceOf<ViewResult>());
        }
    }
}
