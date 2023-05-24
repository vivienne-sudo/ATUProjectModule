   using System.Threading.Tasks;
    using EmployeeManagementSystem.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Moq;
    using Xunit;

    namespace TestProject
{
        public class ProfileControllerTests
        {
            [Fact]
            public async Task Index_ReturnsViewResult()
            {
                // Arrange
                var userProfile = new UserProfile
                {
                    // Set necessary properties
                };

                var userManagerMock = new Mock<UserManager<IdentityUser>>();
                var contextMock = new Mock<ApplicationDbContext>();
                var userProfileServiceMock = new Mock<UserProfileService>();
                var loggerMock = new Mock<ILogger<ProfileController>>();

                userManagerMock.Setup(mock => mock.GetUserAsync(It.IsAny<ClaimsPrincipal>()))
                    .ReturnsAsync(new IdentityUser());

                contextMock.Setup(mock => mock.UserProfiles.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserProfile, bool>>>()))
                    .ReturnsAsync(userProfile);

                var controller = new ProfileController(userProfileServiceMock.Object, userManagerMock.Object,
                    contextMock.Object, loggerMock.Object);

                // Act
                var result = await controller.Index();

                // Assert
                Assert.IsType<ViewResult>(result);
            }

            // Add more tests here for other actions in ProfileController
        }
    }

}