using EmployeeManagementSystem.Controllers;
    using EmployeeManagementSystem.Data;
    using EmployeeManagementSystem.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Moq;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace TestProject
{
        [TestClass]
        public class HomeControllerTests
        {
            private readonly Mock<UserManager<IdentityUser>> _userManagerMock;
            private readonly Mock<SignInManager<IdentityUser>> _signInManagerMock;
            private readonly Mock<ILogger<HomeController>> _loggerMock;
            private readonly Mock<ApplicationDbContext> _contextMock;

            public HomeControllerTests()
            {
                _userManagerMock = new Mock<UserManager<IdentityUser>>();
                _signInManagerMock = new Mock<SignInManager<IdentityUser>>();
                _loggerMock = new Mock<ILogger<HomeController>>();
                _contextMock = new Mock<ApplicationDbContext>();
            }

            [TestMethod]
            public async Task Index_ReturnsViewResult_WhenUserIsNotAuthenticated()
            {
                // Arrange
                var controller = new HomeController(
                    _loggerMock.Object,
                    _userManagerMock.Object,
                    _contextMock.Object,
                    _signInManagerMock.Object);
                controller.ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext()
                };

                // Act
                var result = await controller.Index();

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
            }

            [TestMethod]
            public async Task Index_ReturnsRedirectToActionResult_WhenUserIsAuthenticatedAndIsAdmin()
            {
                // Arrange
                var controller = new HomeController(
                    _loggerMock.Object,
                    _userManagerMock.Object,
                    _contextMock.Object,
                    _signInManagerMock.Object);
                controller.ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.NameIdentifier, "1") })) }
                };
                _userManagerMock.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(new IdentityUser());
                _userManagerMock.Setup(x => x.IsInRoleAsync(It.IsAny<IdentityUser>(), It.IsAny<string>())).ReturnsAsync(true);

                // Act
                var result = await controller.Index();

                // Assert
                Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
                var redirectResult = result as RedirectToActionResult;
                Assert.AreEqual("AdminHomePage", redirectResult.ActionName);
            }

            // Add more tests here...
        }
    
}


