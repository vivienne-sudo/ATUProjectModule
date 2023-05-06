namespace EmployeeManagementSystem.Models
{
    public class LeaveRequestConfirmationViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; }
        public bool HasAnnualLeaveAvailable { get; set; }
    }

}
