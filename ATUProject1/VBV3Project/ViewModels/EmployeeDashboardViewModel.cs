using VBV3Project.Models;

namespace VBV3Project.ViewModels
{
    public class EmployeeDashboardViewModel
    {
        public string BusinessOwnerName { get; set; }
        public string BusinessName { get; set; }
        public List<Employee> Employees { get; set; }
        public Employee CurrentEmployee { get; set; }
    }


}
