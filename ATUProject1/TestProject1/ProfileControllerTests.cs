using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;

namespace EmployeeManagementSystem.Tests
{
    [TestClass]
    public class ProfileControllerTests
    {
        private readonly Mock<UserManager<IdentityUser>> _userManagerMock;
        private readonly Mock<ApplicationDbContext> _contextMock;
        private readonly Mock<UserProfileService> _userProfileServiceMock;
        private readonly Mock<ILogger<ProfileController>> _loggerMock;

        public ProfileControllerTests()
        {
            _userManagerMock = new Mock<UserManager<IdentityUser>>();
            _contextMock = new Mock<ApplicationDbContext>();
            _userProfileServiceMock = new Mock<UserProfileService>();
            _loggerMock = new Mock<ILogger<ProfileController>>();
        }

        [TestMethod]
        public async Task Index_ReturnsViewResult_WithCorrectModel_WhenUserIsAuthenticated()
        {
            // Arrange
            var controller = new ProfileController(
                _userProfileServiceMock.Object,
                _userManagerMock.Object,
                _contextMock.Object,
                _loggerMock.Object);
            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.NameIdentifier, "1") })) }
            };
            _userManagerMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(new IdentityUser());

            // Act
            var result = await controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(ProfileViewModel));
        }

        [TestMethod]
        public async Task Details_ReturnsViewResult_WithCorrectModel_WhenUserIsAuthenticated()
        {
            // Arrange
            var controller = new ProfileController(
                _userProfileServiceMock.Object,
                _userManagerMock.Object,
                _contextMock.Object,
                _loggerMock.Object);
            controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.NameIdentifier, "1") })) }
            };
            _userManagerMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(new IdentityUser());

            // Act
            var result = await controller.Details();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(UserProfile));
        }

        [TestMethod]
        public async Task Edit_ReturnsViewResult_WithCorrectModel_WhenUserProfileExists()
        {
            // Arrange
            var controller = new ProfileController(
                _userProfileServiceMock.Object,
                _userManagerMock.Object,
                _contextMock.Object,
                _loggerMock.Object);
            _contextMock.Setup(x => x.UserProfiles.FindAsync(It.IsAny<int>())).ReturnsAsync(new UserProfile());

            // Act
            var result = await controller.Edit(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(ProfileViewModel));
        }

        [TestMethod]
        public async Task Salary_ReturnsViewResult_WithCorrectModel_WhenUserProfileExists()
        {
            // Arrange
            var controller = new ProfileController(
                _userProfileServiceMock.Object,
                _userManagerMock.Object,
                _contextMock.Object,
                _loggerMock.Object);
            _contextMock.Setup(x => x.UserProfiles.FindAsync(It.IsAny<int>())).ReturnsAsync(new UserProfile());

            // Act
            var result = await controller.Salary(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            var viewResult = result as ViewResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(SalaryViewModel));
        }
    }
}

