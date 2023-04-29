using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly UserProfileService _userProfileService;
  
        public AccountController(
            UserProfileService userProfileService,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<AccountController> logger,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userProfileService = userProfileService;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
            _context = context;
          
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    // Add the user to the Admin role if the IsAdmin property is true
                    if (model.IsAdmin)
                    {
                        await _userManager.AddToRoleAsync(user, "Admin");
                    }
                    else
                    {
                        // Check if the "Staff" role exists, and if not, create it
                        if (!await _roleManager.RoleExistsAsync("Staff"))
                        {
                            var staffRole = new IdentityRole("Staff");
                            await _roleManager.CreateAsync(staffRole);
                        }

                        // Add the user to the "Staff" role
                        await _userManager.AddToRoleAsync(user, "Staff");
                    }

                    // Generate the email confirmation token
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    // Generate the email confirmation URL
                    var callbackUrl = Url.Action("EmailConfirmed", "Account", new { userId = user.Id, code }, protocol: HttpContext.Request.Scheme);

                    // Redirect the user to the ConfirmEmail view with userId and code
                    return View("EmailConfirmed", (UserId: user.Id, Code: callbackUrl));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            _logger.LogInformation("Register failed, redisplaying form.");
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Check if the current user is authenticated and is in the "Staff" role
            if (User.Identity.IsAuthenticated && await _userManager.IsInRoleAsync(await _userManager.GetUserAsync(User), "Staff"))
            {
                // Redirect the staff member to the profile form
                return RedirectToAction("Index", "Profile");
            }

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            _logger.LogInformation("Login attempt started.");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);

                    if (await _userProfileService.UserProfileExists(user.Id))
                    {
                        // Redirect to StaffHomePage if the user has an existing profile
                        return RedirectToAction("StaffHomePage", "Home");
                    }
                    else
                    {
                        // Redirect to Profile form if the user does not have an existing profile
                        return RedirectToAction("Index", "Profile", new { userId = user.Id });
                    }
                }

                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToAction(nameof(Lockout));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    _logger.LogWarning("Invalid login attempt.");
                    return View(model);
                }
            }

            _logger.LogWarning("Model state is not valid.");
            // If we got this far, something failed, redisplay form
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                // Check if the user is a staff member
                if (await _userManager.IsInRoleAsync(user, "Staff"))
                {
                    // Set TempData value to indicate that the staff user needs to complete the profile form
                    TempData["ShowProfileForm"] = true;
                }

                return RedirectToAction(nameof(Login));
            }

            return RedirectToAction(nameof(Login));
        }
    }
}


