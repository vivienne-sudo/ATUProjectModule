using Android.App;
using Android.OS;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Threading.Tasks;
using System.Windows.Input;
using V2VB.Services;
using static Android.Telephony.CarrierConfigManager;
using V2VB.Data;

namespace V2VB.ViewModel
{
    public class EmployeeLoginViewModel : INotifyPropertyChanged
    {
        private readonly IDbContextFactory<AppDbContext> _dbContextFactory;
        private readonly INavigationService _navigationService;

        public EmployeeLoginViewModel(IDbContextFactory<AppDbContext> dbContextFactory, INavigationService navigationService)
        {
            _dbContextFactory = dbContextFactory;
            _navigationService = navigationService;
            LoginCommand = new Command(async () => await LoginAsync());
        }

        private string _employeeCode;
        public string EmployeeCode
        {
            get => _employeeCode;
            set
            {
                _employeeCode = value;
                OnPropertyChanged(nameof(EmployeeCode));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public System.Windows.Input.ICommand LoginCommand { get; }

        private async Task LoginAsync()
        {
            try
            {
                using var context = _dbContextFactory.CreateDbContext();
                var employee = await context.Employees.SingleOrDefaultAsync(e => e.EmployeeCode == EmployeeCode);
                if (employee == null)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Login Failed", "Invalid employee code", "OK");
                    return;
                }

                if (employee.Password != Password)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Login Failed", "Invalid employee code", "OK");
                    return;
                }

                // Set the current employee to the logged in employee
                App.CurrentEmployee = employee;

                // Navigate to the employee dashboard
                await _navigationService.NavigateToAsync("//EmployeeDashboard");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Application.Current.MainPage.DisplayAlert("Error", "An error occurred while logging in", "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}