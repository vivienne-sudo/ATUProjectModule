using NUnit.Framework;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem.Tests
{
    [TestFixture]
    public class ProfileControllerTests
    {
        private ProfileControllerTests _controller;
        private UserManager<IdentityUser> _userManager;
        private ApplicationDbContext _DbContext;
        private UserProfileService _userProfileService;
        private ILogger<ProfileController> _logger;

        [SetUp]
        public void Setup()
        {
            // Setup mock dependencies
            var userManagerMock = new Mock<UserManager<IdentityUser>>(Mock.Of<IUserStore<IdentityUser>>(), null, null, null, null, null, null, null, null);
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase(databaseName: "TestDB").Options;
            var context = new ApplicationDbContext(contextOptions);
            var userProfileServiceMock = new Mock<UserProfileService>(context);
            var loggerMock = new Mock<ILogger<ProfileController>>();

            // Initialize controller with mock dependencies
            _controller = new ProfileController(userProfileServiceMock.Object, userManagerMock.Object, context, loggerMock.Object);
        }

        [Test]
        public async Task Contract_WithValidId_ReturnsView()
        {
            // Arrange
            var userProfile = new UserProfile { UserId = "validUserId" };
            _controller.ControllerContext = new ControllerContext();
            _controller.ControllerContext.HttpContext = new DefaultHttpContext();
            _controller.ControllerContext.HttpContext.User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "username"),
                new Claim(ClaimTypes.NameIdentifier, "validUserId")
            }));

            _controller.HttpContext.User.Identity.Name = "username";
            _controller.HttpContext.User.Identity.GetUserId() = "validUserId";

            // Act
            var result = await _controller.Contract(userProfile.UserId) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(userProfile, result.Model);
        }

        [Test]
        public async Task Contract_WithInvalidId_ReturnsNotFound()
        {
            // Act
            var result = await _controller.Contract(null);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }


    }

    }
   