using Android.Renderscripts;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using V2VB.Model;
using V2VB.ViewModel;
using Xamarin.Forms;

namespace YourNamespace.ViewModels
{
    public class SignUpLoginViewModel : BaseViewModel
    {
        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand LoginCommand { get; }
        public ICommand SignUpCommand { get; }

        public SignUpLoginViewModel()
        {
            LoginCommand = new Command(async () => await ExecuteLoginCommand());
            SignUpCommand = new Command(async () => await ExecuteSignUpCommand());
        }

        private async Task ExecuteLoginCommand()
        {
            // Implement your login logic here
        }

        private async Task ExecuteSignUpCommand()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Email and password are required", "OK");
                return;
            }

            var existingUser = await _database.Table<User>().Where(u => u.Email == Email).FirstOrDefaultAsync();

            if (existingUser != null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "An account with this email already exists", "OK");
                return;
            }

            // Hash the user's password using BCrypt.Net
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(Password);

            var newUser = new User
            {
                Email = Email,
                Password = passwordHash, // Store the hashed password in the database
                IsCompanyOwner = false
            };

            await _database.InsertAsync(newUser);

            // Navigate to the main app page
        }


    }
}
