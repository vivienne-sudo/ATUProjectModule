using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace EmployeeManagementSystem.Controllers
{ 
    /// <summary>
 /// Controller responsible for handling home-related actions.
 /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, ApplicationDbContext dbContext, SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        /// <summary>
        /// Displays the admin home page.
        /// </summary>
        /// <returns>The admin home page view.</returns>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminHomePage()
        {
            var currentAdmin = await _userManager.GetUserAsync(User);
            if (currentAdmin == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var notifications = await _dbContext.Notifications
                .Where(n => n.AdminId == currentAdmin.Id && !n.IsViewed)
                .OrderByDescending(n => n.Timestamp)
                .ToListAsync();

            return View(notifications);
        }


        /// <summary>
        /// Displays the home page based on the user's role.
        /// </summary>
        /// <returns>The appropriate home page view.</returns>
        public async Task<IActionResult> Index()
        {
            // Check if the user is logged in
            if (User.Identity.IsAuthenticated)
            {
                // Check if the user has the "Admin" role
                var user = await _userManager.GetUserAsync(User);
                if (await _userManager.IsInRoleAsync(user, "Admin"))
                {
                    // Redirect the admin user to the AdminHomePage
                    return RedirectToAction("AdminHomePage", "Home");
                }
                else
                {
                    // Redirect the non-admin user to the StaffHomePage
                    return RedirectToAction("StaffHomePage", "Home");
                }
            }
            else
            {
                // If the user is not logged in, display the default Index view
                return View();
            }
        }


        /// <summary>
        /// Displays the privacy page.
        /// </summary>
        /// <returns>The privacy view.</returns>
        public IActionResult Privacy()
        {
            return View();
        }


        /// <summary>
        /// Displays the staff home page.
        /// </summary>
        /// <returns>The staff home page view.</returns>
        [Authorize]
        public async Task<IActionResult> StaffHomePage()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            // Your existing logic for the StaffHomePage

            var bankHolidays = await _dbContext.BankHolidays.ToListAsync();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
           
            var viewModel = new StaffHomePageViewModel
            {
                UserProfileId = userId,
                BankHolidays = bankHolidays
            };

            return View(viewModel);
        }

        /// <summary>
        /// Handles the error page.
        /// </summary>
        /// <returns>The error view.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

    }
}

