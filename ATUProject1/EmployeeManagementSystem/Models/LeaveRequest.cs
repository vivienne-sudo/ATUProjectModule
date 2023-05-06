using System;

namespace EmployeeManagementSystem.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int UserProfileId { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] DoctorNote { get; set; }
        public LeaveRequestStatus Status { get; set; }
    }

    public enum LeaveRequestStatus
    {
        Pending,
        Approved,
        Denied
    }
}
