using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ProfileController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            // Pass the user ID to the view
            ViewBag.UserId = user.Id;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Get the currently logged-in user
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user == null)
                {
                    return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                }

                // Map the ProfileViewModel to a new UserProfile object
                var userProfile = new UserProfile
                {
                    UserId = user.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    AddressLine1 = model.AddressLine1,
                    AddressLine2 = model.AddressLine2,
                    County = model.County,
                    Eircode = model.Eircode,
                    PhoneNumber = model.PhoneNumber,
                    PPSN = model.PPSN,
                    DateOfBirth = model.DateOfBirth,
                    Gender = model.Gender,
                    PartnerIncome = model.PartnerIncome,
                    TaxCategory = model.TaxCategory
                };

                // Save the UserProfile to the database
                _context.UserProfiles.Add(userProfile);
                await _context.SaveChangesAsync();

                // After saving the user's profile data
                return RedirectToAction("StaffHomePage", "Home");

            }

            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Details()
        {
            // Get the currently logged-in user
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            // Get the user's profile
            var userProfile = _context.UserProfiles.FirstOrDefault(up => up.UserId == user.Id);
            if (userProfile == null)
            {
                return NotFound($"Unable to load user profile with user ID '{user.Id}'.");
            }

            return View(userProfile);
        }
        public async Task<IActionResult> Salary(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProfile = await _context.UserProfiles
                .FirstOrDefaultAsync(m => m.UserProfileId == id);
            if (userProfile == null)
            {
                return NotFound();
            }

            // Populate the SalaryViewModel properties
            var salaryViewModel = new SalaryViewModel
            {
                UserProfileId = userProfile.UserProfileId,
                YearlySalary = userProfile.YearlySalary,
                MonthlySalary = userProfile.MonthlySalary,
                WeeklySalary = userProfile.WeeklySalary,
                HourlyRate = userProfile.HourlyRate,
                TaxObligation = userProfile.TaxObligation,
                EmployeePensionContributionPercentage = userProfile.EmployeePensionContributionPercentage,
                EmployeePensionContribution = userProfile.EmployeePensionContribution,
                EmployerPensionContributionPercentage = userProfile.EmployerPensionContributionPercentage,
                EmployerPensionContribution = userProfile.EmployerPensionContribution,
                PartnerIncome = userProfile.PartnerIncome
            };

            return View(salaryViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Salary(SalaryViewModel salaryViewModel)
        {
            if (ModelState.IsValid)
            {
                var userProfile = await _context.UserProfiles.SingleOrDefaultAsync(u => u.UserProfileId == salaryViewModel.UserProfileId);

                // Update only the allowed properties
                userProfile.EmployeePensionContributionPercentage = salaryViewModel.EmployeePensionContributionPercentage;

                // Perform the necessary calculations for tax, pension, and salary information
                // ...

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Salary));
            }

            return View(salaryViewModel);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllStaff()
        {
            var staffProfiles = await _context.UserProfiles.ToListAsync();
            return View(staffProfiles);
        }

        [HttpGet]
        public async Task<IActionResult> EditSalary(int? userProfileId)
        {
            if (userProfileId == null)
            {
                return NotFound();
            }

            var userProfile = await _context.UserProfiles.FindAsync(userProfileId);
            if (userProfile == null)
            {
                return NotFound();
            }

            var editSalaryViewModel = new EditSalaryViewModel
            {
                UserProfileId = userProfile.UserProfileId,
                YearlySalary = userProfile.YearlySalary
            };

            return View(editSalaryViewModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSalary(int userProfileId, [Bind("UserProfileId,YearlySalary")] EditSalaryViewModel editSalaryViewModel)
        {
            if (userProfileId != editSalaryViewModel.UserProfileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var userProfile = await _context.UserProfiles.FindAsync(userProfileId);
                userProfile.YearlySalary = editSalaryViewModel.YearlySalary;

                try
                {
                    _context.Update(userProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProfileExists(userProfile.UserProfileId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AllStaff));
            }
            return View(editSalaryViewModel);
        }


        private bool UserProfileExists(int userProfileId)
        {
            return _context.UserProfiles.Any(e => e.UserProfileId == userProfileId);
        }


    }
}
