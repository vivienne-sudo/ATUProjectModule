using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestProject
{
        [TestClass]
        public class AdminNotificationsControllerTests
        {
            private readonly Mock<UserManager<IdentityUser>> _userManagerMock;
            private readonly Mock<ApplicationDbContext> _contextMock;

            public AdminNotificationsControllerTests()
            {
                _userManagerMock = new Mock<UserManager<IdentityUser>>();
                _contextMock = new Mock<ApplicationDbContext>();
            }

            [TestMethod]
            public async Task Index_ReturnsViewResult_WithCorrectModel()
            {
                // Arrange
                var controller = new AdminNotificationsController(_contextMock.Object, _userManagerMock.Object);
                controller.ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.NameIdentifier, "1") })) }
                };

                // Act
                var result = await controller.Index();

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
                var viewResult = result as ViewResult;
                Assert.IsInstanceOfType(viewResult.Model, typeof(List<Notification>));
            }

            [TestMethod]
            public async Task MarkAsViewed_ReturnsRedirectToActionResult_WhenNotificationExists()
            {
                // Arrange
                var controller = new AdminNotificationsController(_contextMock.Object, _userManagerMock.Object);
                _contextMock.Setup(x => x.Notifications.FindAsync(It.IsAny<int>())).ReturnsAsync(new Notification());

                // Act
                var result = await controller.MarkAsViewed(1);

                // Assert
                Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
                var redirectResult = result as RedirectToActionResult;
                Assert.AreEqual("Index", redirectResult.ActionName);
            }

            [TestMethod]
            public async Task MarkAsViewed_ReturnsNotFound_WhenNotificationDoesNotExist()
            {
                // Arrange
                var controller = new AdminNotificationsController(_contextMock.Object, _userManagerMock.Object);
                _contextMock.Setup(x => x.Notifications.FindAsync(It.IsAny<int>())).ReturnsAsync((Notification)null);

                // Act
                var result = await controller.MarkAsViewed(1);

                // Assert
                Assert.IsInstanceOfType(result, typeof(NotFoundResult));
            }

            [TestMethod]
            public async Task ViewedNotifications_ReturnsViewResult_WithCorrectModel()
            {
                // Arrange
                var controller = new AdminNotificationsController(_contextMock.Object, _userManagerMock.Object);

                // Act
                var result = await controller.ViewedNotifications();

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
                var viewResult = result as ViewResult;
                Assert.IsInstanceOfType(viewResult.Model, typeof(List<Notification>));
            }
        }
    
}
