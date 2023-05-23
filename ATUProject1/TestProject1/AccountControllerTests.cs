using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using NSubstitute;
using Microsoft.Extensions.Options;

namespace EmployeeManagementSystem.Tests
{
    [TestClass]
    public class AccountControllerTests
    {
        private AccountController _accountController;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private ILogger<AccountController> _logger;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;
        private UserProfileService _userProfileService;

        [TestInitialize]
        public void TestInitialize()
        {
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddEntityFrameworkInMemoryDatabase()
                .AddDbContext<ApplicationDbContext>((options, context) =>
                    context.UseInMemoryDatabase("TestDb"));

            var serviceProvider = services.BuildServiceProvider();

            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userStore = new UserStore<IdentityUser>(context);
            _userManager = new UserManager<IdentityUser>(userStore, null, new PasswordHasher<IdentityUser>(),
                new IUserValidator<IdentityUser>[0], new IPasswordValidator<IdentityUser>[0], null, null, null, null);

            var roleStore = new RoleStore<IdentityRole>(context);
            _roleManager = new RoleManager<IdentityRole>(roleStore, null, null, null, null);

            var identityOptions = new IdentityOptions();
            var options = new OptionsWrapper<IdentityOptions>(identityOptions);
            var claimsFactory = new UserClaimsPrincipalFactory<IdentityUser, IdentityRole>(_userManager, _roleManager, options);
            var contextAccessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            var userConfirmation = Substitute.For<IUserConfirmation<IdentityUser>>();
            _signInManager = new SignInManager<IdentityUser>(_userManager, contextAccessor, claimsFactory, options, null, null, userConfirmation);

            _logger = Substitute.For<ILogger<AccountController>>();
            _userProfileService = Substitute.For<UserProfileService>();

            _accountController = new AccountController(_userProfileService, _userManager, _signInManager, _logger, _roleManager, context);
        }


        [TestMethod]
        public async Task Contract_ReturnsNotFound_WhenIdIsNull()
        {
            var result = await _accountController.Contract(null);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public async Task Register_ReturnsViewResult_WhenModelStateIsInvalid()
        {
            _accountController.ModelState.AddModelError("Error", "Error");

            var result = await _accountController.Register(new RegisterViewModel());

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task Login_ReturnsViewResult_WhenModelStateIsInvalid()
        {
            _accountController.ModelState.AddModelError("Error", "Error");

            var result = await _accountController.Login(new LoginViewModel());

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public async Task Logout_ReturnsRedirectToActionResult()
        {
            var result = await _accountController.Logout();

            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public async Task ConfirmEmail_ReturnsRedirectToActionResult_WhenUserIdOrCodeIsNull()
        {
            var result = await _accountController.ConfirmEmail(null, null);

            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
        }
    }
}
