using Moq;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class ProfileControllerTests
    {
        private Mock<UserManager<IdentityUser>> _mockUserManager;
        private Mock<ApplicationDbContext> _mockContext;
        private Mock<UserProfileService> _mockUserProfileService;
        private Mock<ILogger<ProfileController>> _mockLogger;
        private ProfileController _controller;

        public ProfileControllerTests()
        {
            _mockUserManager = new Mock<UserManager<IdentityUser>>();
            _mockContext = new Mock<ApplicationDbContext>();
            _mockUserProfileService = new Mock<UserProfileService>();
            _mockLogger = new Mock<ILogger<ProfileController>>();

            _controller = new ProfileController(
                _mockUserProfileService.Object,
                _mockUserManager.Object,
                _mockContext.Object,
                _mockLogger.Object
            );
        }

        [Fact]
        public async Task Contract_ReturnsNotFoundResult_WhenIdIsNull()
        {
            // Arrange

            // Act
            var result = await _controller.Contract(null);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Contract_ReturnsNotFoundResult_WhenUserProfileIsNull()
        {
            // Arrange
            var userId = "testUserId";
            _mockContext.Setup(c => c.UserProfiles)
                .Returns(MockDbSet<UserProfile>.Empty());

            // Act
            var result = await _controller.Contract(userId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Contract_ReturnsViewResultWithUserProfile_WhenUserProfileExists()
        {
            // Arrange
            var userId = "testUserId";
            var userProfile = new UserProfile { UserId = userId };
            _mockContext.Setup(c => c.UserProfiles)
                .Returns(MockDbSet<UserProfile>.Create(userProfile));

            // Act
            var result = await _controller.Contract(userId);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<UserProfile>(viewResult.Model);
            Assert.Equal(userProfile, model);
        }

        // Add more test cases for other actions in ProfileController

        // Helper method to create a mock DbSet
        private static Mock<DbSet<T>> MockDbSet<T>(params T[] entities) where T : class
        {
            var queryable = entities.AsQueryable();
            var mockDbSet = new Mock<DbSet<T>>();
            mockDbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            mockDbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockDbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            mockDbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            return mockDbSet;
        }
    }
}
}