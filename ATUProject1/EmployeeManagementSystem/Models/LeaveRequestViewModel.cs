namespace EmployeeManagementSystem.Models
{
    public class LeaveRequestViewModel
    {
        public int LeaveRequestId { get; set; }

        public int UserProfileId { get; set; }

        public LeaveType LeaveType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Reason { get; set; }

        public string DoctorNoteFilePath { get; set; }

        public IFormFile DoctorNoteFile { get; set; }

        public LeaveRequestStatus LeaveRequestStatus { get; set; }
    }
}
