namespace EmployeeManagementSystem.Models
{
    public enum LeaveType
    {
        AnnualLeave,
        SickLeave
    }

    public enum LeaveRequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }

        public int UserProfileId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public LeaveType LeaveType { get; set; }
        public int DaysRequested { get; set; }

        public string Reason { get; set; }

        public string DoctorNoteFilePath { get; set; }
        public UserProfile UserProfile { get; set; }
        public LeaveRequestStatus Status { get; set; }
    }
}

