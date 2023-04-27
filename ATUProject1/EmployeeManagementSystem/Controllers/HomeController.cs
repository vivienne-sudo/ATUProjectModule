using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeeManagementSystem.Controllers
{
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

        [Authorize(Roles = "Admin")]
        public IActionResult AdminHomePage()
        {
            return View();
        }

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



        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> StaffHomePage()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            // Your existing logic for the StaffHomePage

            var bankHolidays = await _dbContext.BankHolidays.ToListAsync();
            return View(bankHolidays);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

    }
}

