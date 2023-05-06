using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class ApplyForLeaveViewModel
    {
        [Required]
        [Display(Name = "Leave Type")]
        public string LeaveType { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public string StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public string EndDate { get; set; }

        [Required]
        [Display(Name = "Reason")]
        public string Reason { get; set; }

        [Display(Name = "Doctor's Note")]
        public IFormFile DoctorNote { get; set; }

        [HiddenInput]
        public string UserProfileId { get; set; }
    }

}
