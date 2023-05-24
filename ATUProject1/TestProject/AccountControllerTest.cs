using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestProject
{

    [TestClass]
    public class AccountControllerTests
    {
        private readonly Mock<UserManager<IdentityUser>> _userManagerMock;
        private readonly Mock<SignInManager<IdentityUser>> _signInManagerMock;
        private readonly Mock<ILogger<AccountController>> _loggerMock;
        private readonly Mock<RoleManager<IdentityRole>> _roleManagerMock;
        private readonly Mock<ApplicationDbContext> _contextMock;
        private readonly Mock<UserProfileService> _userProfileServiceMock;

        public AccountControllerTests()
        {
            _userManagerMock = new Mock<UserManager<IdentityUser>>();
            _signInManagerMock = new Mock<SignInManager<IdentityUser>>();
            _loggerMock = new Mock<ILogger<AccountController>>();
            _roleManagerMock = new Mock<RoleManager<IdentityRole>>();
            _contextMock = new Mock<ApplicationDbContext>();
            _userProfileServiceMock = new Mock<UserProfileService>();
        }

        [TestMethod]
        public async Task Register_ReturnsViewResult_WhenModelStateIsInvalid()
        {
            // Arrange
            var controller = new AccountController(
                _userProfileServiceMock.Object,
                _userManagerMock.Object,
                _signInManagerMock.Object,
                _loggerMock.Object,
                _roleManagerMock.Object,
                _contextMock.Object);
            controller.ModelState.AddModelError("error", "error");

            // Act
            var result = await controller.Register(new RegisterViewModel());

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        // Add more tests here...
    }
}

