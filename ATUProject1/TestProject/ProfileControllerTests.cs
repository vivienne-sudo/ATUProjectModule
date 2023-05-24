using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Models;
using global::EmployeeManagementSystem.Controllers;
using global::EmployeeManagementSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;


namespace TestProject
{
    [TestClass]
    public class ProfileControllerTests
    {
        [TestMethod]
        public async Task Contract_WhenIdIsNull_ReturnsNotFound()
        {
            // Arrange
            var mockUserManager = Mock.Of<UserManager<IdentityUser>>();
            var mockContext = new Mock<ApplicationDbContext>();
            var mockUserProfileService = new Mock<UserProfileService>();

            var controller = new ProfileController(mockUserProfileService.Object, mockUserManager, mockContext.Object);

            // Act
            var result = await controller.Contract(null);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Index_WhenUserIsNull_ReturnsNotFound()
        {
            // Arrange
            var userManager = Mock.Of<UserManager<IdentityUser>>();
            var context = new Mock<ApplicationDbContext>();
            var userProfileService = new Mock<UserProfileService>();

            var controller = new ProfileController(userProfileService.Object, userManager, context.Object);

            // Act
            var result = await controller.Index((string)null);


            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Details_WhenUserIsNull_ReturnsNotFound()
        {
            // Arrange
            var userManager = Mock.Of<UserManager<IdentityUser>>();
            var context = new Mock<ApplicationDbContext>();
            var userProfileService = new Mock<UserProfileService>();

            var controller = new ProfileController(userProfileService.Object, userManager, context.Object);

            // Act
            var result = await controller.Details();

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Salary_WhenUserProfileIdIsNull_ReturnsNotFound()
        {
            // Arrange
            var userManager = Mock.Of<UserManager<IdentityUser>>();
            var context = new Mock<ApplicationDbContext>();
            var userProfileService = new Mock<UserProfileService>();

            var controller = new ProfileController(userProfileService.Object, userManager, context.Object);

            // Act
            var result = await controller.Salary(null);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
