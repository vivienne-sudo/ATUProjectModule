using System;

namespace EmployeeManagementSystem.Models
{
    /// <summary>
    /// Represents a bank holiday.
    /// </summary>
    public class BankHoliday
    {
        /// <summary>
        /// Gets or sets the bank holiday ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank holiday.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of the bank holiday.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
