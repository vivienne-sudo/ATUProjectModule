using EmployeeManagementSystem.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminNotificationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminNotificationsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentAdminId = _userManager.GetUserId(User);
            var notifications = await _context.Notifications
                .Where(n => n.AdminId == currentAdminId)
                .OrderByDescending(n => n.Timestamp)
                .ToListAsync();
            return View(notifications);
        }

        public async Task<IActionResult> MarkAsViewed(int id)
        {
            var notification = await _context.Notifications.FindAsync(id);
            if (notification == null)
            {
                return NotFound();
            }

            notification.IsViewed = true;
            _context.Update(notification);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ViewedNotifications()
        {
            var viewedNotifications = await _context.Notifications
                .Where(n => n.IsViewed)
                .ToListAsync();

            return View(viewedNotifications);
        }

    }
}

