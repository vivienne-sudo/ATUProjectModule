namespace EmployeeManagementSystem.Models
{
    public class StaffHomePageViewModel
    {
        public UserProfile UserProfile { get; set; }
        public int AnnualLeaveDaysAvailable { get; set; }
        public int SickLeaveDaysAvailable { get; set; }
        public string UserProfileId { get; set; }
        public List<BankHoliday> BankHolidays { get; set; }
    }

}
