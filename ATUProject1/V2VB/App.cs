using System;
using System.IO;
using Xamarin.Forms;
using V2VB.Services;
using V2VB.Data;
using V2VB.ViewModel;

namespace V2VB
{
    public partial class App : Application
    {
        public static MyDatabase Database { get; private set; }

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydb.db3");
            Database = new MyDatabase(dbPath);

            var navigationService = new NavigationServiceImpl();
            var companyService = new CompanyServiceImpl(Database);
            var employeeService = new EmployeeServiceImpl(Database);
            var userService = new UserServiceImpl(Database);

            MainPage = new NavigationPage(new CompanyListPage(new CompanyListViewModel(companyService, navigationService)));

            // Uncomment this code block to create a sample data
            //if (Database.GetCompanies().Count == 0)
            //{
            //    Database.SaveCompany(new Company
            //    {
            //        Name = "Company 1",
            //        Email = "company1@test.com",
            //        PasswordHash = "password",
            //        AddressLine1 = "123 Main Street",
            //        City = "Dublin",
            //        County = "Dublin",
            //        Eircode = "D01 F5P2",
            //        PhoneNumber = "1234567890",
            //        CreatedAt = DateTime.Now
            //    });

            //    Database.SaveCompany(new Company
            //    {
            //        Name = "Company 2",
            //        Email = "company2@test.com",
            //        PasswordHash = "password",
            //        AddressLine1 = "456 Second Street",
            //        City = "Cork",
            //        County = "Cork",
            //        Eircode = "C02 B4F6",
            //        PhoneNumber = "0987654321",
            //        CreatedAt = DateTime.Now
            //    });

            //    Database.SaveEmployee(new Employee
            //    {
            //        FirstName = "John",
            //        LastName = "Doe",
            //        DateOfBirth = new DateTime(1990, 1, 1),
            //        Gender = Gender.Male,
            //        PhoneNumber = "1234567890",
            //        AddressLine1 = "123 Main Street",
            //        City = "Dublin",
            //        County = "Dublin",
            //        Eircode = "D01 F5P2",
            //        CreatedAt = DateTime.Now
            //    });

            //    Database.SaveEmployee(new Employee
            //    {
            //        FirstName = "Jane",
            //        LastName = "Doe",
            //        DateOfBirth = new DateTime(1995, 1, 1),
            //        Gender = Gender.Female,
            //        PhoneNumber = "0987654321",
            //        AddressLine1 = "456 Second Street",
            //        City = "Cork",
            //        County = "Cork",
            //        Eircode = "C02 B4F6",
            //        CreatedAt = DateTime.Now
            //    });

            //    Database.SaveUser(new User
            //    {
            //        Email = "admin@test.com",
            //        PasswordHash = "password",
            //        EmployeeId = 1
            //    });
            //}
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
    }
}


