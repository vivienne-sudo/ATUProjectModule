namespace EmployeeManagementSystem.Models
{
    public class StaffHomePageViewModel
    { 
        public string ErrorMessage { get; set; }
        
        public UserProfile UserProfile { get; set; }
        public int AnnualLeaveDays { get; set; }
        public int SickLeaveDays { get; set; }
        public string? UserProfileId { get; set; }
        public List<BankHoliday> BankHolidays { get; set; }
    }

}
