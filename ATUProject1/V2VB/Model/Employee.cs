using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2VB.Model
{
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime DateOfEmployment { get; set; }
            public bool IsManager { get; set; }
            public int CompanyId { get; set; }
            public Company Company { get; set; }
        }
    
}
