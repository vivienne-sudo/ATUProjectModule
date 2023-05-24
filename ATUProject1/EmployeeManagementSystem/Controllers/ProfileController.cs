using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Helpers;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Controllers
{
    /// <summary>
    /// Controller responsible for handling profile-related actions.
    /// </summary>
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly UserProfileService _userProfileService;

        public ProfileController(UserProfileService userProfileService, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
            _userProfileService = userProfileService;
        }
        /// <summary>
        /// Displays the contract details for a user.
        /// </summary>
        /// <param name="id">The ID of the user profile.</param>
        /// <returns>The contract view.</returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Contract(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userProfile = await _context.UserProfiles
                .FirstOrDefaultAsync(m => m.UserId == id);

            if (userProfile == null)
            {
                return NotFound();
            }

            return View(userProfile); 
        }

        /// <summary>
        /// Creates a new notification for all admin users.
        /// </summary>
        /// <param name="message">The notification message.</param>
        /// <param name="firstName">The first name of the user associated with the notification.</param>
        /// <param name="lastName">The last name of the user associated with the notification.</param>
        private async Task CreateNotificationAsync(string message, string firstName, string lastName)
        {
            // Get the list of admin users
            var adminUsers = await _userManager.GetUsersInRoleAsync("Admin");

            // Create a new notification for each admin
            foreach (var adminUser in adminUsers)
            {
                var notification = new Notification
                {
                    AdminId = adminUser.Id,
                    StaffUserId = _userManager.GetUserId(User),
                    Message = $"{firstName} {lastName}: {message}",
                    IsViewed = false,
                    Timestamp = DateTime.Now
                };

                _context.Notifications.Add(notification);
            }

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Displays the profile details for the current user.
        /// </summary>
        /// <returns>The profile view.</returns>
        [HttpGet]
        public async Task<IActionResult> Index(string userId)
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


        /// <summary>
        /// Updates the profile details for the current user.
        /// </summary>
        /// <param name="model">The profile view model containing the updated details.</param>
        /// <returns>The updated profile view.</returns>
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

                // Find the existing UserProfile for the current user
                var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(up => up.UserId == user.Id);

                bool isFirstTimeProfileCompletion = userProfile == null;

                if (isFirstTimeProfileCompletion)
                {
                    // If UserProfile doesn't exist, create a new one
                    userProfile = new UserProfile
                    {
                        UserId = user.Id
                    };
                    _context.UserProfiles.Add(userProfile);
                }

                // Update the UserProfile with the new data from the ProfileViewModel
                userProfile.FirstName = model.FirstName;
                userProfile.LastName = model.LastName;
                userProfile.AddressLine1 = model.AddressLine1;
                userProfile.AddressLine2 = model.AddressLine2;
                userProfile.County = model.County;
                userProfile.Eircode = model.Eircode;
                userProfile.PhoneNumber = model.PhoneNumber;
                userProfile.PPSN = model.PPSN;
                userProfile.DateOfBirth = model.DateOfBirth;
                userProfile.Gender = model.Gender;
                userProfile.PartnerIncome = model.PartnerIncome;
                userProfile.TaxCategory = model.TaxCategory;

                // Save the changes to the database
                await _context.SaveChangesAsync();

                var userName = $"{userProfile.FirstName} {userProfile.LastName}";

                // Check if this is the first time the user is completing their profile
                if (isFirstTimeProfileCompletion)
                {
                    // Send a notification to the admin
                    await CreateNotificationAsync($"User {userProfile.FirstName} {userProfile.LastName} has created their profile.", userProfile.FirstName, userProfile.LastName);
                }
                else
                {
                    await CreateNotificationAsync($"User {userProfile.FirstName} {userProfile.LastName} has updated their profile.", userProfile.FirstName, userProfile.LastName);
                }

                // Get the roles of the user
                var userRoles = await _userManager.GetRolesAsync(user);

                // Check if the user is an admin
                if (userRoles.Contains("Admin"))
                {
                    // Redirect to the admin homepage
                    return RedirectToAction("AdminHomePage", "Home");
                }

                // Redirect to the staff homepage for non-admin users
                return RedirectToAction("StaffHomePage", "Home");
            }

            return View(model);
        }


        /// <summary>
        /// Retrieves the details for editing a user profile.
        /// </summary>
        /// <param name="id">The ID of the user profile to edit.</param>
        /// <returns>The profile view for editing.</returns>
        public async Task<IActionResult> Edit(int id)
        {
            var userProfile = await _context.UserProfiles.FindAsync(id);
            if (userProfile == null)
            {
                return NotFound($"Unable to find user profile with ID '{id}'.");
            }

            var model = new ProfileViewModel
            {
                UserProfileId = userProfile.UserProfileId,
                UserId = userProfile.UserId,
                FirstName = userProfile.FirstName,
                LastName = userProfile.LastName,
                AddressLine1 = userProfile.AddressLine1,
                AddressLine2 = userProfile.AddressLine2,
                County = userProfile.County,
                Eircode = userProfile.Eircode,
                PhoneNumber = userProfile.PhoneNumber,
                PPSN = userProfile.PPSN,
                DateOfBirth = userProfile.DateOfBirth,
                Gender = userProfile.Gender,
                PartnerIncome = userProfile.PartnerIncome,
                TaxCategory = userProfile.TaxCategory
            };

            return View("Index", model);
        }


        /// <summary>
        /// Displays the details for the current user's profile.
        /// </summary>
        /// <returns>The details view for the user profile.</returns>
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



        /// <summary>
        /// Displays the salary details for a user.
        /// </summary>
        /// <param name="userProfileId">The ID of the user profile.</param>
        /// <returns>The salary view.</returns>
        [HttpGet]
        public async Task<IActionResult> Salary(int? userProfileId)
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

            // Create a new instance of SalaryViewModel
            var salaryViewModel = new SalaryViewModel();

            // Set the necessary properties of the instance
            salaryViewModel.TaxCredit = userProfile.TaxCredit;
            salaryViewModel.PartnerIncome = userProfile.PartnerIncome;
            salaryViewModel.TaxCategory = userProfile.TaxCategory;

            // Calculate the tax liability, net salary, and pension contributions
            decimal taxLiability = TaxAndPensionCalculator.CalculateTax(
    userProfile.YearlySalary,
    userProfile.EmployeePensionContributionPercentage,
    salaryViewModel.TaxCredit,
    salaryViewModel.PartnerIncome ?? 0,
    salaryViewModel.TaxCategory
);

            decimal employeePensionContribution = userProfile.YearlySalary * (userProfile.EmployeePensionContributionPercentage / 100);
            decimal employerPensionContribution = userProfile.YearlySalary * (userProfile.EmployerPensionContributionPercentage / 100);
            // ...
            decimal netYearlySalary = userProfile.YearlySalary - taxLiability - employeePensionContribution;

            // Update the SalaryViewModel with the calculated values
            salaryViewModel.UserProfileId = userProfile.UserProfileId;
            salaryViewModel.GrossYearlySalary = userProfile.YearlySalary;
            salaryViewModel.NetYearlySalary = netYearlySalary;
            salaryViewModel.GrossMonthlySalary = userProfile.YearlySalary / 12;
            salaryViewModel.NetMonthlySalary = netYearlySalary / 12;
            salaryViewModel.GrossWeeklySalary = userProfile.YearlySalary / 52;
            salaryViewModel.NetWeeklySalary = netYearlySalary / 52;
            salaryViewModel.TaxLiability = taxLiability;
            salaryViewModel.EmployeePensionContributionPercentage = userProfile.EmployeePensionContributionPercentage;
            salaryViewModel.EmployeePensionContribution = employeePensionContribution;
            salaryViewModel.EmployerPensionContributionPercentage = userProfile.EmployerPensionContributionPercentage;
            salaryViewModel.EmployerPensionContribution = employerPensionContribution;

            return View(salaryViewModel);
        }



        /// <summary>
        /// Updates the salary details for a user.
        /// </summary>
        /// <param name="userProfileId">The ID of the user profile.</param>
        /// <param name="salaryViewModel">The salary view model containing the updated details.</param>
        /// <returns>The updated salary view.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Salary(int userProfileId, [Bind("UserProfileId,GrossYearlySalary,NetYearlySalary,GrossMonthlySalary,NetMonthlySalary,GrossWeeklySalary,NetWeeklySalary,TaxCategory,TaxCredit,TaxLiability,EmployeePensionContributionPercentage,EmployeePensionContribution,EmployerPensionContributionPercentage,EmployerPensionContribution,PartnerIncome")] SalaryViewModel salaryViewModel)
        {
            if (userProfileId != salaryViewModel.UserProfileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var userProfile = await _context.UserProfiles.FindAsync(userProfileId);
                userProfile.YearlySalary = salaryViewModel.GrossYearlySalary;
                userProfile.EmployeePensionContributionPercentage = salaryViewModel.EmployeePensionContributionPercentage;
                userProfile.EmployerPensionContributionPercentage = salaryViewModel.EmployerPensionContributionPercentage;

                try
                {
                    _context.Update(userProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _userProfileService.UserProfileExists(userProfile.UserProfileId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Salary), new { userProfileId = salaryViewModel.UserProfileId });
            }
                return View(salaryViewModel);
        }

        /// <summary>
        /// Displays all staff profiles.
        /// </summary>
        /// <returns>The view displaying all staff profiles.</returns>
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AllStaff()
        {
            var staffProfiles = await _context.UserProfiles.ToListAsync();
            return View(staffProfiles);
        }

        /// <summary>
        /// Retrieves the details for editing a user's salary.
        /// </summary>
        /// <param name="userProfileId">The ID of the user profile.</param>
        /// <returns>The salary edit view.</returns>
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
                YearlySalary = userProfile.YearlySalary,
                Position = userProfile.Position,
                StartDate = userProfile.StartDate == DateTime.MinValue ? DateTime.Now : userProfile.StartDate,
                EmployerPensionContributionPercentage = userProfile.EmployerPensionContributionPercentage
            };

            return View(editSalaryViewModel);
        }

        /// <summary>
        /// Updates the salary details for a user.
        /// </summary>
        /// <param name="userProfileId">The ID of the user profile.</param>
        /// <param name="editSalaryViewModel">The salary view model containing the updated details.</param>
        /// <returns>The updated salary view.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSalary(int userProfileId, [Bind("UserProfileId,YearlySalary,Position,StartDate,EmployerPensionContributionPercentage")] EditSalaryViewModel editSalaryViewModel)
        {
            if (userProfileId != editSalaryViewModel.UserProfileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var userProfile = await _context.UserProfiles.FindAsync(userProfileId);
                userProfile.YearlySalary = editSalaryViewModel.YearlySalary;
                userProfile.Position = editSalaryViewModel.Position;
                userProfile.StartDate = editSalaryViewModel.StartDate;
                userProfile.EmployerPensionContributionPercentage = editSalaryViewModel.EmployerPensionContributionPercentage; // Fix this line

                try
                {
                    _context.Update(userProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _userProfileService.UserProfileExists(userProfile.UserProfileId))
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

    }
}
