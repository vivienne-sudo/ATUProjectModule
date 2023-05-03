namespace EmployeeManagementSystem.Models
{
    public class AdminHomePageViewModel
    {
        public string UserProfileId { get; set; }
        public List<BankHoliday> BankHolidays { get; set; }
        public List<CalendarEvents> CalendarEvents { get; set; }
        public List<Notification> Notifications { get; set; }

        public AdminHomePageViewModel()
        {
            BankHolidays = new List<BankHoliday>();
            CalendarEvents = new List<CalendarEvents>();
            Notifications = new List<Notification>();
        }
    }


}
